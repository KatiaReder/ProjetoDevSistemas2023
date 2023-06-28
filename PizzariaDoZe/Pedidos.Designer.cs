namespace PizzariaDoZe
{
    partial class Pedidos
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
            tituloPedidos = new Label();
            inputId = new TextBox();
            labelId = new Label();
            labelTamanhoPizza = new Label();
            inputTamanho = new ComboBox();
            inputBorda = new ComboBox();
            label1 = new Label();
            checkedListBoxIngredientes = new CheckedListBox();
            labelIngredientesSabores = new Label();
            checkedListBoxSabores = new CheckedListBox();
            labelSabores = new Label();
            label4 = new Label();
            checkedListBoxInteira = new CheckedListBox();
            listBox1 = new ListBox();
            label9 = new Label();
            inputValorPizza = new TextBox();
            labelPizzaBorda = new Label();
            panel1 = new Panel();
            checkedListBoxProdutos = new CheckedListBox();
            label10 = new Label();
            inputTipoEntrega = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            inputValorTotal = new TextBox();
            btnCadastrar = new Button();
            labelCpf = new Label();
            label13 = new Label();
            btnExcluir = new Button();
            dataGridViewDados = new DataGridView();
            btnEditar = new Button();
            label14 = new Label();
            label15 = new Label();
            inputIdCliente = new TextBox();
            inputIdFuncionario = new TextBox();
            inputStatusPedido = new TextBox();
            inputTipoPagamento = new TextBox();
            btnListar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // menu1
            // 
            menu1.BackColor = Color.DarkSeaGreen;
            menu1.Location = new Point(2, 2);
            menu1.Name = "menu1";
            menu1.Size = new Size(148, 566);
            menu1.TabIndex = 0;
            // 
            // tituloPedidos
            // 
            tituloPedidos.AutoSize = true;
            tituloPedidos.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tituloPedidos.Location = new Point(385, 9);
            tituloPedidos.Name = "tituloPedidos";
            tituloPedidos.Size = new Size(290, 37);
            tituloPedidos.TabIndex = 3;
            tituloPedidos.Text = "Cadastro de Pedidos";
            // 
            // inputId
            // 
            inputId.Location = new Point(188, 175);
            inputId.Name = "inputId";
            inputId.ReadOnly = true;
            inputId.Size = new Size(48, 23);
            inputId.TabIndex = 11;
            inputId.TabStop = false;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(205, 154);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 18);
            labelId.TabIndex = 10;
            labelId.Text = "Id";
            // 
            // labelTamanhoPizza
            // 
            labelTamanhoPizza.AutoSize = true;
            labelTamanhoPizza.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTamanhoPizza.Location = new Point(296, 154);
            labelTamanhoPizza.Name = "labelTamanhoPizza";
            labelTamanhoPizza.Size = new Size(90, 18);
            labelTamanhoPizza.TabIndex = 12;
            labelTamanhoPizza.Text = "Tamanho Pizza";
            // 
            // inputTamanho
            // 
            inputTamanho.FormattingEnabled = true;
            inputTamanho.Items.AddRange(new object[] { "P-1", "M-2", "G-3", "F-3" });
            inputTamanho.Location = new Point(255, 175);
            inputTamanho.Name = "inputTamanho";
            inputTamanho.Size = new Size(161, 23);
            inputTamanho.TabIndex = 13;
            // 
            // inputBorda
            // 
            inputBorda.FormattingEnabled = true;
            inputBorda.Items.AddRange(new object[] { "Não", "Catupiry", "Cheddar", "Requeijão", "Chocolate Branco", "Chocolate Preto" });
            inputBorda.Location = new Point(188, 245);
            inputBorda.Name = "inputBorda";
            inputBorda.Size = new Size(181, 23);
            inputBorda.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(255, 224);
            label1.Name = "label1";
            label1.Size = new Size(40, 18);
            label1.TabIndex = 14;
            label1.Text = "Borda";
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.BackColor = Color.DarkSeaGreen;
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Location = new Point(777, 98);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(174, 148);
            checkedListBoxIngredientes.TabIndex = 48;
            // 
            // labelIngredientesSabores
            // 
            labelIngredientesSabores.AutoSize = true;
            labelIngredientesSabores.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngredientesSabores.Location = new Point(773, 79);
            labelIngredientesSabores.Name = "labelIngredientesSabores";
            labelIngredientesSabores.Size = new Size(140, 16);
            labelIngredientesSabores.TabIndex = 47;
            labelIngredientesSabores.Text = " Ingredientes Cadastrados";
            // 
            // checkedListBoxSabores
            // 
            checkedListBoxSabores.BackColor = Color.DarkSeaGreen;
            checkedListBoxSabores.FormattingEnabled = true;
            checkedListBoxSabores.Location = new Point(596, 98);
            checkedListBoxSabores.Name = "checkedListBoxSabores";
            checkedListBoxSabores.Size = new Size(175, 148);
            checkedListBoxSabores.TabIndex = 50;
            // 
            // labelSabores
            // 
            labelSabores.AutoSize = true;
            labelSabores.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSabores.Location = new Point(616, 77);
            labelSabores.Name = "labelSabores";
            labelSabores.Size = new Size(130, 18);
            labelSabores.TabIndex = 49;
            labelSabores.Text = "Sabores Cadastrados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(738, 59);
            label4.Name = "label4";
            label4.Size = new Size(50, 18);
            label4.TabIndex = 55;
            label4.Text = "Sabor 1";
            // 
            // checkedListBoxInteira
            // 
            checkedListBoxInteira.BackColor = Color.Honeydew;
            checkedListBoxInteira.BorderStyle = BorderStyle.None;
            checkedListBoxInteira.FormattingEnabled = true;
            checkedListBoxInteira.Items.AddRange(new object[] { "Inteira", "Mais Sabores" });
            checkedListBoxInteira.Location = new Point(440, 277);
            checkedListBoxInteira.Name = "checkedListBoxInteira";
            checkedListBoxInteira.Size = new Size(129, 36);
            checkedListBoxInteira.TabIndex = 64;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.MistyRose;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Pequena - 1 Sabor", "Média - 2 Sabores", "Grande - 3 Sabores", "Família - 3 Sabores" });
            listBox1.Location = new Point(440, 175);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(144, 79);
            listBox1.TabIndex = 65;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(440, 154);
            label9.Name = "label9";
            label9.Size = new Size(144, 18);
            label9.TabIndex = 66;
            label9.Text = "Lista Tamanho / Sabores";
            // 
            // inputValorPizza
            // 
            inputValorPizza.Location = new Point(188, 315);
            inputValorPizza.Name = "inputValorPizza";
            inputValorPizza.Size = new Size(181, 23);
            inputValorPizza.TabIndex = 67;
            // 
            // labelPizzaBorda
            // 
            labelPizzaBorda.AutoSize = true;
            labelPizzaBorda.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPizzaBorda.Location = new Point(216, 295);
            labelPizzaBorda.Name = "labelPizzaBorda";
            labelPizzaBorda.Size = new Size(117, 18);
            labelPizzaBorda.TabIndex = 68;
            labelPizzaBorda.Text = "Valor Pizza + Borda";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Location = new Point(156, 345);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 4);
            panel1.TabIndex = 69;
            // 
            // checkedListBoxProdutos
            // 
            checkedListBoxProdutos.BackColor = Color.DarkSeaGreen;
            checkedListBoxProdutos.FormattingEnabled = true;
            checkedListBoxProdutos.Location = new Point(170, 385);
            checkedListBoxProdutos.Name = "checkedListBoxProdutos";
            checkedListBoxProdutos.Size = new Size(145, 94);
            checkedListBoxProdutos.TabIndex = 71;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(205, 362);
            label10.Name = "label10";
            label10.Size = new Size(58, 18);
            label10.TabIndex = 70;
            label10.Text = "Produtos";
            // 
            // inputTipoEntrega
            // 
            inputTipoEntrega.FormattingEnabled = true;
            inputTipoEntrega.Location = new Point(364, 385);
            inputTipoEntrega.Name = "inputTipoEntrega";
            inputTipoEntrega.Size = new Size(183, 23);
            inputTipoEntrega.TabIndex = 73;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(398, 363);
            label11.Name = "label11";
            label11.Size = new Size(98, 18);
            label11.TabIndex = 72;
            label11.Text = "Tipo de Entrega";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(398, 484);
            label12.Name = "label12";
            label12.Size = new Size(110, 18);
            label12.TabIndex = 75;
            label12.Text = "Valor Total Pedido";
            // 
            // inputValorTotal
            // 
            inputValorTotal.Location = new Point(364, 510);
            inputValorTotal.Name = "inputValorTotal";
            inputValorTotal.Size = new Size(183, 23);
            inputValorTotal.TabIndex = 74;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkSeaGreen;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(652, 513);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(232, 36);
            btnCadastrar.TabIndex = 76;
            btnCadastrar.Text = "Cadastrar ";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpf.Location = new Point(244, 77);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(49, 18);
            labelCpf.TabIndex = 78;
            labelCpf.Tag = "idFuncionario";
            labelCpf.Text = "Cliente";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(421, 77);
            label13.Name = "label13";
            label13.Size = new Size(74, 18);
            label13.TabIndex = 80;
            label13.Tag = "idFuncionario";
            label13.Text = "Funcionário";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.RosyBrown;
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(652, 471);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 36);
            btnExcluir.TabIndex = 84;
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
            dataGridViewDados.Location = new Point(596, 252);
            dataGridViewDados.MultiSelect = false;
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDados.Size = new Size(355, 188);
            dataGridViewDados.TabIndex = 83;
            dataGridViewDados.CellFormatting += dataGridViewDados_CellFormatting;
            dataGridViewDados.DoubleClick += dataGridViewDados_DoubleClick;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkSeaGreen;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(768, 471);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 36);
            btnEditar.TabIndex = 82;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(398, 422);
            label14.Name = "label14";
            label14.Size = new Size(84, 18);
            label14.TabIndex = 86;
            label14.Text = "Status Pedido";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(188, 492);
            label15.Name = "label15";
            label15.Size = new Size(115, 18);
            label15.TabIndex = 87;
            label15.Text = "Tipo de Pagamento";
            // 
            // inputIdCliente
            // 
            inputIdCliente.Location = new Point(224, 98);
            inputIdCliente.Name = "inputIdCliente";
            inputIdCliente.Size = new Size(115, 23);
            inputIdCliente.TabIndex = 91;
            inputIdCliente.TabStop = false;
            // 
            // inputIdFuncionario
            // 
            inputIdFuncionario.Location = new Point(398, 98);
            inputIdFuncionario.Name = "inputIdFuncionario";
            inputIdFuncionario.Size = new Size(123, 23);
            inputIdFuncionario.TabIndex = 92;
            inputIdFuncionario.TabStop = false;
            // 
            // inputStatusPedido
            // 
            inputStatusPedido.Location = new Point(364, 443);
            inputStatusPedido.Name = "inputStatusPedido";
            inputStatusPedido.Size = new Size(183, 23);
            inputStatusPedido.TabIndex = 93;
            // 
            // inputTipoPagamento
            // 
            inputTipoPagamento.Location = new Point(156, 513);
            inputTipoPagamento.Name = "inputTipoPagamento";
            inputTipoPagamento.Size = new Size(183, 23);
            inputTipoPagamento.TabIndex = 94;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.DarkSeaGreen;
            btnListar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnListar.Location = new Point(690, 446);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(173, 20);
            btnListar.TabIndex = 95;
            btnListar.Text = "Listagem Pedidos";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click_1;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(961, 561);
            Controls.Add(btnListar);
            Controls.Add(inputTipoPagamento);
            Controls.Add(inputStatusPedido);
            Controls.Add(inputIdFuncionario);
            Controls.Add(inputIdCliente);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(btnExcluir);
            Controls.Add(dataGridViewDados);
            Controls.Add(btnEditar);
            Controls.Add(label13);
            Controls.Add(labelCpf);
            Controls.Add(btnCadastrar);
            Controls.Add(label12);
            Controls.Add(inputValorTotal);
            Controls.Add(inputTipoEntrega);
            Controls.Add(label11);
            Controls.Add(checkedListBoxProdutos);
            Controls.Add(label10);
            Controls.Add(panel1);
            Controls.Add(labelPizzaBorda);
            Controls.Add(inputValorPizza);
            Controls.Add(label9);
            Controls.Add(listBox1);
            Controls.Add(checkedListBoxInteira);
            Controls.Add(label4);
            Controls.Add(checkedListBoxSabores);
            Controls.Add(labelSabores);
            Controls.Add(checkedListBoxIngredientes);
            Controls.Add(labelIngredientesSabores);
            Controls.Add(inputBorda);
            Controls.Add(label1);
            Controls.Add(inputTamanho);
            Controls.Add(labelTamanhoPizza);
            Controls.Add(inputId);
            Controls.Add(labelId);
            Controls.Add(tituloPedidos);
            Controls.Add(menu1);
            Name = "Pedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Menu menu1;
        private Label tituloPedidos;
        private TextBox inputId;
        private Label labelId;
        private Label labelTamanhoPizza;
        private ComboBox inputTamanho;
        private ComboBox inputBorda;
        private Label label1;
        private CheckedListBox checkedListBoxIngredientes;
        private Label labelIngredientesSabores;
        private CheckedListBox checkedListBoxSabores;
        private Label labelSabores;
        private Label label4;
        private CheckedListBox checkedListBoxInteira;
        private ListBox listBox1;
        private Label label9;
        private TextBox inputValorPizza;
        private Label labelPizzaBorda;
        private Panel panel1;
        private CheckedListBox checkedListBoxProdutos;
        private Label label10;
        private ComboBox inputTipoEntrega;
        private Label label11;
        private Label label12;
        private TextBox inputValorTotal;
        private Button btnCadastrar;
        private Label labelCpf;
        private Label label13;
        private Button btnExcluir;
        private DataGridView dataGridViewDados;
        private Button btnEditar;
        private Label label14;
        private Label label15;
        private TextBox inputIdCliente;
        private TextBox inputIdFuncionario;
        private TextBox inputStatusPedido;
        private TextBox inputTipoPagamento;
        private Button btnListar;
    }
}