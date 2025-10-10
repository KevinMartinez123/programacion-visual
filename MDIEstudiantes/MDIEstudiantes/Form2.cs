using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIEstudiantes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e) // Botón “Guardar”
        {
            var carnet = txtCarnet.Text.Trim();
            var nombre = txtNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(carnet) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Carnet y Nombre son obligatorios.");
                return;
            }

            var estudiante = new Estudiante
            {
                Carnet = carnet,
                Nombre = nombre
            };

            foreach (DataGridViewRow fila in dgvAsignaturas.Rows)
            {
                if (fila.IsNewRow) continue; // ← ignora la fila de edición vacía

                var asig = fila.Cells[0].Value?.ToString().Trim();
                var notaStr = fila.Cells[1].Value?.ToString().Trim();

                if (string.IsNullOrWhiteSpace(asig) || string.IsNullOrWhiteSpace(notaStr))
                    continue; // ← ignora filas incompletas

                if (!double.TryParse(notaStr, out double nota))
                {
                    MessageBox.Show($"La nota '{notaStr}' no es válida.");
                    return;
                }

                estudiante.Asignaturas.Add(new Asignatura
                {
                    Nombre = asig,
                    Nota = nota
                });
            }

            DatosCompartidos.Estudiantes.Add(estudiante);
            MessageBox.Show($"Guardado:\nCarnet: {estudiante.Carnet}\nNombre: {estudiante.Nombre}");

            
            LimpiarFormulario();
        }

        // helper para resetear el form
        private void LimpiarFormulario()
        {
            txtCarnet.Clear();
            txtNombre.Clear();
            dgvAsignaturas.Rows.Clear();
            txtCarnet.Focus();
        }

    }
}
