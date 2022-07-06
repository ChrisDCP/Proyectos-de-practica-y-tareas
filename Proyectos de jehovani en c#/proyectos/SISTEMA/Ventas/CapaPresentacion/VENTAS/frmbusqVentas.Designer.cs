namespace CapaPresentacion.VENTAS
{
    partial class frmbusqVentas
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
            this.group3 = new System.Windows.Forms.GroupBox();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.datFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbcredito = new System.Windows.Forms.Label();
            this.group3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // group3
            // 
            this.group3.Controls.Add(this.gridview);
            this.group3.Location = new System.Drawing.Point(11, 110);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(711, 220);
            this.group3.TabIndex = 8;
            this.group3.TabStop = false;
            this.group3.Text = "Detalle de la Venta";
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
            // 
            // group1
            // 
            this.group1.BackColor = System.Drawing.Color.White;
            this.group1.Controls.Add(this.datFecha);
            this.group1.Controls.Add(this.label3);
            this.group1.Controls.Add(this.label2);
            this.group1.Controls.Add(this.txtcliente);
            this.group1.Controls.Add(this.txtcodigo);
            this.group1.Controls.Add(this.label4);
            this.group1.Location = new System.Drawing.Point(11, 11);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(714, 93);
            this.group1.TabIndex = 7;
            this.group1.TabStop = false;
            this.group1.Text = "Datos de la Venta";
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
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(169, 48);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(276, 26);
            this.txtcliente.TabIndex = 1;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(6, 48);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(133, 26);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nº Factura";
            // 
            // lbtotal
            // 
            this.lbtotal.ForeColor = System.Drawing.Color.Red;
            this.lbtotal.Location = new System.Drawing.Point(587, 340);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(132, 34);
            this.lbtotal.TabIndex = 21;
            this.lbtotal.Text = "00000,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(302, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(237, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "El costo total de la venta es:";
            // 
            // lbcredito
            // 
            this.lbcredito.AutoSize = true;
            this.lbcredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbcredito.Location = new System.Drawing.Point(10, 334);
            this.lbcredito.Name = "lbcredito";
            this.lbcredito.Size = new System.Drawing.Size(274, 40);
            this.lbcredito.TabIndex = 22;
            this.lbcredito.Text = "Nota:\r\nEsta factura fue dada en credito.";
            this.lbcredito.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbcredito.Visible = false;
            // 
            // frmbusqVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 379);
            this.Controls.Add(this.lbcredito);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.group3);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbusqVentas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busquedas de Ventas";
            this.Load += new System.EventHandler(this.frmbusqVentas_Load);
            this.group3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group3;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.DateTimePicker datFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbcredito;
    }
}