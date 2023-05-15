namespace PizzariaDoZe
{
    partial class Configuracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracoes));
            background = new Panel();
            btnSalvarIdioma = new Button();
            groupBoxIdioma = new GroupBox();
            checkBoxIdiomaReiniciar = new CheckBox();
            comboBoxIdioma = new ComboBox();
            labelIdioma = new Label();
            tituloConfiguracoes = new Label();
            groupBoxBD = new GroupBox();
            comboBoxProvider = new ComboBox();
            labelProvider = new Label();
            labelConexao = new Label();
            textBoxConexao = new TextBox();
            background.SuspendLayout();
            groupBoxIdioma.SuspendLayout();
            groupBoxBD.SuspendLayout();
            SuspendLayout();
            // 
            // background
            // 
            background.BackColor = Color.Honeydew;
            background.Controls.Add(groupBoxBD);
            background.Controls.Add(btnSalvarIdioma);
            background.Controls.Add(groupBoxIdioma);
            background.Controls.Add(tituloConfiguracoes);
            background.Dock = DockStyle.Fill;
            background.Location = new Point(0, 0);
            background.Name = "background";
            background.Size = new Size(658, 353);
            background.TabIndex = 5;
            // 
            // btnSalvarIdioma
            // 
            btnSalvarIdioma.BackColor = Color.DarkSeaGreen;
            btnSalvarIdioma.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvarIdioma.Location = new Point(183, 314);
            btnSalvarIdioma.Name = "btnSalvarIdioma";
            btnSalvarIdioma.Size = new Size(246, 36);
            btnSalvarIdioma.TabIndex = 37;
            btnSalvarIdioma.Text = "Salvar";
            btnSalvarIdioma.UseVisualStyleBackColor = false;
            btnSalvarIdioma.Click += btnSalvarIdioma_Click;
            // 
            // groupBoxIdioma
            // 
            groupBoxIdioma.Controls.Add(checkBoxIdiomaReiniciar);
            groupBoxIdioma.Controls.Add(comboBoxIdioma);
            groupBoxIdioma.Controls.Add(labelIdioma);
            groupBoxIdioma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxIdioma.Location = new Point(39, 51);
            groupBoxIdioma.Name = "groupBoxIdioma";
            groupBoxIdioma.Size = new Size(508, 116);
            groupBoxIdioma.TabIndex = 4;
            groupBoxIdioma.TabStop = false;
            groupBoxIdioma.Text = "Idioma/Região";
            // 
            // checkBoxIdiomaReiniciar
            // 
            checkBoxIdiomaReiniciar.AutoSize = true;
            checkBoxIdiomaReiniciar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIdiomaReiniciar.Location = new Point(175, 61);
            checkBoxIdiomaReiniciar.Name = "checkBoxIdiomaReiniciar";
            checkBoxIdiomaReiniciar.Size = new Size(329, 21);
            checkBoxIdiomaReiniciar.TabIndex = 2;
            checkBoxIdiomaReiniciar.Text = "Reiniciar para aplicar o novo idioma imediatamente";
            checkBoxIdiomaReiniciar.UseVisualStyleBackColor = true;
            // 
            // comboBoxIdioma
            // 
            comboBoxIdioma.FormattingEnabled = true;
            comboBoxIdioma.Items.AddRange(new object[] { "pt-BR", "es", "en-US" });
            comboBoxIdioma.Location = new Point(21, 61);
            comboBoxIdioma.Name = "comboBoxIdioma";
            comboBoxIdioma.Size = new Size(131, 29);
            comboBoxIdioma.TabIndex = 1;
            // 
            // labelIdioma
            // 
            labelIdioma.AutoSize = true;
            labelIdioma.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdioma.Location = new Point(21, 41);
            labelIdioma.Name = "labelIdioma";
            labelIdioma.Size = new Size(87, 17);
            labelIdioma.TabIndex = 0;
            labelIdioma.Text = "Idioma/Região";
            // 
            // tituloConfiguracoes
            // 
            tituloConfiguracoes.AutoSize = true;
            tituloConfiguracoes.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloConfiguracoes.Location = new Point(214, 9);
            tituloConfiguracoes.Name = "tituloConfiguracoes";
            tituloConfiguracoes.Size = new Size(206, 37);
            tituloConfiguracoes.TabIndex = 3;
            tituloConfiguracoes.Text = "Configurações";
            // 
            // groupBoxBD
            // 
            groupBoxBD.Controls.Add(textBoxConexao);
            groupBoxBD.Controls.Add(labelConexao);
            groupBoxBD.Controls.Add(comboBoxProvider);
            groupBoxBD.Controls.Add(labelProvider);
            groupBoxBD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxBD.Location = new Point(39, 173);
            groupBoxBD.Name = "groupBoxBD";
            groupBoxBD.Size = new Size(596, 134);
            groupBoxBD.TabIndex = 5;
            groupBoxBD.TabStop = false;
            groupBoxBD.Text = "Banco de Dados";
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Items.AddRange(new object[] { "MySql.Data.MySqlClient", "System.Data.SqlClient" });
            comboBoxProvider.Location = new Point(21, 63);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(180, 29);
            comboBoxProvider.TabIndex = 1;
            // 
            // labelProvider
            // 
            labelProvider.AutoSize = true;
            labelProvider.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelProvider.Location = new Point(21, 43);
            labelProvider.Name = "labelProvider";
            labelProvider.Size = new Size(53, 17);
            labelProvider.TabIndex = 0;
            labelProvider.Text = "Provider";
            // 
            // labelConexao
            // 
            labelConexao.AutoSize = true;
            labelConexao.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelConexao.Location = new Point(227, 43);
            labelConexao.Name = "labelConexao";
            labelConexao.Size = new Size(108, 17);
            labelConexao.TabIndex = 2;
            labelConexao.Text = "String de Conexão";
            // 
            // textBoxConexao
            // 
            textBoxConexao.Location = new Point(227, 63);
            textBoxConexao.Name = "textBoxConexao";
            textBoxConexao.Size = new Size(352, 29);
            textBoxConexao.TabIndex = 3;
            // 
            // Configuracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 353);
            ControlBox = false;
            Controls.Add(background);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Configuracoes";
            Text = "Configuracoes";
            background.ResumeLayout(false);
            background.PerformLayout();
            groupBoxIdioma.ResumeLayout(false);
            groupBoxIdioma.PerformLayout();
            groupBoxBD.ResumeLayout(false);
            groupBoxBD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel background;
        private Button btnSalvarIdioma;
        private GroupBox groupBoxIdioma;
        private CheckBox checkBoxIdiomaReiniciar;
        private Label labelIdioma;
        private Label tituloConfiguracoes;
        private ComboBox comboBoxIdioma;
        private GroupBox groupBoxBD;
        private ComboBox comboBoxProvider;
        private Label labelProvider;
        private TextBox textBoxConexao;
        private Label labelConexao;
    }
}