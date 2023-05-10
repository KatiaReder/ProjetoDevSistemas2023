namespace PizzariaDoZe
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
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
                MessageBox.Show("Cadastro de Cliente Salvo!");
            }
        }
    }
}
