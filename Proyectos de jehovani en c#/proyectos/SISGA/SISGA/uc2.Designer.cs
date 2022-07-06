namespace SISGA
{
    partial class uc2
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc2));
            this.animate = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton7 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton8 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton9 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton10 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton11 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton12 = new Bunifu.Framework.UI.BunifuTileButton();
            this.animacion = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // animate
            // 
            this.animate.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.animate.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animate.DefaultAnimation = animation1;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Lime;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate.SetDecoration(this.bunifuTileButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.Green;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Cliente";
            this.bunifuTileButton1.Location = new System.Drawing.Point(18, 6);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(128, 123);
            this.bunifuTileButton1.TabIndex = 0;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.Lime;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate.SetDecoration(this.bunifuTileButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.Green;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "Ventas";
            this.bunifuTileButton2.Location = new System.Drawing.Point(129, 133);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(128, 123);
            this.bunifuTileButton2.TabIndex = 1;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton3.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.Lime;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate.SetDecoration(this.bunifuTileButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.Green;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "Provedor";
            this.bunifuTileButton3.Location = new System.Drawing.Point(129, 6);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(128, 123);
            this.bunifuTileButton3.TabIndex = 2;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton4.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.Lime;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate.SetDecoration(this.bunifuTileButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.Green;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 20;
            this.bunifuTileButton4.ImageZoom = 50;
            this.bunifuTileButton4.LabelPosition = 41;
            this.bunifuTileButton4.LabelText = "Produccion";
            this.bunifuTileButton4.Location = new System.Drawing.Point(18, 133);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(128, 123);
            this.bunifuTileButton4.TabIndex = 3;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // bunifuTileButton5
            // 
            this.bunifuTileButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton5.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton5.colorActive = System.Drawing.Color.Lime;
            this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate.SetDecoration(this.bunifuTileButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton5.ForeColor = System.Drawing.Color.Green;
            this.bunifuTileButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton5.Image")));
            this.bunifuTileButton5.ImagePosition = 20;
            this.bunifuTileButton5.ImageZoom = 50;
            this.bunifuTileButton5.LabelPosition = 41;
            this.bunifuTileButton5.LabelText = "Semilla";
            this.bunifuTileButton5.Location = new System.Drawing.Point(252, 6);
            this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton5.Name = "bunifuTileButton5";
            this.bunifuTileButton5.Size = new System.Drawing.Size(128, 123);
            this.bunifuTileButton5.TabIndex = 4;
            this.bunifuTileButton5.Click += new System.EventHandler(this.bunifuTileButton5_Click);
            // 
            // bunifuTileButton6
            // 
            this.bunifuTileButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton6.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton6.colorActive = System.Drawing.Color.Lime;
            this.bunifuTileButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate.SetDecoration(this.bunifuTileButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton6.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton6.ForeColor = System.Drawing.Color.Green;
            this.bunifuTileButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton6.Image")));
            this.bunifuTileButton6.ImagePosition = 20;
            this.bunifuTileButton6.ImageZoom = 50;
            this.bunifuTileButton6.LabelPosition = 41;
            this.bunifuTileButton6.LabelText = "ControlPla";
            this.bunifuTileButton6.Location = new System.Drawing.Point(252, 133);
            this.bunifuTileButton6.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton6.Name = "bunifuTileButton6";
            this.bunifuTileButton6.Size = new System.Drawing.Size(128, 123);
            this.bunifuTileButton6.TabIndex = 5;
            this.bunifuTileButton6.Click += new System.EventHandler(this.bunifuTileButton6_Click);
            // 
            // bunifuTileButton7
            // 
            this.bunifuTileButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton7.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton7.colorActive = System.Drawing.Color.Lime;
            this.bunifuTileButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate.SetDecoration(this.bunifuTileButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton7.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton7.ForeColor = System.Drawing.Color.Green;
            this.bunifuTileButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton7.Image")));
            this.bunifuTileButton7.ImagePosition = 20;
            this.bunifuTileButton7.ImageZoom = 50;
            this.bunifuTileButton7.LabelPosition = 41;
            this.bunifuTileButton7.LabelText = "Bodega";
            this.bunifuTileButton7.Location = new System.Drawing.Point(392, 6);
            this.bunifuTileButton7.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton7.Name = "bunifuTileButton7";
            this.bunifuTileButton7.Size = new System.Drawing.Size(128, 123);
            this.bunifuTileButton7.TabIndex = 6;
            this.bunifuTileButton7.Click += new System.EventHandler(this.bunifuTileButton7_Click);
            // 
            // bunifuTileButton8
            // 
            this.bunifuTileButton8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton8.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton8.colorActive = System.Drawing.Color.Lime;
            this.bunifuTileButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate.SetDecoration(this.bunifuTileButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton8.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton8.ForeColor = System.Drawing.Color.Green;
            this.bunifuTileButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton8.Image")));
            this.bunifuTileButton8.ImagePosition = 20;
            this.bunifuTileButton8.ImageZoom = 50;
            this.bunifuTileButton8.LabelPosition = 41;
            this.bunifuTileButton8.LabelText = "Maquinaria";
            this.bunifuTileButton8.Location = new System.Drawing.Point(392, 133);
            this.bunifuTileButton8.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton8.Name = "bunifuTileButton8";
            this.bunifuTileButton8.Size = new System.Drawing.Size(128, 123);
            this.bunifuTileButton8.TabIndex = 7;
            this.bunifuTileButton8.Click += new System.EventHandler(this.bunifuTileButton8_Click);
            // 
            // bunifuTileButton9
            // 
            this.bunifuTileButton9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton9.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton9.colorActive = System.Drawing.Color.Lime;
            this.bunifuTileButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate.SetDecoration(this.bunifuTileButton9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton9.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton9.ForeColor = System.Drawing.Color.Green;
            this.bunifuTileButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton9.Image")));
            this.bunifuTileButton9.ImagePosition = 20;
            this.bunifuTileButton9.ImageZoom = 50;
            this.bunifuTileButton9.LabelPosition = 41;
            this.bunifuTileButton9.LabelText = "Campaña de Cultivo";
            this.bunifuTileButton9.Location = new System.Drawing.Point(532, 6);
            this.bunifuTileButton9.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton9.Name = "bunifuTileButton9";
            this.bunifuTileButton9.Size = new System.Drawing.Size(128, 123);
            this.bunifuTileButton9.TabIndex = 8;
            this.bunifuTileButton9.Click += new System.EventHandler(this.bunifuTileButton9_Click);
            // 
            // bunifuTileButton10
            // 
            this.bunifuTileButton10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton10.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton10.colorActive = System.Drawing.Color.Lime;
            this.bunifuTileButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate.SetDecoration(this.bunifuTileButton10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton10.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton10.ForeColor = System.Drawing.Color.Green;
            this.bunifuTileButton10.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton10.Image")));
            this.bunifuTileButton10.ImagePosition = 20;
            this.bunifuTileButton10.ImageZoom = 50;
            this.bunifuTileButton10.LabelPosition = 41;
            this.bunifuTileButton10.LabelText = "Compra";
            this.bunifuTileButton10.Location = new System.Drawing.Point(532, 133);
            this.bunifuTileButton10.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton10.Name = "bunifuTileButton10";
            this.bunifuTileButton10.Size = new System.Drawing.Size(128, 123);
            this.bunifuTileButton10.TabIndex = 9;
            this.bunifuTileButton10.Click += new System.EventHandler(this.bunifuTileButton10_Click);
            // 
            // bunifuTileButton11
            // 
            this.bunifuTileButton11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton11.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton11.colorActive = System.Drawing.Color.Lime;
            this.bunifuTileButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate.SetDecoration(this.bunifuTileButton11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton11.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton11.ForeColor = System.Drawing.Color.Green;
            this.bunifuTileButton11.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton11.Image")));
            this.bunifuTileButton11.ImagePosition = 20;
            this.bunifuTileButton11.ImageZoom = 50;
            this.bunifuTileButton11.LabelPosition = 41;
            this.bunifuTileButton11.LabelText = "Empleado";
            this.bunifuTileButton11.Location = new System.Drawing.Point(673, 133);
            this.bunifuTileButton11.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton11.Name = "bunifuTileButton11";
            this.bunifuTileButton11.Size = new System.Drawing.Size(128, 123);
            this.bunifuTileButton11.TabIndex = 11;
            this.bunifuTileButton11.Click += new System.EventHandler(this.bunifuTileButton11_Click);
            // 
            // bunifuTileButton12
            // 
            this.bunifuTileButton12.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton12.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton12.colorActive = System.Drawing.Color.Lime;
            this.bunifuTileButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate.SetDecoration(this.bunifuTileButton12, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton12.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton12.ForeColor = System.Drawing.Color.Green;
            this.bunifuTileButton12.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton12.Image")));
            this.bunifuTileButton12.ImagePosition = 20;
            this.bunifuTileButton12.ImageZoom = 50;
            this.bunifuTileButton12.LabelPosition = 41;
            this.bunifuTileButton12.LabelText = "Producto";
            this.bunifuTileButton12.Location = new System.Drawing.Point(673, 6);
            this.bunifuTileButton12.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton12.Name = "bunifuTileButton12";
            this.bunifuTileButton12.Size = new System.Drawing.Size(128, 123);
            this.bunifuTileButton12.TabIndex = 10;
            this.bunifuTileButton12.Click += new System.EventHandler(this.bunifuTileButton12_Click);
            // 
            // animacion
            // 
            this.animacion.Interval = 1000;
            this.animacion.Tick += new System.EventHandler(this.animacion_Tick);
            // 
            // uc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuTileButton11);
            this.Controls.Add(this.bunifuTileButton12);
            this.Controls.Add(this.bunifuTileButton10);
            this.Controls.Add(this.bunifuTileButton9);
            this.Controls.Add(this.bunifuTileButton8);
            this.Controls.Add(this.bunifuTileButton7);
            this.Controls.Add(this.bunifuTileButton6);
            this.Controls.Add(this.bunifuTileButton5);
            this.Controls.Add(this.bunifuTileButton4);
            this.Controls.Add(this.bunifuTileButton3);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.bunifuTileButton1);
            this.animate.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "uc2";
            this.Size = new System.Drawing.Size(822, 262);
            this.Load += new System.EventHandler(this.uc2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition animate;
        private System.Windows.Forms.Timer animacion;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton6;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton7;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton8;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton9;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton10;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton11;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton12;
    }
}
