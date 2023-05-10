using System.Diagnostics;

namespace PizzariaDoZe
{
    public partial class janelaPrincipal : Form
    {
        public janelaPrincipal()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.AjustaResourcesItem(contextMenuStripPrincipal);

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
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
    }
}