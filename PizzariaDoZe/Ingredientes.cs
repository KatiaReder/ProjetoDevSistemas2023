using PizzariaDoZe_DAO;
using System.Data;
using System;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace PizzariaDoZe
{
    public partial class Ingredientes : Form
    {
        private readonly IngredienteDAO dao;

        public Ingredientes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model

            dao = new IngredienteDAO(provider, strConnection);

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            AtualizarTela();

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void btnCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Cadastro de Ingredientes Salvo");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
             int TamanhoMaximo = 30;

            if (inputNome.TextLength > TamanhoMaximo)
            {
                MessageBox.Show("Favor analisar número de catracteres!");
                return;
            }

           else if(inputNome.TextLength == 0)
            {
                MessageBox.Show("Campo nome é obrigatório! Favor inserir um valor.");
                inputNome.BackColor = Color.Tomato;
                return;
   
        
            }
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente
            {
                Id_ingrediente = 0,
                Nome = inputNome.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(ingrediente);
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
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.Buscar(ingrediente);
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
    }
}
