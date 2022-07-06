namespace CapaPresentacion.VENTAS
{
    partial class frmcredito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lista = new System.Windows.Forms.ListBox();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.lbtotal = new System.Windows.Forms.Label();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.datFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.group3 = new System.Windows.Forms.GroupBox();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btguardar = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.databono = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbsaldo_actual = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.group1.SuspendLayout();
            this.group3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 20;
            this.lista.Location = new System.Drawing.Point(13, 44);
            this.lista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(94, 424);
            this.lista.TabIndex = 0;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // group1
            // 
            this.group1.BackColor = System.Drawing.Color.White;
            this.group1.Controls.Add(this.txtcliente);
            this.group1.Controls.Add(this.lbtotal);
            this.group1.Controls.Add(this.lbcodigo);
            this.group1.Controls.Add(this.datFecha);
            this.group1.Controls.Add(this.label4);
            this.group1.Controls.Add(this.label3);
            this.group1.Controls.Add(this.label2);
            this.group1.Controls.Add(this.label1);
            this.group1.Location = new System.Drawing.Point(123, 17);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(714, 93);
            this.group1.TabIndex = 23;
            this.group1.TabStop = false;
            this.group1.Text = "Datos de la Venta";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(143, 50);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(217, 26);
            this.txtcliente.TabIndex = 23;
            // 
            // lbtotal
            // 
            this.lbtotal.ForeColor = System.Drawing.Color.Red;
            this.lbtotal.Location = new System.Drawing.Point(541, 42);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(132, 34);
            this.lbtotal.TabIndex = 22;
            this.lbtotal.Text = "00000,00";
            this.lbtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbcodigo
            // 
            this.lbcodigo.ForeColor = System.Drawing.Color.Red;
            this.lbcodigo.Location = new System.Drawing.Point(6, 51);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(136, 25);
            this.lbcodigo.TabIndex = 7;
            this.lbcodigo.Text = "0000000";
            this.lbcodigo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // datFecha
            // 
            this.datFecha.Enabled = false;
            this.datFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datFecha.Location = new System.Drawing.Point(375, 50);
            this.datFecha.Name = "datFecha";
            this.datFecha.Size = new System.Drawing.Size(134, 26);
            this.datFecha.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nº Factura";
            // 
            // group3
            // 
            this.group3.Controls.Add(this.gridview);
            this.group3.Location = new System.Drawing.Point(126, 116);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(711, 220);
            this.group3.TabIndex = 24;
            this.group3.TabStop = false;
            this.group3.Text = "Detalle de Abono";
            // 
            // gridview
            // 
            this.gridview.BackgroundColor = System.Drawing.Color.White;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridview.Location = new System.Drawing.Point(3, 22);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersWidth = 60;
            this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview.Size = new System.Drawing.Size(705, 195);
            this.gridview.TabIndex = 0;
            this.gridview.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.gridview_ColumnAdded);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btguardar);
            this.groupBox1.Controls.Add(this.btnuevo);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.databono);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(123, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 93);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Abono";
            // 
            // btguardar
            // 
            this.btguardar.Enabled = false;
            this.btguardar.Location = new System.Drawing.Point(618, 36);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(87, 38);
            this.btguardar.TabIndex = 24;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.Enabled = false;
            this.btnuevo.Location = new System.Drawing.Point(525, 36);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(87, 38);
            this.btnuevo.TabIndex = 24;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.DecimalPlaces = 2;
            this.txtcantidad.Location = new System.Drawing.Point(25, 48);
            this.txtcantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(106, 26);
            this.txtcantidad.TabIndex = 23;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcantidad.ValueChanged += new System.EventHandler(this.txtcantidad_ValueChanged);
            // 
            // databono
            // 
            this.databono.Enabled = false;
            this.databono.Location = new System.Drawing.Point(182, 48);
            this.databono.Name = "databono";
            this.databono.Size = new System.Drawing.Size(325, 26);
            this.databono.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Fecha del abono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lista Factura";
            // 
            // lbsaldo_actual
            // 
            this.lbsaldo_actual.ForeColor = System.Drawing.Color.Red;
            this.lbsaldo_actual.Location = new System.Drawing.Point(705, 339);
            this.lbsaldo_actual.Name = "lbsaldo_actual";
            this.lbsaldo_actual.Size = new System.Drawing.Size(132, 34);
            this.lbsaldo_actual.TabIndex = 27;
            this.lbsaldo_actual.Text = "00000,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(585, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Saldo Actual:";
            // 
            // frmcredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 472);
            this.Controls.Add(this.lbsaldo_actual);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group3);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcredito";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Credito";
            this.Load += new System.EventHandler(this.frmcredito_Load);
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.DateTimePicker datFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group3;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.DateTimePicker databono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbsaldo_actual;
        private System.Windows.Forms.Label label13;
    }
}