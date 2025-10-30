namespace procesos_en_segundo_plano
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.progressBurbuja = new System.Windows.Forms.ProgressBar();
            this.progressQuickSort = new System.Windows.Forms.ProgressBar();
            this.lblBurbuja = new System.Windows.Forms.Label();
            this.lblQuickSort = new System.Windows.Forms.Label();
            this.backgroundWorkerQuickSort = new System.ComponentModel.BackgroundWorker();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnDetener = new System.Windows.Forms.Button();
            this.chkLogIteraciones = new System.Windows.Forms.CheckBox();
            this.grpMerge = new System.Windows.Forms.GroupBox();
            this.lblTiempoMerge = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressMerge = new System.Windows.Forms.ProgressBar();
            this.lblMerge = new System.Windows.Forms.Label();
            this.grpSelection = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTiempoSelection = new System.Windows.Forms.Label();
            this.progressSelection = new System.Windows.Forms.ProgressBar();
            this.lblSelection = new System.Windows.Forms.Label();
            this.chtTiempos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExportar = new System.Windows.Forms.Button();
            this.backgroundWorkerMergeSort = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPausar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.grpMerge.SuspendLayout();
            this.grpSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtTiempos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(250, 21);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(181, 37);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Datos";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIniciar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Location = new System.Drawing.Point(456, 21);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(181, 37);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar Ordenamiento";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // progressBurbuja
            // 
            this.progressBurbuja.ForeColor = System.Drawing.Color.Red;
            this.progressBurbuja.Location = new System.Drawing.Point(6, 80);
            this.progressBurbuja.Name = "progressBurbuja";
            this.progressBurbuja.Size = new System.Drawing.Size(423, 49);
            this.progressBurbuja.TabIndex = 2;
            // 
            // progressQuickSort
            // 
            this.progressQuickSort.Location = new System.Drawing.Point(6, 80);
            this.progressQuickSort.Name = "progressQuickSort";
            this.progressQuickSort.Size = new System.Drawing.Size(423, 49);
            this.progressQuickSort.TabIndex = 3;
            // 
            // lblBurbuja
            // 
            this.lblBurbuja.AutoSize = true;
            this.lblBurbuja.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurbuja.Location = new System.Drawing.Point(77, 39);
            this.lblBurbuja.Name = "lblBurbuja";
            this.lblBurbuja.Size = new System.Drawing.Size(111, 22);
            this.lblBurbuja.TabIndex = 4;
            this.lblBurbuja.Text = "Burbuja: 0%";
            // 
            // lblQuickSort
            // 
            this.lblQuickSort.AutoSize = true;
            this.lblQuickSort.Location = new System.Drawing.Point(77, 42);
            this.lblQuickSort.Name = "lblQuickSort";
            this.lblQuickSort.Size = new System.Drawing.Size(128, 22);
            this.lblQuickSort.TabIndex = 5;
            this.lblQuickSort.Text = "QuickSort: 0%";
            // 
            // backgroundWorkerQuickSort
            // 
            this.backgroundWorkerQuickSort.WorkerReportsProgress = true;
            this.backgroundWorkerQuickSort.WorkerSupportsCancellation = true;
            this.backgroundWorkerQuickSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerQuickSort_DoWork);
            this.backgroundWorkerQuickSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerQuickSort_ProgressChanged);
            this.backgroundWorkerQuickSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerQuickSort_RunWorkerCompleted);
            // 
            // numCantidad
            // 
            this.numCantidad.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCantidad.Location = new System.Drawing.Point(105, 27);
            this.numCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 26);
            this.numCantidad.TabIndex = 6;
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDetener.Enabled = false;
            this.btnDetener.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Location = new System.Drawing.Point(894, 21);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(181, 37);
            this.btnDetener.TabIndex = 7;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // chkLogIteraciones
            // 
            this.chkLogIteraciones.AutoSize = true;
            this.chkLogIteraciones.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLogIteraciones.Location = new System.Drawing.Point(11, 77);
            this.chkLogIteraciones.Name = "chkLogIteraciones";
            this.chkLogIteraciones.Size = new System.Drawing.Size(193, 26);
            this.chkLogIteraciones.TabIndex = 8;
            this.chkLogIteraciones.Text = "Guardar iteraciones";
            this.chkLogIteraciones.UseVisualStyleBackColor = true;
            this.chkLogIteraciones.CheckedChanged += new System.EventHandler(this.chkLogIteraciones_CheckedChanged);
            // 
            // grpMerge
            // 
            this.grpMerge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpMerge.Controls.Add(this.lblTiempoMerge);
            this.grpMerge.Controls.Add(this.label3);
            this.grpMerge.Controls.Add(this.progressMerge);
            this.grpMerge.Controls.Add(this.lblMerge);
            this.grpMerge.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMerge.Location = new System.Drawing.Point(12, 423);
            this.grpMerge.Name = "grpMerge";
            this.grpMerge.Size = new System.Drawing.Size(463, 135);
            this.grpMerge.TabIndex = 9;
            this.grpMerge.TabStop = false;
            this.grpMerge.Text = "MergeSort";
            // 
            // lblTiempoMerge
            // 
            this.lblTiempoMerge.AutoSize = true;
            this.lblTiempoMerge.Location = new System.Drawing.Point(32, 170);
            this.lblTiempoMerge.Name = "lblTiempoMerge";
            this.lblTiempoMerge.Size = new System.Drawing.Size(101, 22);
            this.lblTiempoMerge.TabIndex = 2;
            this.lblTiempoMerge.Text = "Tiempo: —";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado:";
            // 
            // progressMerge
            // 
            this.progressMerge.Location = new System.Drawing.Point(5, 80);
            this.progressMerge.Name = "progressMerge";
            this.progressMerge.Size = new System.Drawing.Size(423, 49);
            this.progressMerge.TabIndex = 1;
            // 
            // lblMerge
            // 
            this.lblMerge.AutoSize = true;
            this.lblMerge.Location = new System.Drawing.Point(76, 47);
            this.lblMerge.Name = "lblMerge";
            this.lblMerge.Size = new System.Drawing.Size(132, 22);
            this.lblMerge.TabIndex = 0;
            this.lblMerge.Text = "MergeSort: 0%";
            // 
            // grpSelection
            // 
            this.grpSelection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpSelection.Controls.Add(this.label4);
            this.grpSelection.Controls.Add(this.lblTiempoSelection);
            this.grpSelection.Controls.Add(this.progressSelection);
            this.grpSelection.Controls.Add(this.lblSelection);
            this.grpSelection.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelection.Location = new System.Drawing.Point(11, 584);
            this.grpSelection.Name = "grpSelection";
            this.grpSelection.Size = new System.Drawing.Size(463, 135);
            this.grpSelection.TabIndex = 10;
            this.grpSelection.TabStop = false;
            this.grpSelection.Text = "SelectionSort ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Estado:";
            // 
            // lblTiempoSelection
            // 
            this.lblTiempoSelection.AutoSize = true;
            this.lblTiempoSelection.Location = new System.Drawing.Point(76, 185);
            this.lblTiempoSelection.Name = "lblTiempoSelection";
            this.lblTiempoSelection.Size = new System.Drawing.Size(101, 22);
            this.lblTiempoSelection.TabIndex = 2;
            this.lblTiempoSelection.Text = "Tiempo: —";
            // 
            // progressSelection
            // 
            this.progressSelection.Location = new System.Drawing.Point(6, 80);
            this.progressSelection.Name = "progressSelection";
            this.progressSelection.Size = new System.Drawing.Size(423, 49);
            this.progressSelection.TabIndex = 1;
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(82, 39);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(155, 22);
            this.lblSelection.TabIndex = 0;
            this.lblSelection.Text = "SelectionSort: 0%";
            // 
            // chtTiempos
            // 
            this.chtTiempos.BackColor = System.Drawing.Color.IndianRed;
            chartArea2.Name = "ChartArea1";
            this.chtTiempos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtTiempos.Legends.Add(legend2);
            this.chtTiempos.Location = new System.Drawing.Point(510, 120);
            this.chtTiempos.Name = "chtTiempos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtTiempos.Series.Add(series2);
            this.chtTiempos.Size = new System.Drawing.Size(565, 593);
            this.chtTiempos.TabIndex = 11;
            this.chtTiempos.Text = "chart1";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExportar.Enabled = false;
            this.btnExportar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(685, 21);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(181, 37);
            this.btnExportar.TabIndex = 12;
            this.btnExportar.Text = "Exportar iteraciones";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // backgroundWorkerMergeSort
            // 
            this.backgroundWorkerMergeSort.WorkerReportsProgress = true;
            this.backgroundWorkerMergeSort.WorkerSupportsCancellation = true;
            this.backgroundWorkerMergeSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMergeSort_DoWork);
            this.backgroundWorkerMergeSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerMergeSort_ProgressChanged);
            this.backgroundWorkerMergeSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMergeSort_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cantidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblBurbuja);
            this.groupBox1.Controls.Add(this.progressBurbuja);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 135);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Burbuja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Estado:";
            // 
            // groupbox2
            // 
            this.groupbox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupbox2.Controls.Add(this.label5);
            this.groupbox2.Controls.Add(this.lblQuickSort);
            this.groupbox2.Controls.Add(this.progressQuickSort);
            this.groupbox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox2.Location = new System.Drawing.Point(11, 272);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(463, 135);
            this.groupbox2.TabIndex = 15;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "QuickSort (BackgroundWorker)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Estado:";
            // 
            // btnPausar
            // 
            this.btnPausar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPausar.Location = new System.Drawing.Point(1081, 21);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(181, 37);
            this.btnPausar.TabIndex = 16;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1266, 731);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.chtTiempos);
            this.Controls.Add(this.grpSelection);
            this.Controls.Add(this.chkLogIteraciones);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.grpMerge);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Ordenamiento Multihilo";
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.grpMerge.ResumeLayout(false);
            this.grpMerge.PerformLayout();
            this.grpSelection.ResumeLayout(false);
            this.grpSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtTiempos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ProgressBar progressBurbuja;
        private System.Windows.Forms.ProgressBar progressQuickSort;
        private System.Windows.Forms.Label lblBurbuja;
        private System.Windows.Forms.Label lblQuickSort;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQuickSort;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.CheckBox chkLogIteraciones;
        private System.Windows.Forms.GroupBox grpMerge;
        private System.Windows.Forms.Label lblTiempoMerge;
        private System.Windows.Forms.ProgressBar progressMerge;
        private System.Windows.Forms.Label lblMerge;
        private System.Windows.Forms.GroupBox grpSelection;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Label lblTiempoSelection;
        private System.Windows.Forms.ProgressBar progressSelection;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTiempos;
        private System.Windows.Forms.Button btnExportar;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMergeSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPausar;
    }
}

