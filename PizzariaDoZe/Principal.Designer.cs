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
            background.Controls.Add(tituloPrincipal);
            background.Location = new Point(157, 3);
            background.Name = "background";
            background.Size = new Size(645, 446);
            background.TabIndex = 1;
            // 
            // tituloPrincipal
            // 
            tituloPrincipal.AutoSize = true;
            tituloPrincipal.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloPrincipal.Location = new Point(240, 185);
            tituloPrincipal.Name = "tituloPrincipal";
            tituloPrincipal.Size = new Size(163, 37);
            tituloPrincipal.TabIndex = 3;
            tituloPrincipal.Text = "Bem-Vindo";
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
            contextMenuStripPrincipal.ResumeLayout(false);
            contextMenuStripSystemTray.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private Panel background;
        private Label tituloPrincipal;
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