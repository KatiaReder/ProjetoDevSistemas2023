namespace PizzariaDoZe
{
    partial class Valores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Valores));
            principalBack = new Panel();
            dataGridViewDados = new DataGridView();
            inputValorBorda = new TextBox();
            inputValor = new TextBox();
            listBoxCategoria = new ComboBox();
            labelCategoria = new Label();
            labelBorda = new Label();
            listBoxTamanho = new ComboBox();
            labelTamanho = new Label();
            btnCadastrar = new Button();
            inputId = new TextBox();
            labelValor = new Label();
            labelId = new Label();
            tituloValores = new Label();
            menu1 = new Menu();
            principalBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // principalBack
            // 
            principalBack.BackColor = Color.Honeydew;
            principalBack.Controls.Add(dataGridViewDados);
            principalBack.Controls.Add(inputValorBorda);
            principalBack.Controls.Add(inputValor);
            principalBack.Controls.Add(listBoxCategoria);
            principalBack.Controls.Add(labelCategoria);
            principalBack.Controls.Add(labelBorda);
            principalBack.Controls.Add(listBoxTamanho);
            principalBack.Controls.Add(labelTamanho);
            principalBack.Controls.Add(btnCadastrar);
            principalBack.Controls.Add(inputId);
            principalBack.Controls.Add(labelValor);
            principalBack.Controls.Add(labelId);
            principalBack.Controls.Add(tituloValores);
            principalBack.Location = new Point(139, 0);
            principalBack.Name = "principalBack";
            principalBack.Size = new Size(661, 457);
            principalBack.TabIndex = 3;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(56, 299);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(272, 123);
            dataGridViewDados.TabIndex = 51;
            dataGridViewDados.CellFormatting += dataGridViewDados_CellFormatting;
            // 
            // inputValorBorda
            // 
            inputValorBorda.Location = new Point(353, 129);
            inputValorBorda.Name = "inputValorBorda";
            inputValorBorda.Size = new Size(186, 23);
            inputValorBorda.TabIndex = 50;
            // 
            // inputValor
            // 
            inputValor.Location = new Point(159, 129);
            inputValor.Name = "inputValor";
            inputValor.Size = new Size(186, 23);
            inputValor.TabIndex = 49;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.AccessibleRole = AccessibleRole.Grip;
            listBoxCategoria.AllowDrop = true;
            listBoxCategoria.BackColor = Color.RosyBrown;
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.Items.AddRange(new object[] { "Tradicional", "Especial" });
            listBoxCategoria.Location = new Point(353, 224);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(179, 23);
            listBoxCategoria.TabIndex = 3;
            listBoxCategoria.Text = "Tradicional";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoria.Location = new Point(408, 203);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(61, 18);
            labelCategoria.TabIndex = 48;
            labelCategoria.Tag = "";
            labelCategoria.Text = "Categoria";
            // 
            // labelBorda
            // 
            labelBorda.AutoSize = true;
            labelBorda.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBorda.Location = new Point(391, 108);
            labelBorda.Name = "labelBorda";
            labelBorda.Size = new Size(137, 18);
            labelBorda.TabIndex = 45;
            labelBorda.Tag = "cpfFuncionario";
            labelBorda.Text = "Valor - Adicional Borda";
            // 
            // listBoxTamanho
            // 
            listBoxTamanho.AccessibleRole = AccessibleRole.Grip;
            listBoxTamanho.AllowDrop = true;
            listBoxTamanho.BackColor = Color.RosyBrown;
            listBoxTamanho.FormattingEnabled = true;
            listBoxTamanho.Items.AddRange(new object[] { "Pequena", "Média", "Família", "Grande" });
            listBoxTamanho.Location = new Point(86, 224);
            listBoxTamanho.Name = "listBoxTamanho";
            listBoxTamanho.Size = new Size(179, 23);
            listBoxTamanho.TabIndex = 2;
            listBoxTamanho.Text = "Pequena";
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTamanho.Location = new Point(149, 203);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(57, 18);
            labelTamanho.TabIndex = 38;
            labelTamanho.Tag = "";
            labelTamanho.Text = "Tamanho";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkSeaGreen;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(391, 405);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(246, 36);
            btnCadastrar.TabIndex = 37;
            btnCadastrar.Text = "Cadastrar ";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            btnCadastrar.KeyUp += btnCadastrar_KeyUp;
            // 
            // inputId
            // 
            inputId.Location = new Point(72, 129);
            inputId.Name = "inputId";
            inputId.ReadOnly = true;
            inputId.Size = new Size(49, 23);
            inputId.TabIndex = 15;
            inputId.TabStop = false;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValor.Location = new Point(218, 108);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(37, 18);
            labelValor.TabIndex = 13;
            labelValor.Tag = "";
            labelValor.Text = "Valor";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(86, 108);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 18);
            labelId.TabIndex = 12;
            labelId.Text = "Id";
            // 
            // tituloValores
            // 
            tituloValores.AutoSize = true;
            tituloValores.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloValores.Location = new Point(159, 23);
            tituloValores.Name = "tituloValores";
            tituloValores.Size = new Size(283, 37);
            tituloValores.TabIndex = 3;
            tituloValores.Text = "Cadastro de Valores";
            // 
            // menu1
            // 
            menu1.BackColor = Color.DarkSeaGreen;
            menu1.Location = new Point(-2, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(144, 454);
            menu1.TabIndex = 4;
            // 
            // Valores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menu1);
            Controls.Add(principalBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Valores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Valores";
            principalBack.ResumeLayout(false);
            principalBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel principalBack;
        private Label labelCategoria;
        private Label labelBorda;
        private ComboBox listBoxTamanho;
        private Label labelTamanho;
        private Button btnCadastrar;
        private TextBox inputId;
        private Label labelValor;
        private Label labelId;
        private Label tituloValores;
        private Menu menu1;
        private ComboBox listBoxCategoria;
        private TextBox inputValorBorda;
        private TextBox inputValor;
        private DataGridView dataGridViewDados;
    }
}