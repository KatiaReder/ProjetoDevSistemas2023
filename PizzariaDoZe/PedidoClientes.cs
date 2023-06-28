using MySqlX.XDevAPI;
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
    public partial class PedidoClientes : Form
    {
        private ClienteDAO clienteDAO;
        public PedidoClientes()
        {
            InitializeComponent();

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            clienteDAO = new ClienteDAO(provider, strConnection);
            InputBuscar.Leave += InputBuscar_Leave;
            AtualizarTela();

        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
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



        private void CadastrarCliente_Click(object sender, EventArgs e)
        {
            Clientes clientes = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = clientes.ShowDialog();
        }

        private void DetalhesPedidos_Click(object sender, EventArgs e)
        {
            PedidosListagem pedidosListagem = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = pedidosListagem.ShowDialog();
        }



        private void InputBuscar_Leave(object sender, EventArgs e)
        {

            if (InputBuscar.Text.Trim().Length <= 0)
            {
                return;
            }
            var cliente = new Cliente
            {
                Nome = InputBuscar.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta os dados na tela

                //userControlEndereco.maskedTextBoxCep.Text = "";
                inputIId.Text = "";
                inputNome.Text = "";
                inputCpf.Text = "";
                inputTelefone.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    inputIId.Text = row["id"].ToString(); ;
                    inputNome.Text = row["nome"].ToString(); ;
                    inputCpf.Text = row["cpf"].ToString(); ;
                    inputTelefone.Text = row["telefone"].ToString(); ;
                    //return;
                }

                if (inputIId.Text == "")
                {
                    const string message = "Cliente não encontrado!";
                    const string message2 = "Deseja cadastrar novo cliente?";
                    var result = MessageBox.Show(message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (result == DialogResult.OK)
                    {
                        var result2 = MessageBox.Show(message2, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (result2 == DialogResult.OK)
                        {
                            Clientes clientes = new()
                            {
                                StartPosition = FormStartPosition.CenterScreen,
                            };

                            _ = clientes.ShowDialog();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                const string message = "Cliente não encontrado!";
                const string message2 = "Deseja cadastrar novo cliente?";
                var result = MessageBox.Show(message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                {
                    var result2 = MessageBox.Show(message2, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (result2 == DialogResult.OK)
                    {
                        Clientes clientes = new()
                        {
                            StartPosition = FormStartPosition.CenterScreen,
                        };

                        _ = clientes.ShowDialog();
                    }
                }
            }

        }

        private void dataGridViewDados_DoubleClick(object sender, EventArgs e)
        {

            Clientes clientes = new Clientes();

            if (dataGridViewDados.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                _ = clientes.ShowDialog();
                clientes.AtualizaTelaEditar(id);
            }
        }

        private void dataGridViewDados_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewDados.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }
            if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = ClassEnums.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()));
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

        private void btnCadastrarPedido_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = pedidos.ShowDialog();
        }
    }
}
