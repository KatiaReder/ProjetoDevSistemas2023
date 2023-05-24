namespace PizzariaDoZe
{
    partial class Enderecos
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
            tituloIngredientes = new Label();
            background = new Panel();
            dataGridViewDados = new DataGridView();
            menu1 = new Menu();
            labelIngredientesCadastrados = new Label();
            label1 = new Label();
            background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // tituloIngredientes
            // 
            tituloIngredientes.AutoSize = true;
            tituloIngredientes.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloIngredientes.Location = new Point(216, 23);
            tituloIngredientes.Name = "tituloIngredientes";
            tituloIngredientes.Size = new Size(356, 37);
            tituloIngredientes.TabIndex = 3;
            tituloIngredientes.Text = "Cadastro de Ingredientes";
            // 
            // background
            // 
            background.BackColor = Color.Honeydew;
            background.Controls.Add(dataGridViewDados);
            background.Controls.Add(menu1);
            background.Controls.Add(labelIngredientesCadastrados);
            background.Controls.Add(label1);
            background.Dock = DockStyle.Fill;
            background.Location = new Point(0, 0);
            background.Name = "background";
            background.Size = new Size(800, 450);
            background.TabIndex = 5;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(149, 83);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(631, 233);
            dataGridViewDados.TabIndex = 40;
            // 
            // menu1
            // 
            menu1.BackColor = Color.DarkSeaGreen;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(143, 450);
            menu1.TabIndex = 39;
            // 
            // labelIngredientesCadastrados
            // 
            labelIngredientesCadastrados.AutoSize = true;
            labelIngredientesCadastrados.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngredientesCadastrados.Location = new Point(149, 60);
            labelIngredientesCadastrados.Name = "labelIngredientesCadastrados";
            labelIngredientesCadastrados.Size = new Size(81, 20);
            labelIngredientesCadastrados.TabIndex = 38;
            labelIngredientesCadastrados.Text = " Endereços";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(372, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 2;
            label1.Text = "Endereço";
            // 
            // Endereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(background);
            Controls.Add(tituloIngredientes);
            Name = "Endereco";
            Text = "Endereco";
            background.ResumeLayout(false);
            background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloIngredientes;
        private Panel background;
        private DataGridView dataGridViewDados;
        private Menu menu1;
        private Label labelIngredientesCadastrados;
        private Label label1;
    }
}