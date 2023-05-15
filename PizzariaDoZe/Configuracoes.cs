using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            //seleciona no comboBox o idioma/cultura atual
            comboBoxIdioma.SelectedItem = ConfigurationManager.AppSettings.Get("Idioma");

            // busca os dados com nome BD
            ConnectionStringSettings connectionStringSettings =
            ConfigurationManager.ConnectionStrings["BD"];
            // obtém o providerName e atualiza em tela
            comboBoxProvider.Text = connectionStringSettings.ProviderName;
            // obtém a connectionString e atualiza em tela
            textBoxConexao.Text = connectionStringSettings.ConnectionString;

   
        }

        private void btnSalvarIdioma_Click(object sender, EventArgs e)
        {

            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //altera os valores de provider e da connectionStrings com nome BD
            config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxProvider.Text;
            config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = textBoxConexao.Text;
            //salva as alterações
            config.Save(ConfigurationSaveMode.Modified, true);
            //recarrega os dados da seção especificada
            ConfigurationManager.RefreshSection("connectionStrings");

            config.AppSettings.Settings.Remove("Idioma");
            config.AppSettings.Settings.Add("Idioma", comboBoxIdioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        
 
            //dispara msg para usuário
            _ = MessageBox.Show("Dados alterados com sucesso!");

            // valida se a base de dados já existe e se esta configurada corretamente
            ValidaConexaoDB();

            Close();

            if (checkBoxIdiomaReiniciar.Checked)
            {
                _ = MessageBox.Show("Idioma/região alterada com sucesso! Reinicie a aplicação para aplicar o novo Idioma/região!");

                //reinicia o projeto com o idioma selecionado no comboBoxIdioma
                Application.Restart();
                Environment.Exit(0);

            }
        }

        public static void ValidaConexaoDB()
        {

            DbProviderFactory factory;

            try
            {
                factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["BD"].ProviderName);
                using var conexao = factory.CreateConnection();
                conexao!.ConnectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
                using var comando = factory.CreateCommand();
                comando!.Connection = conexao;
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new Configuracoes().ShowDialog();
                ValidaConexaoDB();
            }
   
        }
    }
}