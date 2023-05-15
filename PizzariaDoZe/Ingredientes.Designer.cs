namespace PizzariaDoZe
{
    partial class Ingredientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingredientes));
            background = new Panel();
            dataGridViewDados = new DataGridView();
            menu1 = new Menu();
            labelIngredientesCadastrados = new Label();
            btnCadastrar = new Button();
            inputNome = new TextBox();
            inputId = new TextBox();
            labelNome = new Label();
            tituloIngredientes = new Label();
            labelId = new Label();
            background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // background
            // 
            background.BackColor = Color.Honeydew;
            background.Controls.Add(dataGridViewDados);
            background.Controls.Add(menu1);
            background.Controls.Add(labelIngredientesCadastrados);
            background.Controls.Add(btnCadastrar);
            background.Controls.Add(inputNome);
            background.Controls.Add(inputId);
            background.Controls.Add(labelNome);
            background.Controls.Add(tituloIngredientes);
            background.Controls.Add(labelId);
            background.Dock = DockStyle.Fill;
            background.Location = new Point(0, 0);
            background.Name = "background";
            background.Size = new Size(800, 450);
            background.TabIndex = 4;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(586, 88);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(194, 233);
            dataGridViewDados.TabIndex = 40;
            // 
            // menu1
            // 
            menu1.BackColor = Color.DarkSeaGreen;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(143, 450);
            menu1.TabIndex = 39;
            // 
            // labelIngredientesCadastrados
            // 
            labelIngredientesCadastrados.AutoSize = true;
            labelIngredientesCadastrados.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngredientesCadastrados.Location = new Point(586, 65);
            labelIngredientesCadastrados.Name = "labelIngredientesCadastrados";
            labelIngredientesCadastrados.Size = new Size(182, 20);
            labelIngredientesCadastrados.TabIndex = 38;
            labelIngredientesCadastrados.Text = " Ingredientes Cadastrados";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkSeaGreen;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(586, 391);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(194, 36);
            btnCadastrar.TabIndex = 36;
            btnCadastrar.Text = "Cadastrar ";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            btnCadastrar.KeyUp += btnCadastrar_KeyUp;
            // 
            // inputNome
            // 
            inputNome.Location = new Point(325, 86);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(217, 23);
            inputNome.TabIndex = 0;
            // 
            // inputId
            // 
            inputId.Location = new Point(250, 86);
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
            labelNome.Location = new Point(398, 65);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 18);
            labelNome.TabIndex = 3;
            labelNome.Tag = "";
            labelNome.Text = "Nome";
            // 
            // tituloIngredientes
            // 
            tituloIngredientes.AutoSize = true;
            tituloIngredientes.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloIngredientes.Location = new Point(269, 9);
            tituloIngredientes.Name = "tituloIngredientes";
            tituloIngredientes.Size = new Size(356, 37);
            tituloIngredientes.TabIndex = 2;
            tituloIngredientes.Text = "Cadastro de Ingredientes";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(269, 65);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 18);
            labelId.TabIndex = 0;
            labelId.Text = "Id";
            // 
            // Ingredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(background);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Ingredientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingredientes";
            background.ResumeLayout(false);
            background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel background;
        private Button btnCadastrar;
        private TextBox inputNome;
        private TextBox inputId;
        private Label labelNome;
        private Label tituloIngredientes;
        private Label labelId;
        private Label labelIngredientesCadastrados;
        private Menu menu1;
        private DataGridView dataGridViewDados;
    }
}