namespace PizzariaDoZe
{
    partial class EditarExcluir
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
            Editar = new Button();
            Excluir = new Button();
            SuspendLayout();
            // 
            // Editar
            // 
            Editar.BackColor = Color.DarkSeaGreen;
            Editar.Location = new Point(29, 23);
            Editar.Name = "Editar";
            Editar.Size = new Size(117, 31);
            Editar.TabIndex = 0;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = false;
            // 
            // Excluir
            // 
            Excluir.BackColor = Color.RosyBrown;
            Excluir.Location = new Point(174, 23);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(117, 31);
            Excluir.TabIndex = 1;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = false;
            // 
            // EditarExcluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(Excluir);
            Controls.Add(Editar);
            Name = "EditarExcluir";
            Size = new Size(325, 75);
            ResumeLayout(false);
        }

        #endregion

        private Button Editar;
        private Button Excluir;
    }
}
