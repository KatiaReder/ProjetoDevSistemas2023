namespace PizzariaDoZe
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            background = new Panel();
            btnExcluir = new Button();
            dataGridViewDados = new DataGridView();
            inputEnderecoId = new TextBox();
            label1 = new Label();
            btnEditar = new Button();
            menu1 = new Menu();
            inputCep = new MaskedTextBox();
            btnCadastrar = new Button();
            inputPais = new ComboBox();
            inputUF = new ComboBox();
            inputCidade = new TextBox();
            inputBairro = new TextBox();
            inputComplemento = new TextBox();
            inputNumero = new TextBox();
            inputLogradouro = new TextBox();
            labelPais = new Label();
            labelUf = new Label();
            labelCidade = new Label();
            labelBairro = new Label();
            labelComplemento = new Label();
            labelNumero = new Label();
            labelLogradouro = new Label();
            labelCep = new Label();
            inputEmail = new TextBox();
            labelEmail = new Label();
            tituloEndereco = new Label();
            inputTelefone = new MaskedTextBox();
            inputCpf = new MaskedTextBox();
            inputNome = new TextBox();
            inputIId = new TextBox();
            labelTelefone = new Label();
            labelNome = new Label();
            tituloClientes = new Label();
            labelCpf = new Label();
            labelId = new Label();
            background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // background
            // 
            background.BackColor = Color.Honeydew;
            background.Controls.Add(btnExcluir);
            background.Controls.Add(dataGridViewDados);
            background.Controls.Add(inputEnderecoId);
            background.Controls.Add(label1);
            background.Controls.Add(btnEditar);
            background.Controls.Add(menu1);
            background.Controls.Add(inputCep);
            background.Controls.Add(btnCadastrar);
            background.Controls.Add(inputPais);
            background.Controls.Add(inputUF);
            background.Controls.Add(inputCidade);
            background.Controls.Add(inputBairro);
            background.Controls.Add(inputComplemento);
            background.Controls.Add(inputNumero);
            background.Controls.Add(inputLogradouro);
            background.Controls.Add(labelPais);
            background.Controls.Add(labelUf);
            background.Controls.Add(labelCidade);
            background.Controls.Add(labelBairro);
            background.Controls.Add(labelComplemento);
            background.Controls.Add(labelNumero);
            background.Controls.Add(labelLogradouro);
            background.Controls.Add(labelCep);
            background.Controls.Add(inputEmail);
            background.Controls.Add(labelEmail);
            background.Controls.Add(tituloEndereco);
            background.Controls.Add(inputTelefone);
            background.Controls.Add(inputCpf);
            background.Controls.Add(inputNome);
            background.Controls.Add(inputIId);
            background.Controls.Add(labelTelefone);
            background.Controls.Add(labelNome);
            background.Controls.Add(tituloClientes);
            background.Controls.Add(labelCpf);
            background.Controls.Add(labelId);
            background.Dock = DockStyle.Fill;
            background.Location = new Point(0, 0);
            background.Name = "background";
            background.Size = new Size(1321, 450);
            background.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.RosyBrown;
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(892, 402);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 36);
            btnExcluir.TabIndex = 45;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AllowUserToAddRows = false;
            dataGridViewDados.BackgroundColor = Color.DarkSeaGreen;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewDados.Location = new Point(836, 45);
            dataGridViewDados.MultiSelect = false;
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDados.Size = new Size(435, 333);
            dataGridViewDados.TabIndex = 44;
            dataGridViewDados.CellFormatting += dataGridViewDados_CellFormatting_1;
            dataGridViewDados.MouseDoubleClick += dataGridViewDados_MouseDoubleClick;
            // 
            // inputEnderecoId
            // 
            inputEnderecoId.Location = new Point(149, 191);
            inputEnderecoId.Name = "inputEnderecoId";
            inputEnderecoId.ReadOnly = true;
            inputEnderecoId.Size = new Size(49, 23);
            inputEnderecoId.TabIndex = 43;
            inputEnderecoId.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(161, 170);
            label1.Name = "label1";
            label1.Size = new Size(18, 18);
            label1.TabIndex = 42;
            label1.Text = "Id";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkSeaGreen;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(1100, 402);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 36);
            btnEditar.TabIndex = 41;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // menu1
            // 
            menu1.BackColor = Color.DarkSeaGreen;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(143, 450);
            menu1.TabIndex = 40;
            // 
            // inputCep
            // 
            inputCep.Location = new Point(203, 191);
            inputCep.Mask = "00000-000";
            inputCep.Name = "inputCep";
            inputCep.Size = new Size(127, 23);
            inputCep.TabIndex = 4;
            inputCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkSeaGreen;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(374, 402);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(246, 36);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar ";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            btnCadastrar.KeyUp += btnCadastrar_KeyUp;
            // 
            // inputPais
            // 
            inputPais.AccessibleRole = AccessibleRole.Grip;
            inputPais.AllowDrop = true;
            inputPais.BackColor = Color.RosyBrown;
            inputPais.FormattingEnabled = true;
            inputPais.Items.AddRange(new object[] { "Administrador", "Atendente", "Entregador" });
            inputPais.Location = new Point(694, 254);
            inputPais.Name = "inputPais";
            inputPais.Size = new Size(77, 23);
            inputPais.TabIndex = 9;
            inputPais.Text = "Brasil";
            // 
            // inputUF
            // 
            inputUF.AccessibleRole = AccessibleRole.Grip;
            inputUF.AllowDrop = true;
            inputUF.BackColor = Color.RosyBrown;
            inputUF.FormattingEnabled = true;
            inputUF.Items.AddRange(new object[] { "Administrador", "Atendente", "Entregador" });
            inputUF.Location = new Point(525, 312);
            inputUF.Name = "inputUF";
            inputUF.Size = new Size(159, 23);
            inputUF.TabIndex = 11;
            inputUF.Text = "SC";
            // 
            // inputCidade
            // 
            inputCidade.Location = new Point(294, 312);
            inputCidade.Name = "inputCidade";
            inputCidade.Size = new Size(163, 23);
            inputCidade.TabIndex = 10;
            // 
            // inputBairro
            // 
            inputBairro.Location = new Point(160, 254);
            inputBairro.Name = "inputBairro";
            inputBairro.Size = new Size(163, 23);
            inputBairro.TabIndex = 7;
            // 
            // inputComplemento
            // 
            inputComplemento.Location = new Point(339, 254);
            inputComplemento.Name = "inputComplemento";
            inputComplemento.Size = new Size(345, 23);
            inputComplemento.TabIndex = 8;
            // 
            // inputNumero
            // 
            inputNumero.Location = new Point(738, 191);
            inputNumero.Name = "inputNumero";
            inputNumero.Size = new Size(50, 23);
            inputNumero.TabIndex = 6;
            // 
            // inputLogradouro
            // 
            inputLogradouro.Location = new Point(336, 191);
            inputLogradouro.Name = "inputLogradouro";
            inputLogradouro.Size = new Size(390, 23);
            inputLogradouro.TabIndex = 5;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPais.Location = new Point(717, 233);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(29, 18);
            labelPais.TabIndex = 27;
            labelPais.Tag = "";
            labelPais.Text = "País";
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUf.Location = new Point(542, 291);
            labelUf.Name = "labelUf";
            labelUf.Size = new Size(23, 18);
            labelUf.TabIndex = 26;
            labelUf.Tag = "";
            labelUf.Text = "UF";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCidade.Location = new Point(339, 291);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(46, 18);
            labelCidade.TabIndex = 25;
            labelCidade.Tag = "";
            labelCidade.Text = "Cidade";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBairro.Location = new Point(220, 233);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(42, 18);
            labelBairro.TabIndex = 24;
            labelBairro.Tag = "";
            labelBairro.Text = "Bairro";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelComplemento.Location = new Point(479, 233);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(86, 18);
            labelComplemento.TabIndex = 23;
            labelComplemento.Tag = "";
            labelComplemento.Text = "Complemento";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumero.Location = new Point(736, 170);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(52, 18);
            labelNumero.TabIndex = 22;
            labelNumero.Tag = "";
            labelNumero.Text = "Número";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogradouro.Location = new Point(502, 170);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(72, 18);
            labelLogradouro.TabIndex = 21;
            labelLogradouro.Tag = "";
            labelLogradouro.Text = "Logradouro";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCep.Location = new Point(242, 170);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(29, 18);
            labelCep.TabIndex = 20;
            labelCep.Tag = "";
            labelCep.Text = "CEP";
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(603, 89);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(185, 23);
            inputEmail.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(685, 68);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(43, 18);
            labelEmail.TabIndex = 14;
            labelEmail.Tag = "";
            labelEmail.Text = "E-mail";
            // 
            // tituloEndereco
            // 
            tituloEndereco.AutoSize = true;
            tituloEndereco.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloEndereco.Location = new Point(161, 140);
            tituloEndereco.Name = "tituloEndereco";
            tituloEndereco.Size = new Size(113, 27);
            tituloEndereco.TabIndex = 13;
            tituloEndereco.Text = "Endereço*";
            // 
            // inputTelefone
            // 
            inputTelefone.Location = new Point(479, 89);
            inputTelefone.Mask = "(00)0 0000-0000";
            inputTelefone.Name = "inputTelefone";
            inputTelefone.Size = new Size(118, 23);
            inputTelefone.TabIndex = 2;
            inputTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // inputCpf
            // 
            inputCpf.Location = new Point(355, 89);
            inputCpf.Mask = "000.000.000-00";
            inputCpf.Name = "inputCpf";
            inputCpf.Size = new Size(118, 23);
            inputCpf.TabIndex = 1;
            inputCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // inputNome
            // 
            inputNome.Location = new Point(200, 89);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(149, 23);
            inputNome.TabIndex = 0;
            // 
            // inputIId
            // 
            inputIId.Location = new Point(145, 89);
            inputIId.Name = "inputIId";
            inputIId.ReadOnly = true;
            inputIId.Size = new Size(49, 23);
            inputIId.TabIndex = 9;
            inputIId.TabStop = false;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelefone.Location = new Point(509, 68);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(62, 18);
            labelTelefone.TabIndex = 4;
            labelTelefone.Tag = "";
            labelTelefone.Text = "Telefone*";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(220, 68);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(103, 18);
            labelNome.TabIndex = 3;
            labelNome.Tag = "";
            labelNome.Text = "Nome Completo*";
            // 
            // tituloClientes
            // 
            tituloClientes.AutoSize = true;
            tituloClientes.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloClientes.Location = new Point(312, 9);
            tituloClientes.Name = "tituloClientes";
            tituloClientes.Size = new Size(297, 37);
            tituloClientes.TabIndex = 2;
            tituloClientes.Text = "Cadastro de Clientes";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpf.Location = new Point(403, 68);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(26, 18);
            labelCpf.TabIndex = 1;
            labelCpf.Tag = "cpfFuncionario";
            labelCpf.Text = "Cpf";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(160, 68);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 18);
            labelId.TabIndex = 0;
            labelId.Text = "Id";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 450);
            Controls.Add(background);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            background.ResumeLayout(false);
            background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel background;
        private Button btnCadastrar;
        private ComboBox inputPais;
        private ComboBox inputUF;
        private TextBox inputCidade;
        private TextBox inputBairro;
        private TextBox inputComplemento;
        private TextBox inputNumero;
        private TextBox inputLogradouro;
        private Label labelPais;
        private Label labelUf;
        private Label labelCidade;
        private Label labelBairro;
        private Label labelComplemento;
        private Label labelNumero;
        private Label labelLogradouro;
        private Label labelCep;
        private TextBox inputEmail;
        private Label labelEmail;
        private Label tituloEndereco;
        private MaskedTextBox inputTelefone;
        private MaskedTextBox inputCpf;
        private TextBox inputNome;
        private TextBox inputIId;
        private Label labelTelefone;
        private Label labelNome;
        private Label tituloClientes;
        private Label labelCpf;
        private Label labelId;
        private MaskedTextBox inputCep;
        private Menu menu1;
        private Button btnEditar;
        private TextBox inputEnderecoId;
        private Label label1;
        private DataGridView dataGridViewDados;
        private Button btnExcluir;
    }
}