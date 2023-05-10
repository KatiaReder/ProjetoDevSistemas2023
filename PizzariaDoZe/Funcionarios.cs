using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            //Possibilita o uso do ENTER como TAB e ESC parsa sair da página
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        //Responsável por ativar quando é acionado o ENTER no botão de cadastro
        private void btnCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Cadastro de Funcionário Salvo!");
            }
        }

    }
}
