using PizzariaDoZe_DAO;
using System.Configuration;
using System.Data;
using static PizzariaDoZe.ClassEnums;

namespace PizzariaDoZe
{
    public partial class janelaPrincipal : Form
    {
        private ClienteDAO clienteDAO;
        public janelaPrincipal()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.AjustaResourcesItem(contextMenuStripPrincipal);

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            clienteDAO = new ClienteDAO(provider, strConnection);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            AtualizarTela();

        }

        /// <summary>
        /// Respons�vel por colocar a aplica��o na bandeja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void janelaPrincipal_Resize_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
                notifyIconSystemTray.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }

        }

        /// <summary>
        /// Independente da forma que o usu�rio desejar sair da aplica��o
        /// vai aparecer mensagens de confirma��o
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void janelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Deseja Sair?", "Fechar", MessageBoxButtons.YesNoCancel);

            if (dg == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                janelaPrincipal_Resize_1((Form)sender, e);
            }

        }

        /// <summary>
        /// Respons�vel por encerrar a aplica��o por meio do menu
        /// quando a mesma estiver minimizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Respons�vel pelo "Sobre"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Criado em 2023 com o intuito de facilitar o atendimento de clientes e controle de informa��es da Pizzaria do Z�");
        }

        /// <summary>
        /// Ambos respons�veis por abrir a aplica��o, tanto por
        /// duplo clique quanto pelo "Abrir Aplica��o" quando ela estiver
        /// minimizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void abrirAplica��oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void AtualizarTela()
        {
            //Inst�ncia e Preenche o objeto com os dados da view
            var cliente = new Cliente();
            try
            {
                //chama o m�todo para buscar todos os dados da nossa camada model
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
                // formata valor num�rico com duas casa decimais
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }

        }
    }
}