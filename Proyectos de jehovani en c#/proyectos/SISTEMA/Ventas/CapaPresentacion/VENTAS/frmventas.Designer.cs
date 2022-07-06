namespace CapaPresentacion.VENTAS
{
    partial class frmventas
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
            this.btsalir = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            this.lbtotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.group3 = new System.Windows.Forms.GroupBox();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.btagregar = new System.Windows.Forms.Button();
            this.lbprecioVenta = new System.Windows.Forms.Label();
            this.lbsubtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.txtunidadMedida = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbproducto = new System.Windows.Forms.ComboBox();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.datFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbcliente = new System.Windows.Forms.ComboBox();
            this.chcredito = new System.Windows.Forms.CheckBox();
            this.group3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.group2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btsalir
            // 
            this.btsalir.Location = new System.Drawing.Point(248, 580);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(97, 37);
            this.btsalir.TabIndex = 29;
            this.btsalir.Text = "Salir";
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.Enabled = false;
            this.btnuevo.Location = new System.Drawing.Point(14, 580);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(97, 37);
            this.btnuevo.TabIndex = 28;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // btguardar
            // 
            this.btguardar.Enabled = false;
            this.btguardar.Location = new System.Drawing.Point(131, 580);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(97, 37);
            this.btguardar.TabIndex = 27;
            this.btguardar.Text = "Facturar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // lbtotal
            // 
            this.lbtotal.ForeColor = System.Drawing.Color.Red;
            this.lbtotal.Location = new System.Drawing.Point(586, 544);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(132, 34);
            this.lbtotal.TabIndex = 26;
            this.lbtotal.Text = "00000,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(301, 544);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(237, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "El costo total de la venta es:";
            // 
            // group3
            // 
            this.group3.Controls.Add(this.gridview);
            this.group3.Location = new System.Drawing.Point(10, 321);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(711, 220);
            this.group3.TabIndex = 24;
            this.group3.TabStop = false;
            this.group3.Text = "Detalle de la Venta";
            // 
            // gridview
            // 
            this.gridview.BackgroundColor = System.Drawing.Color.White;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.producto,
            this.cantidad,
            this.precio,
            this.subtotal});
            this.gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridview.Location = new System.Drawing.Point(3, 22);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersWidth = 60;
            this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview.Size = new System.Drawing.Size(705, 195);
            this.gridview.TabIndex = 0;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "Codigo";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 120;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 120;
            // 
            // group2
            // 
            this.group2.BackColor = System.Drawing.Color.White;
            this.group2.Controls.Add(this.btagregar);
            this.group2.Controls.Add(this.lbprecioVenta);
            this.group2.Controls.Add(this.lbsubtotal);
            this.group2.Controls.Add(this.label5);
            this.group2.Controls.Add(this.label9);
            this.group2.Controls.Add(this.txtexistencia);
            this.group2.Controls.Add(this.txtunidadMedida);
            this.group2.Controls.Add(this.txtcantidad);
            this.group2.Controls.Add(this.label4);
            this.group2.Controls.Add(this.label10);
            this.group2.Controls.Add(this.txtidProducto);
            this.group2.Controls.Add(this.label8);
            this.group2.Controls.Add(this.label6);
            this.group2.Controls.Add(this.label7);
            this.group2.Controls.Add(this.cbproducto);
            this.group2.Location = new System.Drawing.Point(10, 125);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(711, 178);
            this.group2.TabIndex = 23;
            this.group2.TabStop = false;
            this.group2.Text = "Datos del Producto";
            // 
            // btagregar
            // 
            this.btagregar.Location = new System.Drawing.Point(554, 102);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(96, 53);
            this.btagregar.TabIndex = 17;
            this.btagregar.Text = "Agregar";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // lbprecioVenta
            // 
            this.lbprecioVenta.ForeColor = System.Drawing.Color.Red;
            this.lbprecioVenta.Location = new System.Drawing.Point(188, 128);
            this.lbprecioVenta.Name = "lbprecioVenta";
            this.lbprecioVenta.Size = new System.Drawing.Size(147, 34);
            this.lbprecioVenta.TabIndex = 16;
            this.lbprecioVenta.Text = "C$ 00000,00";
            this.lbprecioVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbsubtotal
            // 
            this.lbsubtotal.ForeColor = System.Drawing.Color.Red;
            this.lbsubtotal.Location = new System.Drawing.Point(355, 128);
            this.lbsubtotal.Name = "lbsubtotal";
            this.lbsubtotal.Size = new System.Drawing.Size(147, 34);
            this.lbsubtotal.TabIndex = 16;
            this.lbsubtotal.Text = "C$ 00000,00";
            this.lbsubtotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio de Venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "SubTotal";
            // 
            // txtexistencia
            // 
            this.txtexistencia.Location = new System.Drawing.Point(553, 62);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.ReadOnly = true;
            this.txtexistencia.Size = new System.Drawing.Size(97, 26);
            this.txtexistencia.TabIndex = 15;
            // 
            // txtunidadMedida
            // 
            this.txtunidadMedida.Location = new System.Drawing.Point(376, 62);
            this.txtunidadMedida.Name = "txtunidadMedida";
            this.txtunidadMedida.ReadOnly = true;
            this.txtunidadMedida.Size = new System.Drawing.Size(143, 26);
            this.txtunidadMedida.TabIndex = 15;
            // 
            // txtcantidad
            // 
            this.txtcantidad.DecimalPlaces = 2;
            this.txtcantidad.Enabled = false;
            this.txtcantidad.Location = new System.Drawing.Point(27, 125);
            this.txtcantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(130, 26);
            this.txtcantidad.TabIndex = 14;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcantidad.ValueChanged += new System.EventHandler(this.txtcantidad_ValueChanged);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Existencia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "UnidadMedida";
            // 
            // txtidProducto
            // 
            this.txtidProducto.Location = new System.Drawing.Point(27, 62);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.ReadOnly = true;
            this.txtidProducto.Size = new System.Drawing.Size(130, 26);
            this.txtidProducto.TabIndex = 8;
            this.txtidProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "ID Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre";
            // 
            // cbproducto
            // 
            this.cbproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproducto.FormattingEnabled = true;
            this.cbproducto.Location = new System.Drawing.Point(175, 62);
            this.cbproducto.Name = "cbproducto";
            this.cbproducto.Size = new System.Drawing.Size(178, 28);
            this.cbproducto.TabIndex = 0;
            this.cbproducto.SelectedIndexChanged += new System.EventHandler(this.cbproducto_SelectedIndexChanged);
            this.cbproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbproducto_KeyPress);
            // 
            // group1
            // 
            this.group1.BackColor = System.Drawing.Color.White;
            this.group1.Controls.Add(this.lbcodigo);
            this.group1.Controls.Add(this.datFecha);
            this.group1.Controls.Add(this.label3);
            this.group1.Controls.Add(this.label2);
            this.group1.Controls.Add(this.label1);
            this.group1.Controls.Add(this.cbcliente);
            this.group1.Location = new System.Drawing.Point(10, 17);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(714, 93);
            this.group1.TabIndex = 22;
            this.group1.TabStop = false;
            this.group1.Text = "Datos de la Venta";
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
            this.datFecha.Location = new System.Drawing.Point(471, 50);
            this.datFecha.Name = "datFecha";
            this.datFecha.Size = new System.Drawing.Size(221, 26);
            this.datFecha.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 22);
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
            // cbcliente
            // 
            this.cbcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcliente.FormattingEnabled = true;
            this.cbcliente.Location = new System.Drawing.Point(145, 48);
            this.cbcliente.Name = "cbcliente";
            this.cbcliente.Size = new System.Drawing.Size(289, 28);
            this.cbcliente.TabIndex = 2;
            this.cbcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbcliente_KeyPress);
            // 
            // chcredito
            // 
            this.chcredito.AutoSize = true;
            this.chcredito.Location = new System.Drawing.Point(20, 544);
            this.chcredito.Name = "chcredito";
            this.chcredito.Size = new System.Drawing.Size(86, 24);
            this.chcredito.TabIndex = 30;
            this.chcredito.Text = "Credito";
            this.chcredito.UseVisualStyleBackColor = true;
            // 
            // frmventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 634);
            this.Controls.Add(this.chcredito);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.group3);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.group1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmventas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros de Ventas";
            this.Load += new System.EventHandler(this.frmventas_Load);
            this.group3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox group3;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.Label lbsubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtunidadMedida;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtidProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbproducto;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.DateTimePicker datFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcliente;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbprecioVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chcredito;
    }
}