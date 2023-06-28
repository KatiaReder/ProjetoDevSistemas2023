using PizzariaDoZe_DAO;
using System.Configuration;
using System.Data;
using static PizzariaDoZe.ClassEnums;

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

        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    inputIId.Text = row[0].ToString();
                    inputNome.Text = row[1].ToString();
                    inputCpf.Text = row[2].ToString();
                    inputTelefone.Text = row[3].ToString();
                    inputEmail.Text = row[4].ToString();
                    inputEnderecoId.Text = row[5].ToString();
                    inputCep.Text = row[6].ToString();
                    inputLogradouro.Text = row[7].ToString();
                    inputBairro.Text = row[8].ToString();
                    inputCidade.Text = row[10].ToString();
                    inputUF.Text = row[12].ToString();
                    inputPais.Text = row[14].ToString();
                    inputNumero.Text = row[15].ToString();
                    inputComplemento.Text = row[16].ToString();
                }
                inputNome.Focus();
                AtualizarTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (inputIId.Text.Length <= 0 || inputEnderecoId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um cliente e endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = int.Parse(inputIId.Text),
                Nome = inputNome.Text,
                Cpf = inputCpf.Text,
                Telefone = inputTelefone.Text,
                Email = inputEmail.Text,
                EnderecoId = int.Parse(inputEnderecoId.Text),
                Numero = inputNumero.Text,
                Complemento = inputComplemento.Text,
            };
            try
            {
                // chama o método da model para editar
                clienteDAO.Editar(cliente);
                MessageBox.Show("Dados editados com sucesso! " + inputIId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewDados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewDados.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (inputIId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um Cliente!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = int.Parse(inputIId.Text),
            };
            try
            {
                // chama o método da model para excluir
                clienteDAO.Excluir(cliente);
                MessageBox.Show("Dados excluidos com sucesso! " + inputIId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
