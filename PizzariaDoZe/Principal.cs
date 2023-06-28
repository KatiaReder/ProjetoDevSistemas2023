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

        }

        /// <summary>
        /// Responsável por colocar a aplicação na bandeja
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
        /// Independente da forma que o usuário desejar sair da aplicação
        /// vai aparecer mensagens de confirmação
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
        /// Responsável por encerrar a aplicação por meio do menu
        /// quando a mesma estiver minimizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Responsável pelo "Sobre"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Criado em 2023 com o intuito de facilitar o atendimento de clientes e controle de informações da Pizzaria do Zé");
        }

        /// <summary>
        /// Ambos responsáveis por abrir a aplicação, tanto por
        /// duplo clique quanto pelo "Abrir Aplicação" quando ela estiver
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

        private void abrirAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }
    }
}