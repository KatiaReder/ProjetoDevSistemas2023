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

namespace PizzariaDoZe
{
    public partial class PedidosListagem : Form
    {

        private PedidoDAO pedidoDAO;
        public PedidosListagem()
        {
            InitializeComponent();

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            pedidoDAO = new PedidoDAO(provider, strConnection);

            AtualizarTela();
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

        private void btnRelatorioCompleto_Click(object sender, EventArgs e)
        {
            string pathArquivo = ClassGeraPdf.pathArquivo("RelPedidos");
            ClassGeraPdf.PdfPedido(pathArquivo, 0);
        }

        private void btnRelatorioIndividual_Click(object sender, EventArgs e)
        {
            if (dataGridViewDados.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Selecione um item!");
                return;
            }
            //pega a primeira coluna, que esta com o ID, da linha selecionada
            DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
            int id = Convert.ToInt32(selectedRow.Cells[0].Value);
            string pathArquivo = ClassGeraPdf.pathArquivo("RelPedido");
            ClassGeraPdf.PdfPedido(pathArquivo, id);
        }
    }
}
