namespace PizzariaDoZe
{
    partial class PedidosListagem
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
            pedidos = new Label();
            dataGridViewDados = new DataGridView();
            labelPedidosCadastrados = new Label();
            btnRelatorioCompleto = new Button();
            btnRelatorioIndividual = new Button();
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
            // pedidos
            // 
            pedidos.AutoSize = true;
            pedidos.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            pedidos.Location = new Point(379, 25);
            pedidos.Name = "pedidos";
            pedidos.Size = new Size(121, 37);
            pedidos.TabIndex = 3;
            pedidos.Text = "Pedidos";
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.BackgroundColor = Color.DarkSeaGreen;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(178, 109);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(595, 216);
            dataGridViewDados.TabIndex = 41;
            dataGridViewDados.CellFormatting += dataGridViewDados_CellFormatting;
            // 
            // labelPedidosCadastrados
            // 
            labelPedidosCadastrados.AutoSize = true;
            labelPedidosCadastrados.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPedidosCadastrados.Location = new Point(178, 86);
            labelPedidosCadastrados.Name = "labelPedidosCadastrados";
            labelPedidosCadastrados.Size = new Size(58, 20);
            labelPedidosCadastrados.TabIndex = 42;
            labelPedidosCadastrados.Text = "Pedidos";
            // 
            // btnRelatorioCompleto
            // 
            btnRelatorioCompleto.BackColor = Color.DarkSeaGreen;
            btnRelatorioCompleto.Location = new Point(660, 358);
            btnRelatorioCompleto.Name = "btnRelatorioCompleto";
            btnRelatorioCompleto.Size = new Size(128, 32);
            btnRelatorioCompleto.TabIndex = 44;
            btnRelatorioCompleto.Text = "Relatório Completo";
            btnRelatorioCompleto.UseVisualStyleBackColor = false;
            btnRelatorioCompleto.Click += btnRelatorioCompleto_Click;
            // 
            // btnRelatorioIndividual
            // 
            btnRelatorioIndividual.BackColor = Color.DarkSeaGreen;
            btnRelatorioIndividual.Location = new Point(660, 396);
            btnRelatorioIndividual.Name = "btnRelatorioIndividual";
            btnRelatorioIndividual.Size = new Size(128, 32);
            btnRelatorioIndividual.TabIndex = 45;
            btnRelatorioIndividual.Text = "Relatório Individual";
            btnRelatorioIndividual.UseVisualStyleBackColor = false;
            btnRelatorioIndividual.Click += btnRelatorioIndividual_Click;
            // 
            // PedidosListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRelatorioIndividual);
            Controls.Add(btnRelatorioCompleto);
            Controls.Add(labelPedidosCadastrados);
            Controls.Add(dataGridViewDados);
            Controls.Add(pedidos);
            Controls.Add(menu1);
            Name = "PedidosListagem";
            Text = "PedidosListagem";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Menu menu1;
        private Label pedidos;
        private DataGridView dataGridViewDados;
        private Label labelPedidosCadastrados;
        private Button btnRelatorioCompleto;
        private Button btnRelatorioIndividual;
    }
}