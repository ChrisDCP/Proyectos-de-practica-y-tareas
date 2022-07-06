namespace SISGA
{
    partial class DatosCliente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdNombre = new System.Windows.Forms.RadioButton();
            this.rdApellidos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.rdApellidos);
            this.Datos.Controls.Add(this.rdNombre);
            this.Datos.Controls.Add(this.textBox1);
            this.Datos.Controls.Add(this.lblBuscar);
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(13, 27);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(574, 96);
            this.Datos.TabIndex = 1;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(3, 27);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(92, 25);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 31);
            this.textBox1.TabIndex = 1;
            // 
            // rdNombre
            // 
            this.rdNombre.AutoSize = true;
            this.rdNombre.Checked = true;
            this.rdNombre.Location = new System.Drawing.Point(319, 27);
            this.rdNombre.Name = "rdNombre";
            this.rdNombre.Size = new System.Drawing.Size(111, 29);
            this.rdNombre.TabIndex = 2;
            this.rdNombre.TabStop = true;
            this.rdNombre.Text = "Nombre";
            this.rdNombre.UseVisualStyleBackColor = true;
            // 
            // rdApellidos
            // 
            this.rdApellidos.AutoSize = true;
            this.rdApellidos.Location = new System.Drawing.Point(436, 30);
            this.rdApellidos.Name = "rdApellidos";
            this.rdApellidos.Size = new System.Drawing.Size(127, 29);
            this.rdApellidos.TabIndex = 3;
            this.rdApellidos.Text = "Apellidos";
            this.rdApellidos.UseVisualStyleBackColor = true;
            // 
            // DatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DatosCliente";
            this.Size = new System.Drawing.Size(616, 324);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.RadioButton rdApellidos;
        private System.Windows.Forms.RadioButton rdNombre;
    }
}
