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
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btoSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void btoZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void btoUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void btoDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btoTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btoQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btoCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btoSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btoOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btoNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btoSomar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperar.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe algum número");
            }
        }
        private void btoIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void btoSubtrair_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SUB";
            lblOperar.Text = "-";
        }

        private void btoMultiplicar_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "MULT";
            lblOperar.Text = "x";
        }

        private void btoDividir_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIV";
            lblOperar.Text = "÷";
        }

        private void btoApagartudo_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperar.Text = "";
            valor1 = 0;
            valor2 = 0;
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
            }
            else if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1);
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperar.Text = "+";
            }
            else if (operacao == "DIV")
            {
                txtResultado.Text = Convert.ToString(valor1);
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperar.Text = "÷";
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1);
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperar.Text = "-";
            }
        }

        private void btoVirgula_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
        }
    }
}
