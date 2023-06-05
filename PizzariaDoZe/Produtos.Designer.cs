namespace PizzariaDoZe
{
    partial class Produtos
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
            Label labelObservacao;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            menu1 = new Menu();
            background = new Panel();
            listBoxTipo = new ListBox();
            inputValor = new TextBox();
            labelProduto = new Label();
            inputObservacao = new MaskedTextBox();
            inputMl = new ComboBox();
            labelMl = new Label();
            btnCadastrar = new Button();
            inputNome = new TextBox();
            inputId = new TextBox();
            labelNome = new Label();
            labelValor = new Label();
            labelId = new Label();
            tituloProdutos = new Label();
            dataGridViewDados = new DataGridView();
            labelObservacao = new Label();
            background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // labelObservacao
            // 
            labelObservacao.AutoSize = true;
            labelObservacao.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelObservacao.Location = new Point(200, 164);
            labelObservacao.Name = "labelObservacao";
            labelObservacao.Size = new Size(120, 18);
            labelObservacao.TabIndex = 43;
            labelObservacao.Tag = "";
            labelObservacao.Text = "Observação - Outros";
            // 
            // menu1
            // 
            menu1.BackColor = Color.DarkSeaGreen;
            menu1.Location = new Point(-1, -3);
            menu1.Name = "menu1";
            menu1.Size = new Size(153, 457);
            menu1.TabIndex = 0;
            // 
            // background
            // 
            background.BackColor = Color.Honeydew;
            background.Controls.Add(dataGridViewDados);
            background.Controls.Add(listBoxTipo);
            background.Controls.Add(inputValor);
            background.Controls.Add(labelProduto);
            background.Controls.Add(labelObservacao);
            background.Controls.Add(inputObservacao);
            background.Controls.Add(inputMl);
            background.Controls.Add(labelMl);
            background.Controls.Add(btnCadastrar);
            background.Controls.Add(inputNome);
            background.Controls.Add(inputId);
            background.Controls.Add(labelNome);
            background.Controls.Add(labelValor);
            background.Controls.Add(labelId);
            background.Controls.Add(tituloProdutos);
            background.Location = new Point(151, -3);
            background.Name = "background";
            background.Size = new Size(649, 457);
            background.TabIndex = 2;
            // 
            // listBoxTipo
            // 
            listBoxTipo.BackColor = Color.DarkSeaGreen;
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Items.AddRange(new object[] { "Refrigerante", "Cerveja", "Suco", "Água", "Outros" });
            listBoxTipo.Location = new Point(420, 102);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(200, 214);
            listBoxTipo.TabIndex = 46;
            // 
            // inputValor
            // 
            inputValor.Location = new Point(260, 101);
            inputValor.Name = "inputValor";
            inputValor.Size = new Size(118, 23);
            inputValor.TabIndex = 45;
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProduto.Location = new Point(453, 80);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(100, 18);
            labelProduto.TabIndex = 44;
            labelProduto.Tag = "cpfFuncionario";
            labelProduto.Text = "Tipo de Produto";
            // 
            // inputObservacao
            // 
            inputObservacao.Location = new Point(141, 185);
            inputObservacao.Name = "inputObservacao";
            inputObservacao.Size = new Size(237, 23);
            inputObservacao.TabIndex = 3;
            // 
            // inputMl
            // 
            inputMl.AccessibleRole = AccessibleRole.Grip;
            inputMl.AllowDrop = true;
            inputMl.BackColor = Color.RosyBrown;
            inputMl.FormattingEnabled = true;
            inputMl.Items.AddRange(new object[] { "150ml", "300ml", "600ml", "1000ml", "1500ml", "2000ml" });
            inputMl.Location = new Point(50, 185);
            inputMl.Name = "inputMl";
            inputMl.Size = new Size(85, 23);
            inputMl.TabIndex = 2;
            inputMl.Text = "150ml";
            // 
            // labelMl
            // 
            labelMl.AutoSize = true;
            labelMl.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMl.Location = new Point(74, 164);
            labelMl.Name = "labelMl";
            labelMl.Size = new Size(25, 18);
            labelMl.TabIndex = 38;
            labelMl.Tag = "";
            labelMl.Text = "ML";
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
            // inputNome
            // 
            inputNome.Location = new Point(105, 101);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(149, 23);
            inputNome.TabIndex = 0;
            // 
            // inputId
            // 
            inputId.Location = new Point(50, 101);
            inputId.Name = "inputId";
            inputId.ReadOnly = true;
            inputId.Size = new Size(49, 23);
            inputId.TabIndex = 15;
            inputId.TabStop = false;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(157, 80);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(44, 18);
            labelNome.TabIndex = 14;
            labelNome.Tag = "";
            labelNome.Text = "Nome ";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValor.Location = new Point(308, 80);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(37, 18);
            labelValor.TabIndex = 13;
            labelValor.Tag = "cpfFuncionario";
            labelValor.Text = "Valor";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(65, 80);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 18);
            labelId.TabIndex = 12;
            labelId.Text = "Id";
            // 
            // tituloProdutos
            // 
            tituloProdutos.AutoSize = true;
            tituloProdutos.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloProdutos.Location = new Point(169, 19);
            tituloProdutos.Name = "tituloProdutos";
            tituloProdutos.Size = new Size(305, 37);
            tituloProdutos.TabIndex = 3;
            tituloProdutos.Text = "Cadastro de Produtos";
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.BackgroundColor = Color.DarkSeaGreen;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(45, 256);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(310, 138);
            dataGridViewDados.TabIndex = 47;
            dataGridViewDados.CellFormatting += dataGridViewDados_CellFormatting;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(background);
            Controls.Add(menu1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Produtos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            background.ResumeLayout(false);
            background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private Panel background;
        private Label tituloProdutos;
        private TextBox inputNome;
        private TextBox inputId;
        private Label labelNome;
        private Label labelValor;
        private Label labelId;
        private Button btnCadastrar;
        private ComboBox inputMl;
        private Label labelMl;
        private Label labelProduto;
        private MaskedTextBox inputObservacao;
        private ListBox listBoxTipo;
        private TextBox inputValor;
        private DataGridView dataGridViewDados;
    }
}