namespace CapaPresentacion.OPERACIONES
{
    partial class frmclientes
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
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsegundoApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprimerApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprimerNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnuevo = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.rdapellidos = new System.Windows.Forms.RadioButton();
            this.rdnombres = new System.Windows.Forms.RadioButton();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtsegundoApellido);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtprimerApellido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSegundoNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtprimerNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcedula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(376, 191);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdireccion.Size = new System.Drawing.Size(217, 46);
            this.txtdireccion.TabIndex = 13;
            this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdireccion_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dirección:";
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Location = new System.Drawing.Point(126, 193);
            this.txttelefono.Mask = "0000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(149, 26);
            this.txttelefono.TabIndex = 11;
            this.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono:";
            // 
            // txtsegundoApellido
            // 
            this.txtsegundoApellido.Enabled = false;
            this.txtsegundoApellido.Location = new System.Drawing.Point(467, 134);
            this.txtsegundoApellido.Name = "txtsegundoApellido";
            this.txtsegundoApellido.Size = new System.Drawing.Size(126, 26);
            this.txtsegundoApellido.TabIndex = 9;
            this.txtsegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsegundoApellido_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Segundo Apellido:";
            // 
            // txtprimerApellido
            // 
            this.txtprimerApellido.Enabled = false;
            this.txtprimerApellido.Location = new System.Drawing.Point(175, 135);
            this.txtprimerApellido.Name = "txtprimerApellido";
            this.txtprimerApellido.Size = new System.Drawing.Size(126, 26);
            this.txtprimerApellido.TabIndex = 7;
            this.txtprimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimerApellido_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Primer Apellido:";
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Enabled = false;
            this.txtSegundoNombre.Location = new System.Drawing.Point(467, 90);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(126, 26);
            this.txtSegundoNombre.TabIndex = 5;
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundo Nombre:";
            // 
            // txtprimerNombre
            // 
            this.txtprimerNombre.Enabled = false;
            this.txtprimerNombre.Location = new System.Drawing.Point(175, 91);
            this.txtprimerNombre.Name = "txtprimerNombre";
            this.txtprimerNombre.Size = new System.Drawing.Size(126, 26);
            this.txtprimerNombre.TabIndex = 3;
            this.txtprimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimerNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primer Nombre:";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(112, 38);
            this.txtcedula.Mask = "000-000000-0000L";
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(481, 26);
            this.txtcedula.TabIndex = 1;
            this.txtcedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula:";
            // 
            // btnuevo
            // 
            this.btnuevo.Enabled = false;
            this.btnuevo.Location = new System.Drawing.Point(125, 312);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(134, 37);
            this.btnuevo.TabIndex = 2;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(405, 312);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(134, 37);
            this.btcancelar.TabIndex = 3;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btguardar
            // 
            this.btguardar.Enabled = false;
            this.btguardar.Location = new System.Drawing.Point(265, 312);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(134, 37);
            this.btguardar.TabIndex = 4;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.ForeColor = System.Drawing.Color.Red;
            this.lbcodigo.Location = new System.Drawing.Point(566, 19);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(69, 20);
            this.lbcodigo.TabIndex = 5;
            this.lbcodigo.Text = "000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Codigo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridview);
            this.groupBox2.Location = new System.Drawing.Point(9, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 200);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
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
            this.gridview.Size = new System.Drawing.Size(620, 175);
            this.gridview.TabIndex = 1;
            this.gridview.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.gridview_ColumnAdded);
            this.gridview.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_RowEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 56);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.rdapellidos);
            this.Datos.Controls.Add(this.rdnombres);
            this.Datos.Controls.Add(this.txtbuscar);
            this.Datos.Controls.Add(this.label9);
            this.Datos.Location = new System.Drawing.Point(9, 352);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(626, 58);
            this.Datos.TabIndex = 8;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // rdapellidos
            // 
            this.rdapellidos.AutoSize = true;
            this.rdapellidos.Location = new System.Drawing.Point(521, 25);
            this.rdapellidos.Name = "rdapellidos";
            this.rdapellidos.Size = new System.Drawing.Size(100, 24);
            this.rdapellidos.TabIndex = 3;
            this.rdapellidos.TabStop = true;
            this.rdapellidos.Text = "Apellidos";
            this.rdapellidos.UseVisualStyleBackColor = true;
            this.rdapellidos.CheckedChanged += new System.EventHandler(this.rdapellidos_CheckedChanged);
            // 
            // rdnombres
            // 
            this.rdnombres.AutoSize = true;
            this.rdnombres.Checked = true;
            this.rdnombres.Location = new System.Drawing.Point(417, 25);
            this.rdnombres.Name = "rdnombres";
            this.rdnombres.Size = new System.Drawing.Size(98, 24);
            this.rdnombres.TabIndex = 2;
            this.rdnombres.TabStop = true;
            this.rdnombres.Text = "Nombres";
            this.rdnombres.UseVisualStyleBackColor = true;
            this.rdnombres.CheckedChanged += new System.EventHandler(this.rdnombres_CheckedChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(91, 23);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(320, 26);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Buscar:";
            // 
            // frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 613);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbcodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmclientes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros de Clientes";
            this.Load += new System.EventHandler(this.frmclientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsegundoApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprimerApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprimerNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtcedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.RadioButton rdapellidos;
        private System.Windows.Forms.RadioButton rdnombres;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}