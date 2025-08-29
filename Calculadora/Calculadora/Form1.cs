using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operador = " ";
        double num1 = 0;
        double num2 = 0;
        double memoria = 0;
        private void btClear_Click(object sender, EventArgs e)
        {
            txtInsert.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = " ";
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
              if (txtInsert.Text.Length == 1)
            
                txtInsert.Text = "0";
              else
            
                txtInsert.Text = txtInsert.Text.Substring(0, txtInsert.Text.Length - 1);
            
        }

        private void btUno_Click(object sender, EventArgs e)
        {
            if (txtInsert.Text == "0")
            {
                txtInsert.Text = "1";
            }
            else
                txtInsert.Text = txtInsert.Text + "1";
        }

        private void btDos_Click(object sender, EventArgs e)
        {
            if (txtInsert.Text == "0")
            {
                txtInsert.Text = "2";
            } else
                txtInsert.Text = txtInsert.Text + "2";
        }

        private void btTres_Click(object sender, EventArgs e)
        {
            if (txtInsert.Text == "0")
            {
                txtInsert.Text = "3";
            }
            else
                txtInsert.Text = txtInsert.Text + "3";
        }

        private void btCuatro_Click(object sender, EventArgs e)
        {
            if (txtInsert.Text == "0")
            {
                txtInsert.Text = "4";
            }
            else
                txtInsert.Text = txtInsert.Text + "4";
        }

        private void btCinco_Click(object sender, EventArgs e)
        {
            if (txtInsert.Text == "0")
            {
                txtInsert.Text = "5";
            }
            else
                txtInsert.Text = txtInsert.Text + "5";
        }

        private void btSeis_Click(object sender, EventArgs e)
        {
            if (txtInsert.Text == "0")
            {
                txtInsert.Text = "6";
            }
            else
                txtInsert.Text = txtInsert.Text + "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtInsert.Text == "0")
            {
                txtInsert.Text = "7";
            }
            else
                txtInsert.Text = txtInsert.Text + "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtInsert.Text == "0")
            {
                txtInsert.Text = "8";
            }
            else
                txtInsert.Text = txtInsert.Text + "8";
        }

        private void btNueve_Click(object sender, EventArgs e)
        {
            if (txtInsert.Text == "0")
            {
                txtInsert.Text = "9";
            }
            else
                txtInsert.Text = txtInsert.Text + "9";
        }

        private void btCero_Click(object sender, EventArgs e)
        {
            txtInsert.Text = txtInsert.Text + "0";
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            txtInsert.Text = txtInsert.Text + ".";
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(txtInsert.Text);
            txtInsert.Text = "0";
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(txtInsert.Text);
            txtInsert.Text = "0";
        }

        private void btMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(txtInsert.Text);
            txtInsert.Text = "0";
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(txtInsert.Text);
            txtInsert.Text = "0";
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtInsert.Text);

            switch (operador)
            {
                case "+":
                    txtInsert.Text = $"{num1 + num2}";
                    break;
                case "-":
                    txtInsert.Text = $"{num1 - num2}";
                    break;
                case "*":
                    txtInsert.Text = $"{num1 * num2}";
                    break;
                case "/":
                    txtInsert.Text = $"{num1 / num2}";
                    break;
                case "π":
                    txtInsert.Text = $"{num1 * Math.PI}";
                    break;
                case "^":
                    txtInsert.Text = $"{Math.Pow(num1, num2)}";
                    break;
                case "%":
                    txtInsert.Text = $"{(num1 * num2) / 100}";
                    break;

            }
        }

        private void btPi_Click(object sender, EventArgs e)
        {
            txtInsert.Text = Math.PI.ToString();
        }

        private void btLogaritmo_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtInsert.Text);
            txtInsert.Text = Math.Log10(valor).ToString();
        }

        private void btExponente_Click(object sender, EventArgs e)
        {
            operador = "^";
            num1 = Convert.ToDouble(txtInsert.Text);
            txtInsert.Text = "0";
        }

        private void btRaiz_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtInsert.Text);
            txtInsert.Text = Math.Sqrt(valor).ToString();
        }

        private void btSeno_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtInsert.Text);
            valor = valor * Math.PI / 180;
            txtInsert.Text = Math.Sin(valor).ToString();
        }

        private void btporcent_Click(object sender, EventArgs e)
        {
            operador = "%";
            num1 = Convert.ToDouble(txtInsert.Text);
            txtInsert.Text = "0";
        }

        private void btConseno_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtInsert.Text);
            valor = valor * Math.PI / 180;
            txtInsert.Text = Math.Cos(valor).ToString();
        }

        private void btTangente_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtInsert.Text);
            valor = valor * Math.PI / 180;
            txtInsert.Text = Math.Tan(valor).ToString();
        }

        private void btSumarValor_Click(object sender, EventArgs e)
        {
            memoria += Convert.ToDouble(txtInsert.Text);
        }

        private void btRestarValor_Click(object sender, EventArgs e)
        {
            memoria -= Convert.ToDouble(txtInsert.Text);
        }

        private void btBorrarMem_Click(object sender, EventArgs e)
        {
            memoria = 0;
        }

        private void btRecuperar_Click(object sender, EventArgs e)
        {
            txtInsert.Text = memoria.ToString();
        }
    }
}
