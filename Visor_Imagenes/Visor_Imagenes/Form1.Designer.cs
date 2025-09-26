namespace Visor_Imagenes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mnArchivo = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVision = new System.Windows.Forms.ToolStripMenuItem();
            this.normal = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaGris = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTamaño = new System.Windows.Forms.ToolStripMenuItem();
            this.centrada = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustar = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom = new System.Windows.Forms.ToolStripMenuItem();
            this.bxVisor = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.girarIzquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girarDerechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gboxVision = new System.Windows.Forms.GroupBox();
            this.cbEscalaGris = new System.Windows.Forms.CheckBox();
            this.cbNormal = new System.Windows.Forms.CheckBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.CmImagen = new System.Windows.Forms.ComboBox();
            this.LbImagen = new System.Windows.Forms.Label();
            this.gboxTamaño = new System.Windows.Forms.GroupBox();
            this.rbZoom = new System.Windows.Forms.RadioButton();
            this.rbAjustar = new System.Windows.Forms.RadioButton();
            this.rbCentrada = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRuta = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSNormal = new System.Windows.Forms.ToolStripButton();
            this.toolSGris = new System.Windows.Forms.ToolStripButton();
            this.toolSCentrada = new System.Windows.Forms.ToolStripButton();
            this.toolSAjustar = new System.Windows.Forms.ToolStripButton();
            this.toolSZoom = new System.Windows.Forms.ToolStripButton();
            this.mnArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bxVisor)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gboxVision.SuspendLayout();
            this.gboxTamaño.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnArchivo
            // 
            this.mnArchivo.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnArchivo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnVision,
            this.mnTamaño});
            this.mnArchivo.Location = new System.Drawing.Point(0, 0);
            this.mnArchivo.Name = "mnArchivo";
            this.mnArchivo.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnArchivo.Size = new System.Drawing.Size(914, 33);
            this.mnArchivo.TabIndex = 0;
            this.mnArchivo.Text = "Archivo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.guardar,
            this.salir});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 29);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // guardar
            // 
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(177, 34);
            this.guardar.Text = "Guardar";
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // salir
            // 
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(177, 34);
            this.salir.Text = "Salir";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // mnVision
            // 
            this.mnVision.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normal,
            this.escalaGris});
            this.mnVision.Name = "mnVision";
            this.mnVision.Size = new System.Drawing.Size(76, 29);
            this.mnVision.Text = "Vision";
            // 
            // normal
            // 
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(213, 34);
            this.normal.Text = "Normal";
            this.normal.Click += new System.EventHandler(this.normal_Click);
            // 
            // escalaGris
            // 
            this.escalaGris.Name = "escalaGris";
            this.escalaGris.Size = new System.Drawing.Size(213, 34);
            this.escalaGris.Text = "Escala Grises";
            this.escalaGris.Click += new System.EventHandler(this.escalaGris_Click);
            // 
            // mnTamaño
            // 
            this.mnTamaño.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centrada,
            this.ajustar,
            this.zoom});
            this.mnTamaño.Name = "mnTamaño";
            this.mnTamaño.Size = new System.Drawing.Size(90, 29);
            this.mnTamaño.Text = "Tamaño";
            // 
            // centrada
            // 
            this.centrada.Name = "centrada";
            this.centrada.Size = new System.Drawing.Size(185, 34);
            this.centrada.Text = "Centrada";
            this.centrada.Click += new System.EventHandler(this.centrada_Click);
            // 
            // ajustar
            // 
            this.ajustar.Name = "ajustar";
            this.ajustar.Size = new System.Drawing.Size(185, 34);
            this.ajustar.Text = "Ajustar";
            this.ajustar.Click += new System.EventHandler(this.ajustar_Click);
            // 
            // zoom
            // 
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(185, 34);
            this.zoom.Text = "Zoom";
            this.zoom.Click += new System.EventHandler(this.zoom_Click);
            // 
            // bxVisor
            // 
            this.bxVisor.ContextMenuStrip = this.contextMenuStrip1;
            this.bxVisor.Location = new System.Drawing.Point(104, 231);
            this.bxVisor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bxVisor.Name = "bxVisor";
            this.bxVisor.Size = new System.Drawing.Size(506, 322);
            this.bxVisor.TabIndex = 1;
            this.bxVisor.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girarIzquierdaToolStripMenuItem,
            this.girarDerechaToolStripMenuItem,
            this.copiarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(264, 100);
            // 
            // girarIzquierdaToolStripMenuItem
            // 
            this.girarIzquierdaToolStripMenuItem.Name = "girarIzquierdaToolStripMenuItem";
            this.girarIzquierdaToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.girarIzquierdaToolStripMenuItem.Text = "Girar 90° a la Izquierda";
            this.girarIzquierdaToolStripMenuItem.Click += new System.EventHandler(this.girarIzquierdaToolStripMenuItem_Click);
            // 
            // girarDerechaToolStripMenuItem
            // 
            this.girarDerechaToolStripMenuItem.Name = "girarDerechaToolStripMenuItem";
            this.girarDerechaToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.girarDerechaToolStripMenuItem.Text = "Girar 90° a la Derecha";
            this.girarDerechaToolStripMenuItem.Click += new System.EventHandler(this.girarDerechaToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // gboxVision
            // 
            this.gboxVision.BackColor = System.Drawing.SystemColors.Info;
            this.gboxVision.Controls.Add(this.cbEscalaGris);
            this.gboxVision.Controls.Add(this.cbNormal);
            this.gboxVision.Location = new System.Drawing.Point(14, 85);
            this.gboxVision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxVision.Name = "gboxVision";
            this.gboxVision.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxVision.Size = new System.Drawing.Size(578, 81);
            this.gboxVision.TabIndex = 3;
            this.gboxVision.TabStop = false;
            this.gboxVision.Text = "Visión";
            // 
            // cbEscalaGris
            // 
            this.cbEscalaGris.AutoSize = true;
            this.cbEscalaGris.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cbEscalaGris.Location = new System.Drawing.Point(332, 38);
            this.cbEscalaGris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEscalaGris.Name = "cbEscalaGris";
            this.cbEscalaGris.Size = new System.Drawing.Size(167, 24);
            this.cbEscalaGris.TabIndex = 1;
            this.cbEscalaGris.Text = "Escalas de Grises ";
            this.cbEscalaGris.UseVisualStyleBackColor = false;
            this.cbEscalaGris.CheckedChanged += new System.EventHandler(this.cbEscalaGris_CheckedChanged);
            // 
            // cbNormal
            // 
            this.cbNormal.AutoSize = true;
            this.cbNormal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cbNormal.Location = new System.Drawing.Point(56, 38);
            this.cbNormal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNormal.Name = "cbNormal";
            this.cbNormal.Size = new System.Drawing.Size(85, 24);
            this.cbNormal.TabIndex = 0;
            this.cbNormal.Text = "Normal";
            this.cbNormal.UseVisualStyleBackColor = false;
            this.cbNormal.CheckedChanged += new System.EventHandler(this.cbNormal_CheckedChanged);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(104, 561);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(97, 29);
            this.btnPrimero.TabIndex = 4;
            this.btnPrimero.Text = "< <";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(226, 561);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(93, 29);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(382, 561);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(101, 29);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(511, 561);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(99, 29);
            this.btnUltimo.TabIndex = 7;
            this.btnUltimo.Text = "> >";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click_1);
            // 
            // CmImagen
            // 
            this.CmImagen.FormattingEnabled = true;
            this.CmImagen.Location = new System.Drawing.Point(332, 182);
            this.CmImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmImagen.Name = "CmImagen";
            this.CmImagen.Size = new System.Drawing.Size(202, 28);
            this.CmImagen.TabIndex = 8;
            this.CmImagen.SelectedIndexChanged += new System.EventHandler(this.CmImagen_SelectedIndexChanged);
            // 
            // LbImagen
            // 
            this.LbImagen.AutoSize = true;
            this.LbImagen.Location = new System.Drawing.Point(198, 186);
            this.LbImagen.Name = "LbImagen";
            this.LbImagen.Size = new System.Drawing.Size(116, 20);
            this.LbImagen.TabIndex = 9;
            this.LbImagen.Text = "Imagén Actual:";
            // 
            // gboxTamaño
            // 
            this.gboxTamaño.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gboxTamaño.Controls.Add(this.rbZoom);
            this.gboxTamaño.Controls.Add(this.rbAjustar);
            this.gboxTamaño.Controls.Add(this.rbCentrada);
            this.gboxTamaño.Location = new System.Drawing.Point(694, 85);
            this.gboxTamaño.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxTamaño.Name = "gboxTamaño";
            this.gboxTamaño.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxTamaño.Size = new System.Drawing.Size(194, 145);
            this.gboxTamaño.TabIndex = 2;
            this.gboxTamaño.TabStop = false;
            this.gboxTamaño.Text = "Tamaño";
            this.gboxTamaño.Enter += new System.EventHandler(this.gboxTamaño_Enter);
            // 
            // rbZoom
            // 
            this.rbZoom.AutoSize = true;
            this.rbZoom.Location = new System.Drawing.Point(8, 95);
            this.rbZoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbZoom.Name = "rbZoom";
            this.rbZoom.Size = new System.Drawing.Size(75, 24);
            this.rbZoom.TabIndex = 13;
            this.rbZoom.Text = "Zoom";
            this.rbZoom.UseVisualStyleBackColor = true;
            this.rbZoom.CheckedChanged += new System.EventHandler(this.rbZoom_CheckedChanged_1);
            // 
            // rbAjustar
            // 
            this.rbAjustar.AutoSize = true;
            this.rbAjustar.Location = new System.Drawing.Point(8, 61);
            this.rbAjustar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAjustar.Name = "rbAjustar";
            this.rbAjustar.Size = new System.Drawing.Size(84, 24);
            this.rbAjustar.TabIndex = 12;
            this.rbAjustar.Text = "Ajustar";
            this.rbAjustar.UseVisualStyleBackColor = true;
            this.rbAjustar.CheckedChanged += new System.EventHandler(this.rbAjustar_CheckedChanged_1);
            // 
            // rbCentrada
            // 
            this.rbCentrada.AutoSize = true;
            this.rbCentrada.Checked = true;
            this.rbCentrada.Location = new System.Drawing.Point(8, 26);
            this.rbCentrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCentrada.Name = "rbCentrada";
            this.rbCentrada.Size = new System.Drawing.Size(100, 24);
            this.rbCentrada.TabIndex = 11;
            this.rbCentrada.TabStop = true;
            this.rbCentrada.Text = "Centrada";
            this.rbCentrada.UseVisualStyleBackColor = true;
            this.rbCentrada.CheckedChanged += new System.EventHandler(this.rbCentrada_CheckedChanged_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRuta});
            this.statusStrip1.Location = new System.Drawing.Point(0, 594);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(914, 32);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRuta
            // 
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(179, 25);
            this.lblRuta.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSNormal,
            this.toolSGris,
            this.toolSCentrada,
            this.toolSAjustar,
            this.toolSZoom});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 29);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSNormal
            // 
            this.toolSNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSNormal.Image = ((System.Drawing.Image)(resources.GetObject("toolSNormal.Image")));
            this.toolSNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSNormal.Name = "toolSNormal";
            this.toolSNormal.Size = new System.Drawing.Size(34, 24);
            this.toolSNormal.Text = "toolStripButton1";
            this.toolSNormal.Click += new System.EventHandler(this.toolSNormal_Click);
            // 
            // toolSGris
            // 
            this.toolSGris.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSGris.Image = ((System.Drawing.Image)(resources.GetObject("toolSGris.Image")));
            this.toolSGris.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSGris.Name = "toolSGris";
            this.toolSGris.Size = new System.Drawing.Size(34, 24);
            this.toolSGris.Text = "toolStripButton2";
            this.toolSGris.Click += new System.EventHandler(this.toolSGris_Click);
            // 
            // toolSCentrada
            // 
            this.toolSCentrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSCentrada.Image = ((System.Drawing.Image)(resources.GetObject("toolSCentrada.Image")));
            this.toolSCentrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSCentrada.Name = "toolSCentrada";
            this.toolSCentrada.Size = new System.Drawing.Size(34, 24);
            this.toolSCentrada.Text = "toolStripButton5";
            this.toolSCentrada.Click += new System.EventHandler(this.toolSCentrada_Click);
            // 
            // toolSAjustar
            // 
            this.toolSAjustar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSAjustar.Image = ((System.Drawing.Image)(resources.GetObject("toolSAjustar.Image")));
            this.toolSAjustar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSAjustar.Name = "toolSAjustar";
            this.toolSAjustar.Size = new System.Drawing.Size(34, 24);
            this.toolSAjustar.Text = "toolStripButton3";
            this.toolSAjustar.Click += new System.EventHandler(this.toolSAjustar_Click);
            // 
            // toolSZoom
            // 
            this.toolSZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSZoom.Image = ((System.Drawing.Image)(resources.GetObject("toolSZoom.Image")));
            this.toolSZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSZoom.Name = "toolSZoom";
            this.toolSZoom.Size = new System.Drawing.Size(34, 24);
            this.toolSZoom.Text = "toolStripButton4";
            this.toolSZoom.Click += new System.EventHandler(this.toolSZoom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 626);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LbImagen);
            this.Controls.Add(this.CmImagen);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.gboxVision);
            this.Controls.Add(this.gboxTamaño);
            this.Controls.Add(this.bxVisor);
            this.Controls.Add(this.mnArchivo);
            this.MainMenuStrip = this.mnArchivo;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Visor de Imagénes";
            this.mnArchivo.ResumeLayout(false);
            this.mnArchivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bxVisor)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gboxVision.ResumeLayout(false);
            this.gboxVision.PerformLayout();
            this.gboxTamaño.ResumeLayout(false);
            this.gboxTamaño.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnArchivo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnVision;
        private System.Windows.Forms.ToolStripMenuItem mnTamaño;
        private System.Windows.Forms.ToolStripMenuItem guardar;
        private System.Windows.Forms.ToolStripMenuItem salir;
        private System.Windows.Forms.ToolStripMenuItem normal;
        private System.Windows.Forms.ToolStripMenuItem escalaGris;
        private System.Windows.Forms.ToolStripMenuItem centrada;
        private System.Windows.Forms.ToolStripMenuItem ajustar;
        private System.Windows.Forms.ToolStripMenuItem zoom;
        private System.Windows.Forms.PictureBox bxVisor;
        private System.Windows.Forms.GroupBox gboxVision;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.CheckBox cbNormal;
        private System.Windows.Forms.CheckBox cbEscalaGris;
        private System.Windows.Forms.ComboBox CmImagen;
        private System.Windows.Forms.Label LbImagen;
        private System.Windows.Forms.GroupBox gboxTamaño;
        private System.Windows.Forms.RadioButton rbZoom;
        private System.Windows.Forms.RadioButton rbAjustar;
        private System.Windows.Forms.RadioButton rbCentrada;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblRuta;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSNormal;
        private System.Windows.Forms.ToolStripButton toolSGris;
        private System.Windows.Forms.ToolStripButton toolSAjustar;
        private System.Windows.Forms.ToolStripButton toolSZoom;
        private System.Windows.Forms.ToolStripButton toolSCentrada;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girarIzquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girarDerechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
    }
}

