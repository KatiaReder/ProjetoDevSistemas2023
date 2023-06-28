namespace PizzariaDoZe
{
    partial class PedidoClientes
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
            menu1 = new Menu();
            tituloSabores = new Label();
            InputBuscar = new TextBox();
            Buscar = new Button();
            CadastrarCliente = new Button();
            DetalhesPedidos = new Button();
            inputNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            inputTelefone = new MaskedTextBox();
            inputCpf = new MaskedTextBox();
            inputIId = new TextBox();
            labelId = new Label();
            dataGridViewDados = new DataGridView();
            btnCadastrarPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // menu1
            // 
            menu1.BackColor = Color.DarkSeaGreen;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(150, 458);
            menu1.TabIndex = 0;
            // 
            // tituloSabores
            // 
            tituloSabores.AutoSize = true;
            tituloSabores.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloSabores.Location = new Point(347, 29);
            tituloSabores.Name = "tituloSabores";
            tituloSabores.Size = new Size(225, 37);
            tituloSabores.TabIndex = 3;
            tituloSabores.Text = "Buscar Clientes";
            // 
            // InputBuscar
            // 
            InputBuscar.Location = new Point(185, 86);
            InputBuscar.Name = "InputBuscar";
            InputBuscar.Size = new Size(506, 23);
            InputBuscar.TabIndex = 6;
            InputBuscar.Leave += InputBuscar_Leave;
            // 
            // Buscar
            // 
            Buscar.Location = new Point(697, 86);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(58, 23);
            Buscar.TabIndex = 7;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = true;
            // 
            // CadastrarCliente
            // 
            CadastrarCliente.BackColor = Color.DarkSeaGreen;
            CadastrarCliente.Location = new Point(215, 386);
            CadastrarCliente.Name = "CadastrarCliente";
            CadastrarCliente.Size = new Size(129, 32);
            CadastrarCliente.TabIndex = 8;
            CadastrarCliente.Text = "Cadastrar Cliente";
            CadastrarCliente.UseVisualStyleBackColor = false;
            CadastrarCliente.Click += CadastrarCliente_Click;
            // 
            // DetalhesPedidos
            // 
            DetalhesPedidos.BackColor = Color.DarkSeaGreen;
            DetalhesPedidos.Location = new Point(562, 376);
            DetalhesPedidos.Name = "DetalhesPedidos";
            DetalhesPedidos.Size = new Size(129, 53);
            DetalhesPedidos.TabIndex = 9;
            DetalhesPedidos.Text = "Detalhamento Pedidos ";
            DetalhesPedidos.UseVisualStyleBackColor = false;
            DetalhesPedidos.Click += DetalhesPedidos_Click;
            // 
            // inputNome
            // 
            inputNome.Location = new Point(305, 159);
            inputNome.Name = "inputNome";
            inputNome.ReadOnly = true;
            inputNome.Size = new Size(149, 23);
            inputNome.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(624, 138);
            label1.Name = "label1";
            label1.Size = new Size(57, 18);
            label1.TabIndex = 21;
            label1.Tag = "";
            label1.Text = "Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(361, 138);
            label2.Name = "label2";
            label2.Size = new Size(44, 18);
            label2.TabIndex = 20;
            label2.Tag = "";
            label2.Text = "Nome ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(517, 138);
            label3.Name = "label3";
            label3.Size = new Size(26, 18);
            label3.TabIndex = 18;
            label3.Tag = "cpfFuncionario";
            label3.Text = "Cpf";
            // 
            // inputTelefone
            // 
            inputTelefone.Location = new Point(584, 159);
            inputTelefone.Mask = "(00)0 0000-0000";
            inputTelefone.Name = "inputTelefone";
            inputTelefone.ReadOnly = true;
            inputTelefone.Size = new Size(130, 23);
            inputTelefone.TabIndex = 23;
            inputTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // inputCpf
            // 
            inputCpf.Location = new Point(460, 159);
            inputCpf.Mask = "000,000,000-00";
            inputCpf.Name = "inputCpf";
            inputCpf.ReadOnly = true;
            inputCpf.Size = new Size(118, 23);
            inputCpf.TabIndex = 22;
            inputCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // inputIId
            // 
            inputIId.Location = new Point(241, 159);
            inputIId.Name = "inputIId";
            inputIId.ReadOnly = true;
            inputIId.Size = new Size(49, 23);
            inputIId.TabIndex = 25;
            inputIId.TabStop = false;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(256, 138);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 18);
            labelId.TabIndex = 24;
            labelId.Text = "Id";
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AllowUserToAddRows = false;
            dataGridViewDados.BackgroundColor = Color.DarkSeaGreen;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewDados.Location = new Point(191, 216);
            dataGridViewDados.MultiSelect = false;
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDados.Size = new Size(564, 143);
            dataGridViewDados.TabIndex = 45;
            dataGridViewDados.CellFormatting += dataGridViewDados_CellFormatting_1;
            dataGridViewDados.DoubleClick += dataGridViewDados_DoubleClick;
            // 
            // btnCadastrarPedido
            // 
            btnCadastrarPedido.BackColor = Color.DarkSeaGreen;
            btnCadastrarPedido.Location = new Point(386, 386);
            btnCadastrarPedido.Name = "btnCadastrarPedido";
            btnCadastrarPedido.Size = new Size(129, 32);
            btnCadastrarPedido.TabIndex = 46;
            btnCadastrarPedido.Text = "Cadastrar Pedido";
            btnCadastrarPedido.UseVisualStyleBackColor = false;
            btnCadastrarPedido.Click += btnCadastrarPedido_Click;
            // 
            // PedidoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrarPedido);
            Controls.Add(dataGridViewDados);
            Controls.Add(inputIId);
            Controls.Add(labelId);
            Controls.Add(inputTelefone);
            Controls.Add(inputCpf);
            Controls.Add(inputNome);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(DetalhesPedidos);
            Controls.Add(CadastrarCliente);
            Controls.Add(Buscar);
            Controls.Add(InputBuscar);
            Controls.Add(tituloSabores);
            Controls.Add(menu1);
            Name = "PedidoClientes";
            Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Menu menu1;
        private Label tituloSabores;
        private TextBox InputBuscar;
        private Button Buscar;
        private Button CadastrarCliente;
        private Button DetalhesPedidos;
        private MaskedTextBox inputTelefone2;
        private MaskedTextBox inputCpf2;
        private TextBox inputNome2;
        private Label labelTelefone;
        private Label labelNome;
        private Label labelCpf;
        private MaskedTextBox inputTelefone1;
        private MaskedTextBox inputCpf1;
        private TextBox inputNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox inputTelefone3;
        private MaskedTextBox inputCpf3;
        private TextBox inputNome3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox inputTelefone;
        private MaskedTextBox inputCpf;
        private TextBox inputIId;
        private Label labelId;
        private DataGridView dataGridViewDados;
        private Button btnCadastrarPedido;
    }
}