using PizzariaDoZe_DAO;
using System.Configuration;
using System.Data;

namespace PizzariaDoZe
{
    public partial class Clientes : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly ClienteDAO clienteDAO;
        public Clientes()
        {
            InitializeComponent();
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            clienteDAO = new ClienteDAO(provider, strConnection);
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            inputCep.Leave += inputCep_Leave;
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

        private void inputCep_Leave(object? sender, EventArgs e)
        {
            if (inputCep.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = inputCep.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                inputIId.Text = "";
                //userControlEndereco.maskedTextBoxCep.Text = "";
                inputLogradouro.Text = "";
                inputBairro.Text = "";
                inputCidade.Text = "";
                inputUF.Text = "";
                inputPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    inputIId.Text = row["id"].ToString(); ;
                    inputCep.Text = row["cep"].ToString(); ;
                    inputLogradouro.Text = row["logradouro"].ToString(); ;
                    inputBairro.Text = row["bairro"].ToString(); ;
                    inputCidade.Text = row["cidade"].ToString(); ;
                    inputUF.Text = row["uf"].ToString(); ;
                    inputPais.Text = row["pais"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (inputIId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = 0,
                Nome = inputNome.Text,
                Cpf = inputCpf.Text,
                Telefone = inputTelefone.Text,
                Email = inputEmail.Text,
                EnderecoId = int.Parse(inputIId.Text),
                Numero = inputNumero.Text,
                Complemento = inputComplemento.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdClienteGerado = clienteDAO.Inserir(cliente);
                MessageBox.Show("Dados inseridos com sucesso! " + IdClienteGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
