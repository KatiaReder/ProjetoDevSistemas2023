namespace PizzariaDoZe
{
    partial class janelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(janelaPrincipal));
            menu1 = new Menu();
            background = new Panel();
            labelAcoes = new Label();
            labelTelefone = new Label();
            labelCpf = new Label();
            labelNome = new Label();
            clienteResultado = new Panel();
            btnRemover = new Button();
            btnEditar = new Button();
            telefoneResultado = new Label();
            cpfResultado = new Label();
            nomeResultado = new Label();
            btnBuscar = new Button();
            inputPesquisa = new TextBox();
            tituloPrincipal = new Label();
            contextMenuStripPrincipal = new ContextMenuStrip(components);
            inicioToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            ingredienteToolStripMenuItem = new ToolStripMenuItem();
            saborToolStripMenuItem = new ToolStripMenuItem();
            valorToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStripSystemTray = new ContextMenuStrip(components);
            abrirAplicaçãoToolStripMenuItem = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            background.SuspendLayout();
            clienteResultado.SuspendLayout();
            contextMenuStripPrincipal.SuspendLayout();
            contextMenuStripSystemTray.SuspendLayout();
            SuspendLayout();
            // 
            // menu1
            // 
            menu1.BackColor = Color.DarkSeaGreen;
            menu1.Location = new Point(5, 3);
            menu1.Name = "menu1";
            menu1.Size = new Size(156, 452);
            menu1.TabIndex = 0;
            // 
            // background
            // 
            background.BackColor = Color.Honeydew;
            background.Controls.Add(labelAcoes);
            background.Controls.Add(labelTelefone);
            background.Controls.Add(labelCpf);
            background.Controls.Add(labelNome);
            background.Controls.Add(clienteResultado);
            background.Controls.Add(btnBuscar);
            background.Controls.Add(inputPesquisa);
            background.Controls.Add(tituloPrincipal);
            background.Location = new Point(157, 3);
            background.Name = "background";
            background.Size = new Size(645, 446);
            background.TabIndex = 1;
            // 
            // labelAcoes
            // 
            labelAcoes.AutoSize = true;
            labelAcoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAcoes.Location = new Point(503, 97);
            labelAcoes.Name = "labelAcoes";
            labelAcoes.Size = new Size(40, 15);
            labelAcoes.TabIndex = 9;
            labelAcoes.Text = "Ações";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelefone.Location = new Point(331, 97);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(56, 15);
            labelTelefone.TabIndex = 8;
            labelTelefone.Text = "Telefone";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpf.Location = new Point(202, 99);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(27, 15);
            labelCpf.TabIndex = 7;
            labelCpf.Text = "CPF";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(58, 99);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 15);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome";
            // 
            // clienteResultado
            // 
            clienteResultado.BackColor = SystemColors.ButtonHighlight;
            clienteResultado.Controls.Add(btnRemover);
            clienteResultado.Controls.Add(btnEditar);
            clienteResultado.Controls.Add(telefoneResultado);
            clienteResultado.Controls.Add(cpfResultado);
            clienteResultado.Controls.Add(nomeResultado);
            clienteResultado.Location = new Point(40, 117);
            clienteResultado.Name = "clienteResultado";
            clienteResultado.Size = new Size(580, 40);
            clienteResultado.TabIndex = 6;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.IndianRed;
            btnRemover.Location = new Point(498, 9);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(65, 24);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkSeaGreen;
            btnEditar.Location = new Point(420, 9);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(65, 24);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // telefoneResultado
            // 
            telefoneResultado.AutoSize = true;
            telefoneResultado.Location = new Point(271, 14);
            telefoneResultado.Name = "telefoneResultado";
            telefoneResultado.Size = new Size(89, 15);
            telefoneResultado.TabIndex = 2;
            telefoneResultado.Text = "(00) 00000-0000";
            // 
            // cpfResultado
            // 
            cpfResultado.AutoSize = true;
            cpfResultado.Location = new Point(137, 14);
            cpfResultado.Name = "cpfResultado";
            cpfResultado.Size = new Size(84, 15);
            cpfResultado.TabIndex = 1;
            cpfResultado.Text = "000.000.000-00";
            // 
            // nomeResultado
            // 
            nomeResultado.AutoSize = true;
            nomeResultado.Location = new Point(18, 14);
            nomeResultado.Name = "nomeResultado";
            nomeResultado.Size = new Size(50, 15);
            nomeResultado.TabIndex = 0;
            nomeResultado.Text = "Cliente1";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSeaGreen;
            btnBuscar.Location = new Point(569, 59);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(57, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // inputPesquisa
            // 
            inputPesquisa.BorderStyle = BorderStyle.FixedSingle;
            inputPesquisa.ForeColor = SystemColors.ActiveCaptionText;
            inputPesquisa.Location = new Point(40, 59);
            inputPesquisa.Name = "inputPesquisa";
            inputPesquisa.Size = new Size(525, 23);
            inputPesquisa.TabIndex = 0;
            // 
            // tituloPrincipal
            // 
            tituloPrincipal.AutoSize = true;
            tituloPrincipal.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloPrincipal.Location = new Point(169, 19);
            tituloPrincipal.Name = "tituloPrincipal";
            tituloPrincipal.Size = new Size(301, 37);
            tituloPrincipal.TabIndex = 3;
            tituloPrincipal.Text = "Listagem de Clientes";
            // 
            // contextMenuStripPrincipal
            // 
            contextMenuStripPrincipal.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, funcionárioToolStripMenuItem, clientesToolStripMenuItem, ingredienteToolStripMenuItem, saborToolStripMenuItem, valorToolStripMenuItem, produtoToolStripMenuItem, toolStripSeparator1, configuraçõesToolStripMenuItem, toolStripSeparator2, sairToolStripMenuItem });
            contextMenuStripPrincipal.Name = "contextMenuStripPrincipal";
            contextMenuStripPrincipal.Size = new Size(203, 214);
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F1;
            inicioToolStripMenuItem.Size = new Size(202, 22);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F2;
            funcionárioToolStripMenuItem.Size = new Size(202, 22);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            clientesToolStripMenuItem.Size = new Size(202, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ingredienteToolStripMenuItem
            // 
            ingredienteToolStripMenuItem.Name = "ingredienteToolStripMenuItem";
            ingredienteToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F4;
            ingredienteToolStripMenuItem.Size = new Size(202, 22);
            ingredienteToolStripMenuItem.Text = "Ingrediente";
            // 
            // saborToolStripMenuItem
            // 
            saborToolStripMenuItem.Name = "saborToolStripMenuItem";
            saborToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F5;
            saborToolStripMenuItem.Size = new Size(202, 22);
            saborToolStripMenuItem.Text = "Sabor";
            // 
            // valorToolStripMenuItem
            // 
            valorToolStripMenuItem.Name = "valorToolStripMenuItem";
            valorToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F6;
            valorToolStripMenuItem.Size = new Size(202, 22);
            valorToolStripMenuItem.Text = "Valor";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F7;
            produtoToolStripMenuItem.Size = new Size(202, 22);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(199, 6);
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F5;
            configuraçõesToolStripMenuItem.Size = new Size(202, 22);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(199, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.Delete;
            sairToolStripMenuItem.Size = new Size(202, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // notifyIconSystemTray
            // 
            notifyIconSystemTray.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconSystemTray.BalloonTipText = "Aplicação cotinua executando na bandeja";
            notifyIconSystemTray.BalloonTipTitle = "Pastelaria do Zé";
            notifyIconSystemTray.ContextMenuStrip = contextMenuStripSystemTray;
            notifyIconSystemTray.Icon = (Icon)resources.GetObject("notifyIconSystemTray.Icon");
            notifyIconSystemTray.Text = "Pizzaria do Zé";
            notifyIconSystemTray.MouseDoubleClick += notifyIconSystemTray_MouseDoubleClick;
            // 
            // contextMenuStripSystemTray
            // 
            contextMenuStripSystemTray.Items.AddRange(new ToolStripItem[] { abrirAplicaçãoToolStripMenuItem, encerrarToolStripMenuItem, sobreToolStripMenuItem });
            contextMenuStripSystemTray.Name = "contextMenuStripSystemTray";
            contextMenuStripSystemTray.Size = new Size(156, 70);
            // 
            // abrirAplicaçãoToolStripMenuItem
            // 
            abrirAplicaçãoToolStripMenuItem.Name = "abrirAplicaçãoToolStripMenuItem";
            abrirAplicaçãoToolStripMenuItem.Size = new Size(155, 22);
            abrirAplicaçãoToolStripMenuItem.Text = "Abrir Aplicação";
            abrirAplicaçãoToolStripMenuItem.Click += abrirAplicaçãoToolStripMenuItem_Click;
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(155, 22);
            encerrarToolStripMenuItem.Text = "Encerrar";
            encerrarToolStripMenuItem.Click += encerrarToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(155, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // janelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 450);
            ContextMenuStrip = contextMenuStripPrincipal;
            Controls.Add(background);
            Controls.Add(menu1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "janelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Janela Principal";
            FormClosing += janelaPrincipal_FormClosing;
            Resize += janelaPrincipal_Resize_1;
            background.ResumeLayout(false);
            background.PerformLayout();
            clienteResultado.ResumeLayout(false);
            clienteResultado.PerformLayout();
            contextMenuStripPrincipal.ResumeLayout(false);
            contextMenuStripSystemTray.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private Panel background;
        private Label tituloPrincipal;
        private Button btnBuscar;
        private TextBox inputPesquisa;
        private Panel clienteResultado;
        private Label nomeResultado;
        private Label cpfResultado;
        private Label labelAcoes;
        private Label labelTelefone;
        private Label labelCpf;
        private Label labelNome;
        private Button btnRemover;
        private Button btnEditar;
        private Label telefoneResultado;
        private ContextMenuStrip contextMenuStripPrincipal;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem ingredienteToolStripMenuItem;
        private ToolStripMenuItem saborToolStripMenuItem;
        private ToolStripMenuItem valorToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sairToolStripMenuItem;
        private NotifyIcon notifyIconSystemTray;
        private ContextMenuStrip contextMenuStripSystemTray;
        private ToolStripMenuItem abrirAplicaçãoToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}