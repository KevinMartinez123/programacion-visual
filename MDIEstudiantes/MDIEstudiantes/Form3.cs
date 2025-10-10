using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MDIEstudiantes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Evitar ejecutar lógica cuando se abre en el diseñador
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            // TextBox de solo lectura
            txtCarnet.ReadOnly = true;
            txtNombre.ReadOnly = true;

            // Configurar columnas del DataGridView (solo una vez)
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.ReadOnly = true;
            dgvDatos.AllowUserToAddRows = false;

            if (dgvDatos.Columns.Count == 0)
            {
                dgvDatos.Columns.Add("Asignatura", "Asignatura");
                dgvDatos.Columns.Add("Nota", "Nota");
                dgvDatos.Columns["Nota"].DefaultCellStyle.Format = "N2";
                
            }
            else
            {
                dgvDatos.Rows.Clear();
            }

            // Llenar combo con estudiantes
            cmbEstudiante.DisplayMember = "Nombre";
            cmbEstudiante.ValueMember = "Carnet";

            var lista = DatosCompartidos.Estudiantes?.ToList() ?? new List<Estudiante>();
            cmbEstudiante.DataSource = null;
            cmbEstudiante.DataSource = lista;

            // Estado inicial
            cmbEstudiante.SelectedIndex = (lista.Count > 0) ? 0 : -1;
            dgvDatos.Rows.Clear();

            // Mostrar datos iniciales si hay selección
            var seleccionado = cmbEstudiante.SelectedItem as Estudiante;
            if (seleccionado != null)
            {
                txtCarnet.Text = seleccionado.Carnet;
                txtNombre.Text = seleccionado.Nombre;

                foreach (var asig in seleccionado.Asignaturas)
                    dgvDatos.Rows.Add(asig.Nombre, asig.Nota);
            }
        }

        private void cmbEstudiante_SelectedIndexChanged(object sender, EventArgs e) // cambia el estudiante → refresca todo
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            var seleccionado = cmbEstudiante.SelectedItem as Estudiante;

            // Actualizar textboxes manualmente 
            txtCarnet.Text = seleccionado?.Carnet ?? "";
            txtNombre.Text = seleccionado?.Nombre ?? "";

            // Actualizar DataGridView
            dgvDatos.Rows.Clear();
            if (seleccionado == null) return;

            foreach (var asig in seleccionado.Asignaturas)
                dgvDatos.Rows.Add(asig.Nombre, asig.Nota);
        }

        private void Form3_Activated(object sender, EventArgs e) // actualiza combo box si agrego un estudiante en form2
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            int idxAnterior = cmbEstudiante.SelectedIndex;

            cmbEstudiante.DataSource = null;
            cmbEstudiante.DisplayMember = "Nombre";
            cmbEstudiante.ValueMember = "Carnet";
            cmbEstudiante.DataSource = DatosCompartidos.Estudiantes.ToList();

            if (idxAnterior >= 0 && idxAnterior < cmbEstudiante.Items.Count)
                cmbEstudiante.SelectedIndex = idxAnterior;

            // Refrescar nombre, carnet y grid
            cmbEstudiante_SelectedIndexChanged(null, EventArgs.Empty);
        }
    }
}
