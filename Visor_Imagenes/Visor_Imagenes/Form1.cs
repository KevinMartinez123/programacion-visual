using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visor_Imagenes
{
    public partial class Form1 : Form
    {
        string[] archivos;
        int indice = 0;
        private Image originalImage;
        bool aplicarEscalaGrises = false;

        public Form1()
        {
            InitializeComponent();
            string ruta = Application.StartupPath + @"\FOTOS";
            if (Directory.Exists(ruta))
            {
                CargarImagenes(ruta);
            }
        }

        private void CargarImagenes(string ruta)
        {
            archivos = Directory.GetFiles(ruta, "*.*")
                                .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                            f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                            f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                            f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                                .ToArray();

            CmImagen.Items.Clear();
            foreach (string img in archivos)
            {
                CmImagen.Items.Add(Path.GetFileName(img));
            }

            if (archivos.Length > 0)
            {
                indice = 0;
                CmImagen.SelectedIndex = indice;
                MostrarImagen();
            }
        }

        private Image CargarOriginalSinBloqueo(string ruta)
        {
            byte[] bytes = File.ReadAllBytes(ruta);
            using (var ms = new MemoryStream(bytes))
            using (var img = Image.FromStream(ms))
            {
                return new Bitmap(img);
            }
        }

        private void MostrarImagen()
        {
            if (archivos == null || archivos.Length == 0) return;

            if (bxVisor.Image != null)
            {
                bxVisor.Image.Dispose();
                bxVisor.Image = null;
            }

            if (originalImage != null)
            {
                originalImage.Dispose();
                originalImage = null;
            }

            originalImage = CargarOriginalSinBloqueo(archivos[indice]);
            bxVisor.Image = new Bitmap(originalImage);
            lblRuta.Text = archivos[indice];

            if (aplicarEscalaGrises)
            {
                AplicarGrises();
            }
        }

        private void RestaurarNormal()
        {
            if (originalImage == null) return;
            if (bxVisor.Image != null)
            {
                bxVisor.Image.Dispose();
            }
            bxVisor.Image = new Bitmap(originalImage);
        }

        private void AplicarGrises()
        {
            if (originalImage == null) return;
            Bitmap destino = new Bitmap(originalImage.Width, originalImage.Height);
            using (Graphics g = Graphics.FromImage(destino))
            {
                var cm = new ColorMatrix(new float[][]
                {
                    new float[] {0.299f, 0.299f, 0.299f, 0, 0},
                    new float[] {0.587f, 0.587f, 0.587f, 0, 0},
                    new float[] {0.114f, 0.114f, 0.114f, 0, 0},
                    new float[] {0,      0,      0,      1, 0},
                    new float[] {0,      0,      0,      0, 1}
                });
                using (var attrs = new ImageAttributes())
                {
                    attrs.SetColorMatrix(cm);
                    g.DrawImage(originalImage,
                                new Rectangle(0, 0, destino.Width, destino.Height),
                                0, 0, originalImage.Width, originalImage.Height,
                                GraphicsUnit.Pixel, attrs);
                }
            }
            if (bxVisor.Image != null)
            {
                bxVisor.Image.Dispose();
            }
            bxVisor.Image = destino;
        }

        private void SetVisionMode(PictureBoxSizeMode mode)
        {
            bxVisor.SizeMode = mode;
            rbZoom.Checked = (mode == PictureBoxSizeMode.Zoom);
            rbAjustar.Checked = (mode == PictureBoxSizeMode.StretchImage);
            rbCentrada.Checked = (mode == PictureBoxSizeMode.CenterImage);
            toolSZoom.Checked = (mode == PictureBoxSizeMode.Zoom);
            toolSAjustar.Checked = (mode == PictureBoxSizeMode.StretchImage);
            toolSCentrada.Checked = (mode == PictureBoxSizeMode.CenterImage);
        }

        private void SetVisionFilter(bool escalaGrises)
        {
            aplicarEscalaGrises = escalaGrises;
            if (aplicarEscalaGrises)
            {
                AplicarGrises();
                cbEscalaGris.Checked = true;
                cbNormal.Checked = false;
                toolSGris.Checked = true;
                toolSNormal.Checked = false;
            }
            else
            {
                RestaurarNormal();
                cbNormal.Checked = true;
                cbEscalaGris.Checked = false;
                toolSNormal.Checked = true;
                toolSGris.Checked = false;
            }
        }

        private void rbZoom_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbZoom.Checked) SetVisionMode(PictureBoxSizeMode.Zoom);
        }

        private void rbAjustar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbAjustar.Checked) SetVisionMode(PictureBoxSizeMode.StretchImage);
        }

        private void rbCentrada_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbCentrada.Checked) SetVisionMode(PictureBoxSizeMode.CenterImage);
        }

        private void toolSZoom_Click(object sender, EventArgs e) => SetVisionMode(PictureBoxSizeMode.Zoom);
        private void toolSAjustar_Click(object sender, EventArgs e) => SetVisionMode(PictureBoxSizeMode.StretchImage);
        private void toolSCentrada_Click(object sender, EventArgs e) => SetVisionMode(PictureBoxSizeMode.CenterImage);

        private void cbEscalaGris_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEscalaGris.Checked) SetVisionFilter(true);
        }

        private void cbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNormal.Checked) SetVisionFilter(false);
        }

        private void toolSGris_Click(object sender, EventArgs e) => SetVisionFilter(true);
        private void toolSNormal_Click(object sender, EventArgs e) => SetVisionFilter(false);

        private void ajustar_Click(object sender, EventArgs e) => SetVisionMode(PictureBoxSizeMode.StretchImage);
        private void centrada_Click(object sender, EventArgs e) => SetVisionMode(PictureBoxSizeMode.CenterImage);
        private void zoom_Click(object sender, EventArgs e) => SetVisionMode(PictureBoxSizeMode.Zoom);

        private void escalaGris_Click(object sender, EventArgs e) => SetVisionFilter(true);
        private void normal_Click(object sender, EventArgs e) => SetVisionFilter(false);

        private void salir_Click(object sender, EventArgs e) => Application.Exit();

        private void guardar_Click(object sender, EventArgs e)
        {
            if (bxVisor.Image != null)
            {
                using (SaveFileDialog guardar = new SaveFileDialog())
                {
                    guardar.Filter = "Imagen JPG|*.jpg|Imagen PNG|*.png|Imagen BMP|*.bmp";
                    guardar.Title = "Guardar imagen";
                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        bxVisor.Image.Save(guardar.FileName);
                        MessageBox.Show("Imagen guardada correctamente en:\n" + guardar.FileName, "Guardar",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen cargada para guardar.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnUltimo_Click_1(object sender, EventArgs e)
        {
            if (archivos != null)
            {
                indice = archivos.Length - 1;
                CmImagen.SelectedIndex = indice;
                MostrarImagen();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (archivos != null && indice < archivos.Length - 1)
            {
                indice++;
                CmImagen.SelectedIndex = indice;
                MostrarImagen();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (archivos != null && indice > 0)
            {
                indice--;
                CmImagen.SelectedIndex = indice;
                MostrarImagen();
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (archivos != null)
            {
                indice = 0;
                CmImagen.SelectedIndex = indice;
                MostrarImagen();
            }
        }

        private void CmImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = CmImagen.SelectedIndex;
            MostrarImagen();
        }

        private void girarIzquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bxVisor.Image != null)
            {
                bxVisor.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                bxVisor.Refresh();
            }
        }
        private void girarDerechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bxVisor.Image != null)
            {
                bxVisor.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                bxVisor.Refresh();
            }
        }
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bxVisor.Image != null)
            {
                Clipboard.SetImage(bxVisor.Image);
                MessageBox.Show("Imagen copiada al portapapeles.", "Copiar",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gboxTamaño_Enter(object sender, EventArgs e)
        {

        }

       

    }
}
