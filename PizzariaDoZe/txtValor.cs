using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe
{
    public class txtValor : TextBox
    {
        /// <summary>
        /// Classe responsável pela máscara de Valor dos campos
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLostFocus (EventArgs e)
        {
            base.OnLostFocus (e);

            if(this.Text == "")
            {
                return;
            }

            try
            {
                double valor = Convert.ToDouble(this.Text.Replace("R$ ", " "));
                this.Text = String.Format("{0:c}", valor);

            }
            catch {
                this.Text = " ";
                MessageBox.Show("Valor inválido!");
            }
        }
    }
}
