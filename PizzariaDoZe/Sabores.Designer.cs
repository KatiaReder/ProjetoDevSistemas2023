namespace PizzariaDoZe
{
    partial class Sabores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sabores));
            background = new Panel();
            dataGridViewDados = new DataGridView();
            checkedListBoxIngredientes = new CheckedListBox();
            menu1 = new Menu();
            pictureBoxImagem = new PictureBox();
            listBoxTipo = new ComboBox();
            labelTipos = new Label();
            listBoxCategoria = new ComboBox();
            labelCategorias = new Label();
            labelIngredientesSabores = new Label();
            btnCadastrar = new Button();
            inputNome = new TextBox();
            inputId = new TextBox();
            labelNome = new Label();
            tituloSabores = new Label();
            labelId = new Label();
            panel1 = new Panel();
            background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // background
            // 
            background.BackColor = Color.Honeydew;
            background.Controls.Add(panel1);
            background.Controls.Add(dataGridViewDados);
            background.Controls.Add(checkedListBoxIngredientes);
            background.Controls.Add(menu1);
            background.Controls.Add(listBoxTipo);
            background.Controls.Add(labelTipos);
            background.Controls.Add(listBoxCategoria);
            background.Controls.Add(labelCategorias);
            background.Controls.Add(labelIngredientesSabores);
            background.Controls.Add(btnCadastrar);
            background.Controls.Add(inputNome);
            background.Controls.Add(inputId);
            background.Controls.Add(labelNome);
            background.Controls.Add(tituloSabores);
            background.Controls.Add(labelId);
            background.Dock = DockStyle.Fill;
            background.Location = new Point(0, 0);
            background.Name = "background";
            background.Size = new Size(800, 450);
            background.TabIndex = 6;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(168, 330);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(347, 108);
            dataGridViewDados.TabIndex = 47;
            dataGridViewDados.CellFormatting += dataGridViewDados_CellFormatting;
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.BackColor = Color.DarkSeaGreen;
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Location = new Point(555, 90);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(217, 220);
            checkedListBoxIngredientes.TabIndex = 46;
            // 
            // menu1
            // 
            menu1.BackColor = Color.DarkSeaGreen;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(142, 459);
            menu1.TabIndex = 45;
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.Location = new Point(50, 1);
            pictureBoxImagem.Name = "pictureBoxImagem";
            pictureBoxImagem.Size = new Size(237, 140);
            pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagem.TabIndex = 44;
            pictureBoxImagem.TabStop = false;
            pictureBoxImagem.Click += pictureBoxImagem_Click;
            // 
            // listBoxTipo
            // 
            listBoxTipo.BackColor = Color.RosyBrown;
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.Items.AddRange(new object[] { "Salgada", "Doce" });
            listBoxTipo.Location = new Point(217, 145);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(102, 23);
            listBoxTipo.TabIndex = 1;
            listBoxTipo.Text = "Salgada";
            // 
            // labelTipos
            // 
            labelTipos.AutoSize = true;
            labelTipos.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipos.Location = new Point(253, 124);
            labelTipos.Name = "labelTipos";
            labelTipos.Size = new Size(38, 18);
            labelTipos.TabIndex = 42;
            labelTipos.Tag = "";
            labelTipos.Text = "Tipos";
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.BackColor = Color.RosyBrown;
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.Items.AddRange(new object[] { "Tradicional", "Especial" });
            listBoxCategoria.Location = new Point(371, 145);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(116, 23);
            listBoxCategoria.TabIndex = 2;
            listBoxCategoria.Text = "Tradicional";
            // 
            // labelCategorias
            // 
            labelCategorias.AutoSize = true;
            labelCategorias.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategorias.Location = new Point(399, 124);
            labelCategorias.Name = "labelCategorias";
            labelCategorias.Size = new Size(66, 18);
            labelCategorias.TabIndex = 39;
            labelCategorias.Tag = "";
            labelCategorias.Text = "Categorias";
            // 
            // labelIngredientesSabores
            // 
            labelIngredientesSabores.AutoSize = true;
            labelIngredientesSabores.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngredientesSabores.Location = new Point(555, 65);
            labelIngredientesSabores.Name = "labelIngredientesSabores";
            labelIngredientesSabores.Size = new Size(192, 22);
            labelIngredientesSabores.TabIndex = 38;
            labelIngredientesSabores.Text = " Ingredientes Cadastrados";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkSeaGreen;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(542, 383);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(230, 36);
            btnCadastrar.TabIndex = 36;
            btnCadastrar.Text = "Cadastrar ";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            btnCadastrar.KeyUp += btnCadastrar_KeyUp;
            // 
            // inputNome
            // 
            inputNome.Location = new Point(281, 89);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(234, 23);
            inputNome.TabIndex = 0;
            // 
            // inputId
            // 
            inputId.Location = new Point(193, 89);
            inputId.Name = "inputId";
            inputId.ReadOnly = true;
            inputId.Size = new Size(59, 23);
            inputId.TabIndex = 9;
            inputId.TabStop = false;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(399, 69);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 18);
            labelNome.TabIndex = 3;
            labelNome.Tag = "";
            labelNome.Text = "Nome";
            // 
            // tituloSabores
            // 
            tituloSabores.AutoSize = true;
            tituloSabores.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloSabores.Location = new Point(327, 9);
            tituloSabores.Name = "tituloSabores";
            tituloSabores.Size = new Size(290, 37);
            tituloSabores.TabIndex = 2;
            tituloSabores.Text = "Cadastro de Sabores";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(213, 69);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 18);
            labelId.TabIndex = 0;
            labelId.Text = "Id";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(pictureBoxImagem);
            panel1.Location = new Point(167, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 141);
            panel1.TabIndex = 48;
            // 
            // Sabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(background);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Sabores";
            Text = "Sabores";
            background.ResumeLayout(false);
            background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel background;
        private PictureBox pictureBoxImagem;
        private ComboBox listBoxTipo;
        private Label labelTipos;
        private ComboBox listBoxCategoria;
        private Label labelCategorias;
        private Label labelIngredientesSabores;
        private Button btnCadastrar;
        private TextBox inputNome;
        private TextBox inputId;
        private Label labelNome;
        private Label tituloSabores;
        private Label labelId;
        private Menu menu1;
        private CheckedListBox checkedListBoxIngredientes;
        private DataGridView dataGridViewDados;
        private Panel panel1;
    }
}