using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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
        }

        private void btnSalvarIdioma_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("Idioma");
            config.AppSettings.Settings.Add("Idioma", comboBoxIdioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();
            _ = MessageBox.Show("Idioma/região alterada com sucesso! Reinicie a aplicação para aplicar o novo Idioma/região!");

            if (checkBoxIdiomaReiniciar.Checked)
            {
                //reinicia o projeto com o idioma selecionado no comboBoxIdioma
                Application.Restart();
                Environment.Exit(0);

            }
        }
    }
}