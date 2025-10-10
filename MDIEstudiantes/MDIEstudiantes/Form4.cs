using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MDIEstudiantes
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load_1(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            chart1.ChartAreas.Add(new ChartArea("MainArea")); // area principal del grafico

            var series = new Series("Promedios");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "F2";

            List<(string Nombre, double Promedio)> listaPromedios = new List<(string, double)>();

            foreach (var est in DatosCompartidos.Estudiantes)
            {
                if (est.Asignaturas.Count > 0)
                {
                    double promedio = est.Asignaturas.Average(a => a.Nota);
                    listaPromedios.Add((est.Nombre, promedio));
                }
            }

            listaPromedios.Sort((x, y) => y.Promedio.CompareTo(x.Promedio));

            for (int i = 0; i < Math.Min(3, listaPromedios.Count); i++)
            {
                series.Points.AddXY(listaPromedios[i].Nombre, listaPromedios[i].Promedio);
            }

            chart1.Series.Add(series);
        }
    }
}

