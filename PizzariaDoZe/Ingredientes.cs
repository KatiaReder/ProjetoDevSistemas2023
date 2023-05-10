using PizzariaDoZe_DAO;
using System;
using System.Configuration;

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
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente
            {
                Id_ingrediente= 0,
                Nome = inputNome.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(ingrediente);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}
