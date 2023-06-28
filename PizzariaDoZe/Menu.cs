using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();

            Funcoes.AjustaResourcesControl(this);
        }
        /// <summary>
        /// Todos os métodos com click são responsáveis por
        /// abrir centralmente as outras telas do sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void principal_Click(object sender, EventArgs e)
        {
            janelaPrincipal principal = new()
            {
                StartPosition = FormStartPosition.CenterScreen,

            };
            _ = principal.ShowDialog();

        }

        private void cadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionarios func = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = func.ShowDialog();
        }

        private void cadastrarClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = clientes.ShowDialog();
        }

        private void cadastrarIngredientes_Click(object sender, EventArgs e)
        {
            Ingredientes ingredientes = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = ingredientes.ShowDialog();
        }

        private void cadastrarSabores_Click(object sender, EventArgs e)
        {
            Sabores sabores = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = sabores.ShowDialog();
        }

        private void cadastrarPrdutos_Click(object sender, EventArgs e)
        {
            Produtos produtos = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = produtos.ShowDialog();
        }

        private void cadastrarValores_Click(object sender, EventArgs e)
        {
            Valores val = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = val.ShowDialog();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Configuracoes config = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = config.ShowDialog();

        }

        private void cadastrarEndereco_Click(object sender, EventArgs e)
        {
            Enderecos endereco = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = endereco.ShowDialog();
        }
        /// <summary>
        /// Eventos de KeyUp são responsáveis pelas ações de teclado
        /// disponibilizadas no "contextMenuStripPrincipal"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void principal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && e.Shift)
            {
                janelaPrincipal principal = new()
                {
                    StartPosition = FormStartPosition.CenterScreen,

                };
                _ = principal.ShowDialog();
            }
        }

        private void cadastrarFuncionario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && e.Shift)
            {
                Funcionarios func = new()
                {
                    StartPosition = FormStartPosition.CenterScreen,
                };

                _ = func.ShowDialog();
            }
        }

        private void cadastrarClientes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && e.Shift)
            {
                Clientes clientes = new()
                {
                    StartPosition = FormStartPosition.CenterScreen,
                };

                _ = clientes.ShowDialog();
            }
        }

        private void cadastrarIngredientes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Shift)
            {
                Ingredientes ingredientes = new()
                {
                    StartPosition = FormStartPosition.CenterScreen,
                };

                _ = ingredientes.ShowDialog();
            }
        }

        private void cadastrarSabores_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 && e.Shift)
            {
                Sabores sabores = new()
                {
                    StartPosition = FormStartPosition.CenterScreen,
                };

                _ = sabores.ShowDialog();
            }
        }

        private void cadastrarProdutos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6 && e.Shift)
            {
                Produtos produtos = new()
                {
                    StartPosition = FormStartPosition.CenterScreen,
                };

                _ = produtos.ShowDialog();
            }
        }

        private void cadastrarValores_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7 && e.Shift)
            {
                Valores val = new()
                {
                    StartPosition = FormStartPosition.CenterScreen,
                };

                _ = val.ShowDialog();
            }
        }

        private void btnConfig_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8 && e.Shift)
            {
                Configuracoes config = new()
                {
                    StartPosition = FormStartPosition.CenterScreen,
                };

                _ = config.ShowDialog();
            }
        }

        private void buscarCliente_Click(object sender, EventArgs e)
        {
            PedidoClientes pedidoClientes = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = pedidoClientes.ShowDialog();
        }

        private void cadastrarPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            _ = pedidos.ShowDialog();
        }
    }
}
