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
            menu1 = new Menu();
            fotoSaborPizza = new PictureBox();
            inputTipos = new ComboBox();
            labelTipos = new Label();
            inputCategorias = new ComboBox();
            listIngredientesCadastrados = new CheckedListBox();
            labelCategorias = new Label();
            labelIngredientesSabores = new Label();
            btnCadastrar = new Button();
            inputNome = new TextBox();
            inputId = new TextBox();
            labelNome = new Label();
            tituloSabores = new Label();
            labelId = new Label();
            background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fotoSaborPizza).BeginInit();
            SuspendLayout();
            // 
            // background
            // 
            background.BackColor = Color.Honeydew;
            background.Controls.Add(menu1);
            background.Controls.Add(fotoSaborPizza);
            background.Controls.Add(inputTipos);
            background.Controls.Add(labelTipos);
            background.Controls.Add(inputCategorias);
            background.Controls.Add(listIngredientesCadastrados);
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
            // menu1
            // 
            menu1.BackColor = Color.DarkSeaGreen;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(142, 459);
            menu1.TabIndex = 45;
            // 
            // fotoSaborPizza
            // 
            fotoSaborPizza.Image = Properties.Resources.pizza;
            fotoSaborPizza.Location = new Point(193, 192);
            fotoSaborPizza.Name = "fotoSaborPizza";
            fotoSaborPizza.Size = new Size(322, 216);
            fotoSaborPizza.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoSaborPizza.TabIndex = 44;
            fotoSaborPizza.TabStop = false;
            // 
            // inputTipos
            // 
            inputTipos.BackColor = Color.RosyBrown;
            inputTipos.FormattingEnabled = true;
            inputTipos.Items.AddRange(new object[] { "Salgada", "Doce" });
            inputTipos.Location = new Point(217, 145);
            inputTipos.Name = "inputTipos";
            inputTipos.Size = new Size(102, 23);
            inputTipos.TabIndex = 1;
            inputTipos.Text = "Salgada";
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
            // inputCategorias
            // 
            inputCategorias.BackColor = Color.RosyBrown;
            inputCategorias.FormattingEnabled = true;
            inputCategorias.Items.AddRange(new object[] { "Tradicional", "Especial" });
            inputCategorias.Location = new Point(371, 145);
            inputCategorias.Name = "inputCategorias";
            inputCategorias.Size = new Size(116, 23);
            inputCategorias.TabIndex = 2;
            inputCategorias.Text = "Tradicional";
            // 
            // listIngredientesCadastrados
            // 
            listIngredientesCadastrados.BackColor = Color.DarkSeaGreen;
            listIngredientesCadastrados.FormattingEnabled = true;
            listIngredientesCadastrados.Items.AddRange(new object[] { "Queijo", "Orégano", "Molho de Tomate" });
            listIngredientesCadastrados.Location = new Point(542, 90);
            listIngredientesCadastrados.Name = "listIngredientesCadastrados";
            listIngredientesCadastrados.Size = new Size(230, 256);
            listIngredientesCadastrados.TabIndex = 3;
            listIngredientesCadastrados.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)fotoSaborPizza).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel background;
        private PictureBox fotoSaborPizza;
        private ComboBox inputTipos;
        private Label labelTipos;
        private ComboBox inputCategorias;
        private CheckedListBox listIngredientesCadastrados;
        private Label labelCategorias;
        private Label labelIngredientesSabores;
        private Button btnCadastrar;
        private TextBox inputNome;
        private TextBox inputId;
        private Label labelNome;
        private Label tituloSabores;
        private Label labelId;
        private Menu menu1;
    }
}