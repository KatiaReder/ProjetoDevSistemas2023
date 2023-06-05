using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PizzariaDoZe.ClassEnums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PizzariaDoZe_DAO;
using System.Configuration;

namespace PizzariaDoZe
{
    public partial class Valores : Form
    {
        private ValorDAO valorDAO;
        public Valores()
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
            valorDAO = new ValorDAO(provider, strConnection);

            CarregaEnumListBox();
            AtualizarTela();
        }

        private void btnCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Cadastro de Valores Salvo!");
            }
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTamanho.Items.Clear();
            listBoxTamanho.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
            //popular listBoxCategoria
            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor
            {
                Id = 0,
                Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanho.Text),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                ValorPizza = decimal.Parse(inputValor.Text),
                ValorBorda = decimal.Parse(inputValorBorda.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                valorDAO.Inserir(valor);
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
            var valor = new Valor();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = valorDAO.Buscar(valor);
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
