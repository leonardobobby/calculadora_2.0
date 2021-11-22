using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_2._0
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0, valor3 = 0;
        string operacao = "";
        string resul = "";
        int back;
        int continuo = 0;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btoSete_Click(object sender, EventArgs e)
        {
            lblConta2.Text = "";
            if (resul == "resultado")
            {
                txtResultado.Text = "";
                resul = "";
            }
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void btoZero_Click(object sender, EventArgs e)
        {
            lblConta2.Text = "";
            if (resul == "resultado")
            {
                txtResultado.Text = "";
                resul = "";
            }
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void btoUm_Click(object sender, EventArgs e)
        {
            lblConta2.Text = "";
            if (resul == "resultado")
            {
                txtResultado.Text = "";
                resul = "";
            }
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void btoDois_Click(object sender, EventArgs e)
        {
            lblConta2.Text = "";
            if (resul == "resultado")
            {
                txtResultado.Text = "";
                resul = "";
            }
            txtResultado.Text += "2";
        }

        private void btoTres_Click(object sender, EventArgs e)
        {
            lblConta2.Text = "";
            if (resul == "resultado")
            {
                txtResultado.Text = "";
                resul = "";
            }
            txtResultado.Text += "3";
        }

        private void btoQuatro_Click(object sender, EventArgs e)
        {
            lblConta2.Text = "";
            if (resul == "resultado")
            {
                txtResultado.Text = "";
                resul = "";
            }
            txtResultado.Text += "4";
        }

        private void btoCinco_Click(object sender, EventArgs e)
        {
            lblConta2.Text = "";
            if (resul == "resultado")
            {
                txtResultado.Text = "";
                resul = "";
            }
            txtResultado.Text += "5";
        }

        private void btoSeis_Click(object sender, EventArgs e)
        {
            lblConta2.Text = "";
            if (resul == "resultado")
            {
                txtResultado.Text = "";
                resul = "";
            }
            txtResultado.Text += "6";
        }

        private void btoOito_Click(object sender, EventArgs e)
        {
            lblConta2.Text = "";
            if (resul == "resultado")
            {
                txtResultado.Text = "";
                resul = "";
            }
            txtResultado.Text += "8";
        }

        private void btoNove_Click(object sender, EventArgs e)
        {
            lblConta2.Text = "";
            if (resul == "resultado")
            {
                txtResultado.Text = "";
                resul = "";
            }
            txtResultado.Text += "9";
        }

        private void btoSomar_Click(object sender, EventArgs e)
        {
            try 
            { 

            if (continuo == 0)
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                operacao = "SOMA";
                lblOperar.Text = "+";
                lblConta2.Text = "";
                lblConta.Text = Convert.ToString(valor1 + "+");
                txtResultado.Text = "";
                continuo += 1;
            }
            /*  else
              {
                  MessageBox.Show("Informe algum número");
              }*/
            else if (continuo > 0)
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                lblConta.Text = Convert.ToString(valor1 + valor2 + "+");
                valor1 = valor1 + valor2;
                txtResultado.Text = "";

            }
        }
            catch
            {
                MessageBox.Show("Informe algum número para ocorrer o cálculo");
            }
     }
        
        private void btoIgual_Click(object sender, EventArgs e)
        {
            try
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(valor1 + valor2);
                    lblOperar.Text = "";
                    lblConta2.Text = lblConta.Text + Convert.ToString(valor2) + "=";
                    lblConta.Text = "";
                }
                else if (operacao == "SUB")
                {
                    txtResultado.Text = Convert.ToString(valor1 - valor2);
                    lblConta2.Text = lblConta.Text + Convert.ToString(valor2) + "=";
                    lblOperar.Text = "";
                    lblConta.Text = "";
                }
                else if (operacao == "MULT")
                {
                    txtResultado.Text = Convert.ToString(valor1 * valor2);
                    lblConta2.Text = lblConta.Text + Convert.ToString(valor2) + "=";
                    lblOperar.Text = "";
                    lblConta.Text = "";
                }
                else if (operacao == "DIV")
                {
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                    lblConta2.Text = lblConta.Text + Convert.ToString(valor2) + "=";
                    lblOperar.Text = "";
                    lblConta.Text = "";
                }
                resul = "resultado";
                continuo = 0;
                if (lblConta2.Text != "" && operacao == "SOMA")
                {
                    lblConta2.Text = Convert.ToString(valor1) + "+" + Convert.ToString(valor2) + "=";
                }
                else if (lblConta2.Text != "" && operacao == "SUB")
                {
                    lblConta2.Text = Convert.ToString(valor1) + "-" + Convert.ToString(valor2) + "=";
                }
                else if (lblConta2.Text != "" && operacao == "MULT")
                {
                    lblConta2.Text = Convert.ToString(valor1) + "x" + Convert.ToString(valor2) + "=";
                }
                else if (lblConta2.Text != "" && operacao == "DIV")
                {
                    lblConta2.Text = Convert.ToString(valor1) + "÷" + Convert.ToString(valor2) + "=";
                }
            }
            catch
            {
                MessageBox.Show("Informe algum número para ocorrer o cálculo");
            }
        }

        private void btoSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                if (continuo == 0)
            { 
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                operacao = "SUB";
                lblOperar.Text = "-";
                lblConta2.Text = "";
                lblConta.Text = Convert.ToString(valor1 + "-");
                txtResultado.Text = "";
                continuo += 1;
            }
            else if (continuo > 0)
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                lblConta.Text = Convert.ToString(valor1 - valor2 + "-");
                valor1 = valor1 - valor2;
                txtResultado.Text = "";
            }
        }
            catch
            {
                MessageBox.Show("Informe algum número para ocorrer o cálculo");
            }
        }

        private void btoMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (continuo == 0)
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                operacao = "MULT";
                lblOperar.Text = "x";
                lblConta2.Text = "";
                lblConta.Text = Convert.ToString(valor1 + "x");
                txtResultado.Text = "";
                continuo += 1;
            }
            else if (continuo > 0)
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                lblConta.Text = Convert.ToString(valor1 * valor2 + "x");
                valor1 = valor1 * valor2;
                txtResultado.Text = "";
            }
        }
            catch
                {
                    MessageBox.Show("Informe algum número para ocorrer o cálculo");
                }
             }

        private void btoDividir_Click(object sender, EventArgs e)
        {
            try
            {
                if (continuo == 0)
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                operacao = "DIV";
                lblOperar.Text = "÷";
                lblConta2.Text = "";
                lblConta.Text = Convert.ToString(valor1 + "÷");
                txtResultado.Text = "";
                continuo += 1;
            }
            else if (continuo > 0)
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                lblConta.Text = Convert.ToString(valor1 / valor2 + "÷");
                valor1 = valor1 / valor2;
                txtResultado.Text = "";
            }
        }
            catch
                {
                    MessageBox.Show("Informe algum número para ocorrer o cálculo");
                }
        }

        private void btoApagartudo_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperar.Text = "";
            lblConta.Text = "";
            lblConta2.Text = "";
            valor1 = 0;
            valor2 = 0;
            valor3 = 0;
            continuo = 0;
        }

        private void btoApagar_Click(object sender, EventArgs e)
        {
            if (operacao == "MULT") 
            { 
                txtResultado.Text = Convert.ToString(valor1);
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lblOperar.Text = "x";
                lblConta.Text = Convert.ToString(valor1 + "x");
            }
            else if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1);
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperar.Text = "+";
                lblConta.Text = Convert.ToString(valor1 + "+");
            }
            else if (operacao == "DIV")
            {
                txtResultado.Text = Convert.ToString(valor1);
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperar.Text = "÷";
                lblConta.Text = Convert.ToString(valor1 + "÷");
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1);
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperar.Text = "-";
                lblConta.Text = Convert.ToString(valor1 + "-");
            }
            lblConta2.Text = "";
        }

        private void btoApagarum_Click(object sender, EventArgs e)
        {   
            if (txtResultado.Text != "")
            {
                back = txtResultado.TextLength;
                txtResultado.Text = txtResultado.Text.Substring(0, back - 1);
            }
            
        }

        private void btoRaiz_Click(object sender, EventArgs e)
        {
            valor3 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            valor3 = (decimal)Math.Sqrt((double)valor3);
            txtResultado.Text = valor3.ToString();
            lblConta2.Text = "";
            lblConta.Text = "";
        }

        private void btoSobrex_Click(object sender, EventArgs e)
        {
            lblConta2.Text = "";
            lblConta.Text = "";
            valor3 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            valor3 = 1 / valor3;
            txtResultado.Text = valor3.ToString();
        }

        private void btoPorcentagem_Click(object sender, EventArgs e)
        {
            valor3 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = Convert.ToString(valor1 / 100 * valor3);
        }

        private void btoMaisouMenos_Click(object sender, EventArgs e)
        {
           if (txtResultado.Text != "")
            {
                lblConta2.Text = "";
                lblConta.Text = "";
                valor3 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = Convert.ToString(valor3 - valor3 - valor3);
            }
        }

        private void btoAoquadrado_Click(object sender, EventArgs e)
        {
            valor3 = (decimal)double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            valor3 = (decimal)Math.Pow((double)valor3, 2);
            txtResultado.Text = valor3.ToString();
            lblConta2.Text = "";
            lblConta.Text = "";
        }

        private void btoVirgula_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
            lblConta.Text += ".";
        }
    }
}
