namespace CapaPresentacion.COMPRAS
{
    partial class frminventario
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtporc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbprecioVenta = new System.Windows.Forms.Label();
            this.btnuevo = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.lbcodProducto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbproducto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtporc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridview);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos:";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(114, 13);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(386, 26);
            this.txtproducto.TabIndex = 2;
            this.txtproducto.TextChanged += new System.EventHandler(this.txtproducto_TextChanged);
            // 
            // gridview
            // 
            this.gridview.BackgroundColor = System.Drawing.Color.White;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.ContextMenuStrip = this.contextMenuStrip1;
            this.gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridview.Location = new System.Drawing.Point(3, 22);
            this.gridview.Name = "gridview";
            this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview.Size = new System.Drawing.Size(482, 172);
            this.gridview.TabIndex = 0;
            this.gridview.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.gridview_ColumnAdded);
            this.gridview.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_RowEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio de Compra";
            // 
            // txtprecio
            // 
            this.txtprecio.Enabled = false;
            this.txtprecio.Location = new System.Drawing.Point(15, 316);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(148, 26);
            this.txtprecio.TabIndex = 4;
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtprecio.ValueChanged += new System.EventHandler(this.txtprecio_ValueChanged);
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Porc. de Venta";
            // 
            // txtporc
            // 
            this.txtporc.Enabled = false;
            this.txtporc.Location = new System.Drawing.Point(187, 316);
            this.txtporc.Name = "txtporc";
            this.txtporc.Size = new System.Drawing.Size(148, 26);
            this.txtporc.TabIndex = 4;
            this.txtporc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtporc.ValueChanged += new System.EventHandler(this.txtporc_ValueChanged);
            this.txtporc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtporc_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de Venta";
            // 
            // lbprecioVenta
            // 
            this.lbprecioVenta.ForeColor = System.Drawing.Color.Red;
            this.lbprecioVenta.Location = new System.Drawing.Point(342, 316);
            this.lbprecioVenta.Name = "lbprecioVenta";
            this.lbprecioVenta.Size = new System.Drawing.Size(158, 26);
            this.lbprecioVenta.TabIndex = 5;
            this.lbprecioVenta.Text = "C$000000";
            this.lbprecioVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnuevo
            // 
            this.btnuevo.Enabled = false;
            this.btnuevo.Location = new System.Drawing.Point(16, 357);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(134, 37);
            this.btnuevo.TabIndex = 6;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(366, 357);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(134, 37);
            this.btcancelar.TabIndex = 7;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btguardar
            // 
            this.btguardar.Enabled = false;
            this.btguardar.Location = new System.Drawing.Point(201, 357);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(134, 37);
            this.btguardar.TabIndex = 8;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 30);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Codigo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbcodProducto
            // 
            this.lbcodProducto.Location = new System.Drawing.Point(12, 264);
            this.lbcodProducto.Name = "lbcodProducto";
            this.lbcodProducto.Size = new System.Drawing.Size(151, 20);
            this.lbcodProducto.TabIndex = 3;
            this.lbcodProducto.Text = "0000000";
            this.lbcodProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(158, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Producto";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbproducto
            // 
            this.lbproducto.Location = new System.Drawing.Point(169, 256);
            this.lbproducto.Name = "lbproducto";
            this.lbproducto.Size = new System.Drawing.Size(328, 28);
            this.lbproducto.TabIndex = 3;
            this.lbproducto.Text = "XXXXXXXXXXXXXX";
            this.lbproducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frminventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 405);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.lbprecioVenta);
            this.Controls.Add(this.txtporc);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbproducto);
            this.Controls.Add(this.lbcodProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frminventario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros de Inventario";
            this.Load += new System.EventHandler(this.frminventario_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtporc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtporc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbprecioVenta;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbcodProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbproducto;
    }
}