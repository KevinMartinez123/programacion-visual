using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_C__semana_1_ejercicio_1
{

    public partial class Form1 : Form
    {
        int intentos = 0;
        int maximointento = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string us, cl;
            us = ctusuario.Text;
            cl = ctclave.Text;


            if (us == "admin" && cl == "admin1234")
            {
                MessageBox.Show("Bienvenido al sistema " + us);
            }
            else
            {
                intentos++;

                int restantes = maximointento - intentos;

                if (restantes > 0)
                {
                    MessageBox.Show("Datos erroneos le quedan " + restantes + " intentos ");
                    ctusuario.Clear();
                    ctclave.Clear();
                    ctusuario.Focus();

                }
                else
                {
                    MessageBox.Show("se ha superado los intentos, la aplicacion se cerrara");
                    Close();

                }



            }

        }


        private void btcalcular_Click(object sender, EventArgs e)
        {
            float peso;
            float altura;
            float imc;
            string imcText;

            if (!float.TryParse(cjkg.Text, out peso))
            {
                MessageBox.Show(
                    "Ingrese un valor numérico válido.",
                    "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (!float.TryParse(ctaltura.Text, out altura))
            {
                MessageBox.Show(
                    "Ingrese un valor numérico válido.",
                    "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (altura <= 0)
            {
                MessageBox.Show(
                    "La altura debe ser mayor que 0.",
                    "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                imcText = "Bajo Peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                imcText = "Normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                imcText = "Sobrepeso";
            }
            else
            {
                imcText = "Obesidad";
            }

            MessageBox.Show(
                $"Tu IMC es {imc:F2} y tu peso es: {imcText}.",
                "Resultado",
                MessageBoxButtons.OK
            );
        }
        int contador = 0;

        private void btclick_Click(object sender, EventArgs e)
        {
            contador++;
            contar.Text = contador.ToString();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            contador = 0;
            contar.Text = contador.ToString();
        }


        private void btconvertir_Click(object sender, EventArgs e)
        {
            string conversion = seleccionar.Text;
            float temperatura;
            float resultado = 0;

            if (!float.TryParse(cttemperatura.Text, out temperatura))
            {
                MessageBox.Show(
                    "Ingrese un valor numérico válido.",
                    "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            switch (conversion)
            {
                case "Celsius a Fahrenheit":
                    resultado = (temperatura * 9 / 5) + 32;
                    MessageBox.Show(
                        "Resultado: " + temperatura + "°C = " + resultado + " °F",
                        "Grados Celcius a Farenheit.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    break;

                case "Fahrenheit a Celsius":
                    resultado = (temperatura - 32) * 5 / 9;
                    MessageBox.Show(
                        $"Resultado: {temperatura}°F = {resultado}°C",
                        "Grados Farenheit a Celcius",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    break;

                default:
                    MessageBox.Show(
                        "Seleccione una conversión en el select.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    break;
            }
        }
    }
}
