namespace SISGA
{
    partial class menu
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.transi = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.uc21 = new SISGA.uc2();
            this.us11 = new SISGA.us1();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.btncerrarCliente = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // transi
            // 
            this.transi.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.transi.Cursor = null;
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
            this.transi.DefaultAnimation = animation1;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btncerrarCliente);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.lbl3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuTileButton1);
            this.bunifuGradientPanel1.Controls.Add(this.lbl1);
            this.bunifuGradientPanel1.Controls.Add(this.lbl2);
            this.transi.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Lime;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Green;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(1, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(792, 167);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.transi.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(663, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(42, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 20;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.transi.SetDecoration(this.lbl3, BunifuAnimatorNS.DecorationType.None);
            this.lbl3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(574, 136);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(113, 15);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Desarrolladores";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transi.SetDecoration(this.bunifuTileButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 80;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "";
            this.bunifuTileButton1.Location = new System.Drawing.Point(0, -52);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(220, 182);
            this.bunifuTileButton1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.transi.SetDecoration(this.lbl1, BunifuAnimatorNS.DecorationType.None);
            this.lbl1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(297, 136);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(114, 15);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "¿ Que es SISGA ?";
            this.lbl1.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.transi.SetDecoration(this.lbl2, BunifuAnimatorNS.DecorationType.None);
            this.lbl2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(71, 136);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(62, 15);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Modulos";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.uc21);
            this.bunifuGradientPanel2.Controls.Add(this.us11);
            this.transi.SetDecoration(this.bunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.SpringGreen;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Lime;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.SpringGreen;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(1, 186);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(789, 325);
            this.bunifuGradientPanel2.TabIndex = 4;
            // 
            // uc21
            // 
            this.transi.SetDecoration(this.uc21, BunifuAnimatorNS.DecorationType.None);
            this.uc21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uc21.Location = new System.Drawing.Point(0, 0);
            this.uc21.Name = "uc21";
            this.uc21.Size = new System.Drawing.Size(789, 325);
            this.uc21.TabIndex = 1;
            this.uc21.Visible = false;
            // 
            // us11
            // 
            this.transi.SetDecoration(this.us11, BunifuAnimatorNS.DecorationType.None);
            this.us11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.us11.Location = new System.Drawing.Point(0, 0);
            this.us11.Name = "us11";
            this.us11.Size = new System.Drawing.Size(789, 325);
            this.us11.TabIndex = 0;
            this.us11.Visible = false;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.transi.SetDecoration(this.line, BunifuAnimatorNS.DecorationType.None);
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.line.LineThickness = 3;
            this.line.Location = new System.Drawing.Point(44, 169);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(121, 20);
            this.line.TabIndex = 0;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            this.line.Load += new System.EventHandler(this.line_Load);
            // 
            // btncerrarCliente
            // 
            this.btncerrarCliente.BackColor = System.Drawing.Color.Transparent;
            this.transi.SetDecoration(this.btncerrarCliente, BunifuAnimatorNS.DecorationType.None);
            this.btncerrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btncerrarCliente.Image")));
            this.btncerrarCliente.ImageActive = null;
            this.btncerrarCliente.Location = new System.Drawing.Point(746, 12);
            this.btncerrarCliente.Name = "btncerrarCliente";
            this.btncerrarCliente.Size = new System.Drawing.Size(29, 32);
            this.btncerrarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrarCliente.TabIndex = 21;
            this.btncerrarCliente.TabStop = false;
            this.btncerrarCliente.Zoom = 10;
            this.btncerrarCliente.Click += new System.EventHandler(this.btncerrarCliente_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 511);
            this.Controls.Add(this.line);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.transi.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menu_MouseUp);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrarCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition transi;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl3;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private uc2 uc21;
        private us1 us11;
        private Bunifu.Framework.UI.BunifuImageButton btncerrarCliente;
    }
}