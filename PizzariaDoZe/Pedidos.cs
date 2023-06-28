using PizzariaDoZe_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PizzariaDoZe.ClassEnums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe
{
    public partial class Pedidos : Form
    {
        private IngredienteDAO ingredienteDAO;
        private SaborDAO saborDAO;
        private ProdutoDAO produtoDAO;
        private PedidoDAO pedidoDAO;
        public Pedidos()
        {
            InitializeComponent();

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            ingredienteDAO = new IngredienteDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);
            produtoDAO = new ProdutoDAO(provider, strConnection);
            pedidoDAO = new PedidoDAO(provider, strConnection);

            CarregaEnumListBox();
            CarregaIngredientesCheckedListBox();
            CarregaSaboresCheckedListBox();
            CarregaProdutosCheckedListBox();
            AtualizarTela();
        }

        private void CarregaEnumListBox()
        {
            inputTipoEntrega.Items.Clear();
            inputTipoEntrega.DataSource = Enum.GetValues(typeof(EnumEntrega));
        }


        private void CarregaIngredientesCheckedListBox()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBoxIngredientes.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    checkedListBoxIngredientes.Items.Add(new Ingrediente(int.Parse(row["ID"].ToString()), row["Nome"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CarregaSaboresCheckedListBox()
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = saborDAO.Buscar(sabor);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBoxSabores.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    checkedListBoxSabores.Items.Add(new Sabor(int.Parse(row["ID"].ToString()), row["Nome"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaProdutosCheckedListBox()
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = produtoDAO.Buscar(produto);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBoxProdutos.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    checkedListBoxProdutos.Items.Add(new Produto(int.Parse(row["ID"].ToString()), row["Descrição"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var pedido = new Pedido();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = pedidoDAO.Buscar(pedido);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            PedidosListagem pedidosListagem = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = pedidosListagem.ShowDialog();
        }

        private void dataGridViewDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewDados.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }
            if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = ClassEnums.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Categoria"))
            {
                e.Value = ClassEnums.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Tipo"))
            {
                e.Value = ClassEnums.GetDescription((EnumSaborTipo)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Valor"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (inputId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um Pedido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var pedido = new Pedido
            {
                Id = int.Parse(inputId.Text),
            };
            try
            {
                // chama o método da model para excluir
                pedidoDAO.Excluir(pedido);
                MessageBox.Show("Dados excluidos com sucesso! " + inputId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var pedido = new Pedido
            {
                Id = 0,
                Cpf_cliente = inputIdCliente.Text,
                Cpf_funcionario = inputIdFuncionario.Text,
                Entrega = inputTipoEntrega.Text,
                Status_pedido = inputStatusPedido.Text,
                Valor_total = decimal.Parse( inputValorTotal.Text) + (inputTipoEntrega.Text == "Entregar" ? 5 : 0),
                Tipo_pagamento = inputTipoPagamento.Text,
            };
            try
            {

                // chama o método para inserir da camada model
                pedidoDAO.Inserir(pedido);
                MessageBox.Show("Dados inseridos com sucesso!");
                AtualizarTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var pedido = new Pedido
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = pedidoDAO.Buscar(pedido);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    inputId.Text = row[0].ToString();
                    inputIdCliente.Text = row[1].ToString();
                    inputIdFuncionario.Text = row[2].ToString();
                    inputTipoEntrega.Text = ClassEnums.GetDescription((EnumEntrega)char.Parse(row[3].ToString()));
                    inputStatusPedido.Text = row[4].ToString();
                    inputValorTotal.Text = row[5].ToString();
                    inputTipoPagamento.Text = row[6].ToString();
                }
                inputStatusPedido.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewDados_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewDados.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (inputId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um Pedido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var pedido = new Pedido
            {
                Id = int.Parse(inputId.Text),
                Cpf_cliente = inputIdCliente.Text,
                Cpf_funcionario = inputIdFuncionario.Text,
                Entrega = inputTipoEntrega.Text,
                Status_pedido = inputStatusPedido.Text,
                Valor_total = decimal.Parse(inputValorTotal.Text),
                Tipo_pagamento = inputTipoPagamento.Text
            };
            try
            {
                // chama o método para inserir da camada model
                pedidoDAO.Editar(pedido);
                MessageBox.Show("Dados editados com sucesso!");
                AtualizarTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
