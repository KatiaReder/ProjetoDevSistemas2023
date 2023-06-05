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
using PizzariaDoZe_DAO;

namespace PizzariaDoZe
{
    public partial class Produtos : Form
    {
        private ProdutoDAO produtoDAO;
        public Produtos()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            produtoDAO = new ProdutoDAO(provider, strConnection);

            CarregaEnumListBox();
            AtualizarTela();
        }

        private void btnCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Cadastro de Produtos Salvo!");
            }
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                Id = 0,
                Descricao = inputNome.Text,
                Valor = decimal.Parse(inputValor.Text),
                Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), listBoxTipo.Text),
                ML = inputMl.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                produtoDAO.Inserir(produto);
                MessageBox.Show("Dados inseridos com sucesso!");
                AtualizarTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = produtoDAO.Buscar(produto);
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
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Tamanho"))
            {
                e.Value = ClassEnums.GetDescription((EnumValorTamanho)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Tipo"))
            {
                e.Value = ClassEnums.GetDescription((EnumSaborTipo)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Tipo Produto"))
            {
                e.Value = ClassEnums.GetDescription((EnumProdutoTipo)char.Parse(e.Value.ToString()));
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
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Valor") || this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Valor Borda"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
        }
    }
}
