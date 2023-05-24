namespace PizzariaDoZe
{
    partial class Menu
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            logoImg = new PictureBox();
            principal = new Button();
            cadastrarFuncionario = new Button();
            cadastrarClientes = new Button();
            cadastrarIngredientes = new Button();
            cadastrarSabores = new Button();
            oficialPizzaria = new Label();
            cadastrarProdutos = new Button();
            cadastrarValores = new Button();
            btnConfig = new Button();
            cadastrarEndereco = new Button();
            ((System.ComponentModel.ISupportInitialize)logoImg).BeginInit();
            SuspendLayout();
            // 
            // logoImg
            // 
            logoImg.Image = Properties.Resources.pizzaria_tio_zé_logo_1;
            logoImg.Location = new Point(23, 15);
            logoImg.Name = "logoImg";
            logoImg.Size = new Size(101, 83);
            logoImg.SizeMode = PictureBoxSizeMode.StretchImage;
            logoImg.TabIndex = 7;
            logoImg.TabStop = false;
            // 
            // principal
            // 
            principal.BackColor = Color.Transparent;
            principal.Location = new Point(17, 114);
            principal.Name = "principal";
            principal.Size = new Size(107, 26);
            principal.TabIndex = 0;
            principal.Text = "Principal";
            principal.UseVisualStyleBackColor = false;
            principal.Click += principal_Click;
            principal.KeyUp += principal_KeyUp;
            // 
            // cadastrarFuncionario
            // 
            cadastrarFuncionario.Location = new Point(17, 146);
            cadastrarFuncionario.Name = "cadastrarFuncionario";
            cadastrarFuncionario.Size = new Size(107, 26);
            cadastrarFuncionario.TabIndex = 1;
            cadastrarFuncionario.Text = "Funcionário";
            cadastrarFuncionario.UseVisualStyleBackColor = true;
            cadastrarFuncionario.Click += cadastrarFuncionario_Click;
            cadastrarFuncionario.KeyUp += cadastrarFuncionario_KeyUp;
            // 
            // cadastrarClientes
            // 
            cadastrarClientes.Location = new Point(17, 178);
            cadastrarClientes.Name = "cadastrarClientes";
            cadastrarClientes.Size = new Size(107, 26);
            cadastrarClientes.TabIndex = 2;
            cadastrarClientes.Text = "Clientes";
            cadastrarClientes.UseVisualStyleBackColor = true;
            cadastrarClientes.Click += cadastrarClientes_Click;
            cadastrarClientes.KeyUp += cadastrarClientes_KeyUp;
            // 
            // cadastrarIngredientes
            // 
            cadastrarIngredientes.Location = new Point(17, 210);
            cadastrarIngredientes.Name = "cadastrarIngredientes";
            cadastrarIngredientes.Size = new Size(107, 26);
            cadastrarIngredientes.TabIndex = 3;
            cadastrarIngredientes.Text = "Ingredientes";
            cadastrarIngredientes.UseVisualStyleBackColor = true;
            cadastrarIngredientes.Click += cadastrarIngredientes_Click;
            cadastrarIngredientes.KeyUp += cadastrarIngredientes_KeyUp;
            // 
            // cadastrarSabores
            // 
            cadastrarSabores.Location = new Point(17, 242);
            cadastrarSabores.Name = "cadastrarSabores";
            cadastrarSabores.Size = new Size(107, 26);
            cadastrarSabores.TabIndex = 4;
            cadastrarSabores.Text = "Sabores";
            cadastrarSabores.UseVisualStyleBackColor = true;
            cadastrarSabores.Click += cadastrarSabores_Click;
            cadastrarSabores.KeyUp += cadastrarSabores_KeyUp;
            // 
            // oficialPizzaria
            // 
            oficialPizzaria.AutoSize = true;
            oficialPizzaria.FlatStyle = FlatStyle.Popup;
            oficialPizzaria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            oficialPizzaria.ForeColor = Color.DarkGreen;
            oficialPizzaria.Location = new Point(17, 421);
            oficialPizzaria.Name = "oficialPizzaria";
            oficialPizzaria.Size = new Size(113, 15);
            oficialPizzaria.TabIndex = 8;
            oficialPizzaria.Text = "Pizza do Zé ® 2023";
            // 
            // cadastrarProdutos
            // 
            cadastrarProdutos.Location = new Point(17, 274);
            cadastrarProdutos.Name = "cadastrarProdutos";
            cadastrarProdutos.Size = new Size(107, 26);
            cadastrarProdutos.TabIndex = 5;
            cadastrarProdutos.Text = "Produtos";
            cadastrarProdutos.TextAlign = ContentAlignment.BottomCenter;
            cadastrarProdutos.UseVisualStyleBackColor = true;
            cadastrarProdutos.Click += cadastrarPrdutos_Click;
            cadastrarProdutos.KeyUp += cadastrarProdutos_KeyUp;
            // 
            // cadastrarValores
            // 
            cadastrarValores.Location = new Point(17, 306);
            cadastrarValores.Name = "cadastrarValores";
            cadastrarValores.Size = new Size(107, 26);
            cadastrarValores.TabIndex = 6;
            cadastrarValores.Text = "Valores";
            cadastrarValores.UseVisualStyleBackColor = true;
            cadastrarValores.Click += cadastrarValores_Click;
            cadastrarValores.KeyUp += cadastrarValores_KeyUp;
            // 
            // btnConfig
            // 
            btnConfig.Location = new Point(17, 392);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(107, 26);
            btnConfig.TabIndex = 7;
            btnConfig.Text = "Configurações";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            btnConfig.KeyUp += btnConfig_KeyUp;
            // 
            // cadastrarEndereco
            // 
            cadastrarEndereco.Location = new Point(17, 338);
            cadastrarEndereco.Name = "cadastrarEndereco";
            cadastrarEndereco.Size = new Size(107, 26);
            cadastrarEndereco.TabIndex = 9;
            cadastrarEndereco.Text = "Endereço";
            cadastrarEndereco.UseVisualStyleBackColor = true;
            cadastrarEndereco.Click += cadastrarEndereco_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(cadastrarEndereco);
            Controls.Add(btnConfig);
            Controls.Add(cadastrarValores);
            Controls.Add(cadastrarProdutos);
            Controls.Add(oficialPizzaria);
            Controls.Add(logoImg);
            Controls.Add(cadastrarSabores);
            Controls.Add(principal);
            Controls.Add(cadastrarIngredientes);
            Controls.Add(cadastrarFuncionario);
            Controls.Add(cadastrarClientes);
            Name = "Menu";
            Size = new Size(150, 458);
            ((System.ComponentModel.ISupportInitialize)logoImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoImg;
        private Button principal;
        private Button cadastrarFuncionario;
        private Button cadastrarClientes;
        private Button cadastrarIngredientes;
        private Button cadastrarSabores;
        private Label oficialPizzaria;
        private Button cadastrarProdutos;
        private Button cadastrarValores;
        private Button btnConfig;
        private Button cadastrarEndereco;
    }
}
