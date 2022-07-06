namespace SISGA
{
    partial class frmempleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmempleado));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDatos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvDatosEm = new System.Windows.Forms.DataGridView();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btncancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btncerrarCliente = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbltelf = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblnomb = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbldirec = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblapell = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblregistro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuTileButton2);
            this.bunifuGradientPanel1.Controls.Add(this.btnDatos);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Green;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.YellowGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(2, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(179, 385);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTileButton2.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 60;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "";
            this.bunifuTileButton2.Location = new System.Drawing.Point(-19, -13);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(207, 151);
            this.bunifuTileButton2.TabIndex = 6;
            // 
            // btnDatos
            // 
            this.btnDatos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatos.BorderRadius = 0;
            this.btnDatos.ButtonText = "Mostrar Datos";
            this.btnDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatos.DisabledColor = System.Drawing.Color.Gray;
            this.btnDatos.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDatos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDatos.Iconimage")));
            this.btnDatos.Iconimage_right = null;
            this.btnDatos.Iconimage_right_Selected = null;
            this.btnDatos.Iconimage_Selected = null;
            this.btnDatos.IconMarginLeft = 0;
            this.btnDatos.IconMarginRight = 0;
            this.btnDatos.IconRightVisible = true;
            this.btnDatos.IconRightZoom = 0D;
            this.btnDatos.IconVisible = true;
            this.btnDatos.IconZoom = 60D;
            this.btnDatos.IsTab = false;
            this.btnDatos.Location = new System.Drawing.Point(-3, 205);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDatos.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDatos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDatos.selected = false;
            this.btnDatos.Size = new System.Drawing.Size(182, 52);
            this.btnDatos.TabIndex = 5;
            this.btnDatos.Text = "Mostrar Datos";
            this.btnDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatos.Textcolor = System.Drawing.Color.White;
            this.btnDatos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "        Guardar ";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 60D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 127);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(179, 52);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Text = "        Guardar ";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Regresar al menu";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 277);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(179, 52);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Regresar al menu";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dgvDatosEm
            // 
            this.dgvDatosEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEm.Location = new System.Drawing.Point(187, 235);
            this.dgvDatosEm.Name = "dgvDatosEm";
            this.dgvDatosEm.Size = new System.Drawing.Size(453, 150);
            this.dgvDatosEm.TabIndex = 44;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(282, 123);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(107, 20);
            this.txtApellido.TabIndex = 43;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(473, 123);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(114, 20);
            this.txtDireccion.TabIndex = 42;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(473, 83);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(114, 20);
            this.txtTelefono.TabIndex = 41;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(282, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(107, 20);
            this.txtNombre.TabIndex = 40;
            // 
            // btncancelar
            // 
            this.btncancelar.ActiveBorderThickness = 1;
            this.btncancelar.ActiveCornerRadius = 20;
            this.btncancelar.ActiveFillColor = System.Drawing.Color.Chartreuse;
            this.btncancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btncancelar.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btncancelar.BackColor = System.Drawing.Color.White;
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.ButtonText = "Cancelar";
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btncancelar.IdleBorderThickness = 1;
            this.btncancelar.IdleCornerRadius = 20;
            this.btncancelar.IdleFillColor = System.Drawing.Color.White;
            this.btncancelar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btncancelar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btncancelar.Location = new System.Drawing.Point(496, 188);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(114, 39);
            this.btncancelar.TabIndex = 39;
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveBorderThickness = 1;
            this.btnGuardar.ActiveCornerRadius = 20;
            this.btnGuardar.ActiveFillColor = System.Drawing.Color.Chartreuse;
            this.btnGuardar.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardar.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.IdleBorderThickness = 1;
            this.btnGuardar.IdleCornerRadius = 20;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.Location = new System.Drawing.Point(275, 188);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 39);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncerrarCliente
            // 
            this.btncerrarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btncerrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btncerrarCliente.Image")));
            this.btncerrarCliente.ImageActive = null;
            this.btncerrarCliente.Location = new System.Drawing.Point(626, 12);
            this.btncerrarCliente.Name = "btncerrarCliente";
            this.btncerrarCliente.Size = new System.Drawing.Size(29, 32);
            this.btncerrarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrarCliente.TabIndex = 37;
            this.btncerrarCliente.TabStop = false;
            this.btncerrarCliente.Zoom = 10;
            // 
            // lbltelf
            // 
            this.lbltelf.AutoSize = true;
            this.lbltelf.Location = new System.Drawing.Point(418, 86);
            this.lbltelf.Name = "lbltelf";
            this.lbltelf.Size = new System.Drawing.Size(49, 13);
            this.lbltelf.TabIndex = 36;
            this.lbltelf.Text = "Telefono";
            // 
            // lblnomb
            // 
            this.lblnomb.AutoSize = true;
            this.lblnomb.Location = new System.Drawing.Point(228, 86);
            this.lblnomb.Name = "lblnomb";
            this.lblnomb.Size = new System.Drawing.Size(44, 13);
            this.lblnomb.TabIndex = 35;
            this.lblnomb.Text = "Nombre";
            // 
            // lbldirec
            // 
            this.lbldirec.AutoSize = true;
            this.lbldirec.Location = new System.Drawing.Point(418, 126);
            this.lbldirec.Name = "lbldirec";
            this.lbldirec.Size = new System.Drawing.Size(52, 13);
            this.lbldirec.TabIndex = 34;
            this.lbldirec.Text = "Direccion";
            // 
            // lblapell
            // 
            this.lblapell.AutoSize = true;
            this.lblapell.Location = new System.Drawing.Point(228, 130);
            this.lblapell.Name = "lblapell";
            this.lblapell.Size = new System.Drawing.Size(49, 13);
            this.lblapell.TabIndex = 33;
            this.lblapell.Text = "Apellidos";
            // 
            // lblregistro
            // 
            this.lblregistro.AutoSize = true;
            this.lblregistro.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblregistro.Location = new System.Drawing.Point(326, 32);
            this.lblregistro.Name = "lblregistro";
            this.lblregistro.Size = new System.Drawing.Size(231, 22);
            this.lblregistro.TabIndex = 32;
            this.lblregistro.Text = "Registro de Empleados";
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(250, 169);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(107, 20);
            this.txtcontra.TabIndex = 45;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(381, 169);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(107, 20);
            this.txtcorreo.TabIndex = 46;
            // 
            // frmempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 386);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.dgvDatosEm);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btncerrarCliente);
            this.Controls.Add(this.lbltelf);
            this.Controls.Add(this.lblnomb);
            this.Controls.Add(this.lbldirec);
            this.Controls.Add(this.lblapell);
            this.Controls.Add(this.lblregistro);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmempleado";
            this.Text = "frmempleado";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDatos;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.DataGridView dgvDatosEm;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private Bunifu.Framework.UI.BunifuThinButton2 btncancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        private Bunifu.Framework.UI.BunifuImageButton btncerrarCliente;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltelf;
        private Bunifu.Framework.UI.BunifuCustomLabel lblnomb;
        private Bunifu.Framework.UI.BunifuCustomLabel lbldirec;
        private Bunifu.Framework.UI.BunifuCustomLabel lblapell;
        private Bunifu.Framework.UI.BunifuCustomLabel lblregistro;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtcontra;
    }
}