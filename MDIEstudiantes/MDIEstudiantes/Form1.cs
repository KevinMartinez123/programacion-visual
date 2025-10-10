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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form VerificarFormularioAbierto(Type formType) // verificar si un formulario ya esta abierto.
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.GetType() == formType)
                {
                    return child;
                }
            }
            return null;
        }

        private void btnForm2_Click(object sender, EventArgs e) // Abrir Form2 (Agregar Estudiante)
        {
            Form abierto = VerificarFormularioAbierto(typeof(Form2));
            if (abierto == null)
            {
                Form2 f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();
            }
            else
            {
                abierto.Activate();
            }
        }

        private void btnForm3_Click_1(object sender, EventArgs e) // Abrir Form3 (Ver Estudiantes)
        {
            Form abierto = VerificarFormularioAbierto(typeof(Form3));
            if (abierto == null)
            {
                Form3 f3 = new Form3();
                f3.MdiParent = this;
                f3.Show();
            }
            else
            {
                abierto.Activate();
            }
        }

        private void btnForm4_Click(object sender, EventArgs e) // Abrir Form4 (Gráfico de Promedios.)
        {
            Form abierto = VerificarFormularioAbierto(typeof(Form4));
            if (abierto == null)
            {
                Form4 f4 = new Form4();
                f4.MdiParent = this;
                f4.Show();
            }
            else
            {
                abierto.Activate();
            }
        }
    }
}
