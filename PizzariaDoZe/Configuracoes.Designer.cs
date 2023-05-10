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
            background.SuspendLayout();
            groupBoxIdioma.SuspendLayout();
            SuspendLayout();
            // 
            // background
            // 
            background.BackColor = Color.Honeydew;
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
            btnSalvarIdioma.Location = new Point(174, 282);
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
            groupBoxIdioma.Location = new Point(36, 93);
            groupBoxIdioma.Name = "groupBoxIdioma";
            groupBoxIdioma.Size = new Size(547, 158);
            groupBoxIdioma.TabIndex = 4;
            groupBoxIdioma.TabStop = false;
            groupBoxIdioma.Text = "Idioma/Região";
            // 
            // checkBoxIdiomaReiniciar
            // 
            checkBoxIdiomaReiniciar.AutoSize = true;
            checkBoxIdiomaReiniciar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIdiomaReiniciar.Location = new Point(178, 69);
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
            tituloConfiguracoes.Location = new Point(214, 22);
            tituloConfiguracoes.Name = "tituloConfiguracoes";
            tituloConfiguracoes.Size = new Size(206, 37);
            tituloConfiguracoes.TabIndex = 3;
            tituloConfiguracoes.Text = "Configurações";
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
    }
}