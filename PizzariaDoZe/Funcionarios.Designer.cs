namespace PizzariaDoZe
{
    partial class Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            background = new Panel();
            menu1 = new Menu();
            inputCep = new MaskedTextBox();
            btnCadastrar = new Button();
            inputPais = new ComboBox();
            inputUf = new ComboBox();
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
            inputMotorista = new TextBox();
            labelMotorista = new Label();
            inputSenha = new TextBox();
            inputEmail = new TextBox();
            labelSenha = new Label();
            labelEmail = new Label();
            tituloEndereco = new Label();
            inputTelefone = new MaskedTextBox();
            inputCpf = new MaskedTextBox();
            inputNome = new TextBox();
            inputId = new TextBox();
            labelGrupo = new Label();
            inputGrupo = new ComboBox();
            labelTelefone = new Label();
            labelNome = new Label();
            tituloFuncionarios = new Label();
            labelCpf = new Label();
            labelId = new Label();
            background.SuspendLayout();
            SuspendLayout();
            // 
            // background
            // 
            background.BackColor = Color.Honeydew;
            background.Controls.Add(menu1);
            background.Controls.Add(inputCep);
            background.Controls.Add(btnCadastrar);
            background.Controls.Add(inputPais);
            background.Controls.Add(inputUf);
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
            background.Controls.Add(inputMotorista);
            background.Controls.Add(labelMotorista);
            background.Controls.Add(inputSenha);
            background.Controls.Add(inputEmail);
            background.Controls.Add(labelSenha);
            background.Controls.Add(labelEmail);
            background.Controls.Add(tituloEndereco);
            background.Controls.Add(inputTelefone);
            background.Controls.Add(inputCpf);
            background.Controls.Add(inputNome);
            background.Controls.Add(inputId);
            background.Controls.Add(labelGrupo);
            background.Controls.Add(inputGrupo);
            background.Controls.Add(labelTelefone);
            background.Controls.Add(labelNome);
            background.Controls.Add(tituloFuncionarios);
            background.Controls.Add(labelCpf);
            background.Controls.Add(labelId);
            background.Dock = DockStyle.Fill;
            background.Location = new Point(0, 0);
            background.Name = "background";
            background.Size = new Size(800, 450);
            background.TabIndex = 2;
            // 
            // menu1
            // 
            menu1.BackColor = Color.DarkSeaGreen;
            menu1.Location = new Point(2, 1);
            menu1.Name = "menu1";
            menu1.Size = new Size(152, 447);
            menu1.TabIndex = 38;
            // 
            // inputCep
            // 
            inputCep.Location = new Point(185, 183);
            inputCep.Mask = "00000-000";
            inputCep.Name = "inputCep";
            inputCep.Size = new Size(118, 23);
            inputCep.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkSeaGreen;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(581, 388);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(194, 36);
            btnCadastrar.TabIndex = 15;
            btnCadastrar.Text = "Cadastrar ";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.KeyUp += btnCadastrar_KeyUp;
            // 
            // inputPais
            // 
            inputPais.AccessibleRole = AccessibleRole.Grip;
            inputPais.AllowDrop = true;
            inputPais.BackColor = Color.RosyBrown;
            inputPais.FormattingEnabled = true;
            inputPais.Items.AddRange(new object[] { "Administrador", "Atendente", "Entregador" });
            inputPais.Location = new Point(409, 292);
            inputPais.Name = "inputPais";
            inputPais.Size = new Size(100, 23);
            inputPais.TabIndex = 11;
            inputPais.Text = "Brasil";
            // 
            // inputUf
            // 
            inputUf.AccessibleRole = AccessibleRole.Grip;
            inputUf.AllowDrop = true;
            inputUf.BackColor = Color.RosyBrown;
            inputUf.FormattingEnabled = true;
            inputUf.Items.AddRange(new object[] { "Administrador", "Atendente", "Entregador" });
            inputUf.Location = new Point(325, 292);
            inputUf.Name = "inputUf";
            inputUf.Size = new Size(64, 23);
            inputUf.TabIndex = 10;
            inputUf.Text = "SC";
            // 
            // inputCidade
            // 
            inputCidade.Location = new Point(185, 292);
            inputCidade.Name = "inputCidade";
            inputCidade.Size = new Size(114, 23);
            inputCidade.TabIndex = 9;
            // 
            // inputBairro
            // 
            inputBairro.Location = new Point(390, 233);
            inputBairro.Name = "inputBairro";
            inputBairro.Size = new Size(129, 23);
            inputBairro.TabIndex = 8;
            // 
            // inputComplemento
            // 
            inputComplemento.Location = new Point(185, 233);
            inputComplemento.Name = "inputComplemento";
            inputComplemento.Size = new Size(199, 23);
            inputComplemento.TabIndex = 7;
            // 
            // inputNumero
            // 
            inputNumero.Location = new Point(470, 185);
            inputNumero.Name = "inputNumero";
            inputNumero.Size = new Size(49, 23);
            inputNumero.TabIndex = 6;
            // 
            // inputLogradouro
            // 
            inputLogradouro.Location = new Point(309, 185);
            inputLogradouro.Name = "inputLogradouro";
            inputLogradouro.Size = new Size(152, 23);
            inputLogradouro.TabIndex = 5;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPais.Location = new Point(447, 271);
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
            labelUf.Location = new Point(351, 271);
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
            labelCidade.Location = new Point(208, 271);
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
            labelBairro.Location = new Point(447, 212);
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
            labelComplemento.Location = new Point(225, 212);
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
            labelNumero.Location = new Point(467, 167);
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
            labelLogradouro.Location = new Point(355, 164);
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
            labelCep.Location = new Point(225, 167);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(29, 18);
            labelCep.TabIndex = 20;
            labelCep.Tag = "";
            labelCep.Text = "CEP";
            // 
            // inputMotorista
            // 
            inputMotorista.Location = new Point(581, 147);
            inputMotorista.Name = "inputMotorista";
            inputMotorista.Size = new Size(149, 23);
            inputMotorista.TabIndex = 3;
            // 
            // labelMotorista
            // 
            labelMotorista.AutoSize = true;
            labelMotorista.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMotorista.Location = new Point(581, 126);
            labelMotorista.Name = "labelMotorista";
            labelMotorista.Size = new Size(129, 18);
            labelMotorista.TabIndex = 18;
            labelMotorista.Tag = "";
            labelMotorista.Text = "Carteira de Motorista";
            // 
            // inputSenha
            // 
            inputSenha.Location = new Point(581, 327);
            inputSenha.Name = "inputSenha";
            inputSenha.Size = new Size(181, 23);
            inputSenha.TabIndex = 14;
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(581, 280);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(181, 23);
            inputEmail.TabIndex = 13;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSenha.Location = new Point(644, 306);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(41, 18);
            labelSenha.TabIndex = 15;
            labelSenha.Tag = "";
            labelSenha.Text = "Senha";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(644, 243);
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
            tituloEndereco.Location = new Point(185, 126);
            tituloEndereco.Name = "tituloEndereco";
            tituloEndereco.Size = new Size(104, 27);
            tituloEndereco.TabIndex = 13;
            tituloEndereco.Text = "Endereço";
            // 
            // inputTelefone
            // 
            inputTelefone.Location = new Point(567, 89);
            inputTelefone.Mask = "(00)0 0000-0000";
            inputTelefone.Name = "inputTelefone";
            inputTelefone.Size = new Size(163, 23);
            inputTelefone.TabIndex = 2;
            // 
            // inputCpf
            // 
            inputCpf.Location = new Point(433, 89);
            inputCpf.Mask = "000,000,000-00";
            inputCpf.Name = "inputCpf";
            inputCpf.Size = new Size(128, 23);
            inputCpf.TabIndex = 1;
            // 
            // inputNome
            // 
            inputNome.Location = new Point(239, 89);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(188, 23);
            inputNome.TabIndex = 0;
            // 
            // inputId
            // 
            inputId.Location = new Point(185, 89);
            inputId.Name = "inputId";
            inputId.ReadOnly = true;
            inputId.Size = new Size(48, 23);
            inputId.TabIndex = 9;
            inputId.TabStop = false;
            // 
            // labelGrupo
            // 
            labelGrupo.AutoSize = true;
            labelGrupo.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGrupo.Location = new Point(633, 185);
            labelGrupo.Name = "labelGrupo";
            labelGrupo.Size = new Size(42, 18);
            labelGrupo.TabIndex = 8;
            labelGrupo.Tag = "";
            labelGrupo.Text = "Grupo";
            // 
            // inputGrupo
            // 
            inputGrupo.AccessibleRole = AccessibleRole.Grip;
            inputGrupo.AllowDrop = true;
            inputGrupo.BackColor = Color.RosyBrown;
            inputGrupo.FormattingEnabled = true;
            inputGrupo.Items.AddRange(new object[] { "Administrador", "Atendente", "Entregador" });
            inputGrupo.Location = new Point(609, 206);
            inputGrupo.Name = "inputGrupo";
            inputGrupo.Size = new Size(99, 23);
            inputGrupo.TabIndex = 12;
            inputGrupo.Text = "Administrador";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelefone.Location = new Point(618, 68);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(57, 18);
            labelTelefone.TabIndex = 4;
            labelTelefone.Tag = "";
            labelTelefone.Text = "Telefone";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(286, 68);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(98, 18);
            labelNome.TabIndex = 3;
            labelNome.Tag = "";
            labelNome.Text = "Nome Completo";
            // 
            // tituloFuncionarios
            // 
            tituloFuncionarios.AutoSize = true;
            tituloFuncionarios.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloFuncionarios.Location = new Point(286, 9);
            tituloFuncionarios.Name = "tituloFuncionarios";
            tituloFuncionarios.Size = new Size(357, 37);
            tituloFuncionarios.TabIndex = 2;
            tituloFuncionarios.Text = "Cadastro de Funcionários";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpf.Location = new Point(483, 68);
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
            labelId.Location = new Point(202, 68);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 18);
            labelId.TabIndex = 0;
            labelId.Text = "Id";
            // 
            // Funcionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(background);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Funcionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionarios";
            background.ResumeLayout(false);
            background.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel background;
        private Label tituloFuncionarios;
        private Label labelCpf;
        private Label labelId;
        private Label labelGrupo;
        private ComboBox inputGrupo;
        private Label labelTelefone;
        private Label labelNome;
        private Label labelEmail;
        private MaskedTextBox inputTelefone;
        private MaskedTextBox inputCpf;
        private TextBox inputNome;
        private TextBox inputId;
        private TextBox inputSenha;
        private TextBox inputEmail;
        private Label labelSenha;
        private Label labelMotorista;
        private Button btnCadastrar;
        private MaskedTextBox inputCep;
        private ComboBox inputPais;
        private ComboBox inputUf;
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
        private TextBox inputMotorista;
        private Label tituloEndereco;
        private Menu menu1;
    }
}