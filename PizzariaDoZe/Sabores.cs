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
using PizzariaDoZe_DAO;
using static PizzariaDoZe.ClassEnums;

namespace PizzariaDoZe
{
    public partial class Sabores : Form
    {
        private IngredienteDAO ingredienteDAO;
        private SaborDAO saborDAO;
        public Sabores()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            ingredienteDAO = new IngredienteDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);

            CarregaIngredientesCheckedListBox();
            CarregaEnumListBox();
            AtualizarTela();

        }

        private void btnCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Cadastro de Funcionário Salvo!");
            }
        }

        private void CarregaIngredientesCheckedListBox()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBoxIngredientes.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    checkedListBoxIngredientes.Items.Add(new Ingrediente(int.Parse(row["ID"].ToString()), row["Nome"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxCategoria
            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
            //popular listBoxTipo
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumSaborTipo));
        }

        private void pictureBoxImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogImagem = new()
            {
                Title = "Imagem do produto",
                Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.icon;*.JFIF"
            };
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                //pega a imagem escolhida e adiciona na tela
                pictureBoxImagem.Image = Image.FromFile(openFileDialogImagem.FileName);
                //redimensiona a imagem
                pictureBoxImagem.Image = (Image)(new Bitmap(pictureBoxImagem.Image, new Size(130, 98)));
                //ajusta a visualização no tamanho do pictureBoxImagem na tela
                pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                Id = 0,
                Descricao = inputNome.Text,
                Foto = Funcoes.ConverteImagemParaByteArray(pictureBoxImagem.Image),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                Tipo = (char)(EnumSaborTipo)Enum.Parse(typeof(EnumSaborTipo), listBoxTipo.Text),
                SaborIngredientes = checkedListBoxIngredientes.CheckedItems.OfType<Ingrediente>().ToList(),
            };
            try
            {
                // chama o método para inserir da camada model
                saborDAO.Inserir(sabor);
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
            var sabor = new Sabor();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = saborDAO.Buscar(sabor);
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

        private void dataGridViewDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewDados.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }
            if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = ClassEnums.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Categoria"))
            {
                e.Value = ClassEnums.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Tipo"))
            {
                e.Value = ClassEnums.GetDescription((EnumSaborTipo)char.Parse(e.Value.ToString()));
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
