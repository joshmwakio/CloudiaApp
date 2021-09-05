
namespace ProgressBarDoc
{
    partial class UploadProgress
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadProgress));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.docNameBunifuLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.statusPictureBox = new System.Windows.Forms.PictureBox();
            this.speedBunifuLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuProgressBar1 = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.docNameBunifuLabel);
            this.panel1.Controls.Add(this.statusPictureBox);
            this.panel1.Controls.Add(this.bunifuProgressBar1);
            this.panel1.Controls.Add(this.speedBunifuLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 76);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // docNameBunifuLabel
            // 
            this.docNameBunifuLabel.AllowParentOverrides = false;
            this.docNameBunifuLabel.AutoEllipsis = false;
            this.docNameBunifuLabel.CursorType = null;
            this.docNameBunifuLabel.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.docNameBunifuLabel.ForeColor = System.Drawing.Color.Black;
            this.docNameBunifuLabel.Location = new System.Drawing.Point(71, 25);
            this.docNameBunifuLabel.Name = "docNameBunifuLabel";
            this.docNameBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.docNameBunifuLabel.Size = new System.Drawing.Size(80, 13);
            this.docNameBunifuLabel.TabIndex = 5;
            this.docNameBunifuLabel.Text = "Document_0001";
            this.docNameBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.docNameBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // statusPictureBox
            // 
            this.statusPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("statusPictureBox.Image")));
            this.statusPictureBox.Location = new System.Drawing.Point(412, 45);
            this.statusPictureBox.Name = "statusPictureBox";
            this.statusPictureBox.Size = new System.Drawing.Size(24, 19);
            this.statusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusPictureBox.TabIndex = 8;
            this.statusPictureBox.TabStop = false;
            // 
            // speedBunifuLabel
            // 
            this.speedBunifuLabel.AllowParentOverrides = false;
            this.speedBunifuLabel.AutoEllipsis = false;
            this.speedBunifuLabel.CursorType = null;
            this.speedBunifuLabel.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.speedBunifuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.speedBunifuLabel.Location = new System.Drawing.Point(345, 25);
            this.speedBunifuLabel.Name = "speedBunifuLabel";
            this.speedBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.speedBunifuLabel.Size = new System.Drawing.Size(45, 13);
            this.speedBunifuLabel.TabIndex = 7;
            this.speedBunifuLabel.Text = "356 kbps";
            this.speedBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.speedBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_cancel_52px.png");
            this.imageList1.Images.SetKeyName(1, "icons8_checked_48px.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.AllowAnimations = false;
            this.bunifuProgressBar1.Animation = 0;
            this.bunifuProgressBar1.AnimationSpeed = 220;
            this.bunifuProgressBar1.AnimationStep = 10;
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.bunifuProgressBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuProgressBar1.BackgroundImage")));
            this.bunifuProgressBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.bunifuProgressBar1.BorderRadius = 1;
            this.bunifuProgressBar1.BorderThickness = 2;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(71, 46);
            this.bunifuProgressBar1.Maximum = 100;
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Minimum = 1;
            this.bunifuProgressBar1.MinimumValue = 1;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.bunifuProgressBar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.bunifuProgressBar1.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(84)))), ((int)(((byte)(226)))));
            this.bunifuProgressBar1.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(172)))), ((int)(((byte)(134)))));
            this.bunifuProgressBar1.Size = new System.Drawing.Size(330, 16);
            this.bunifuProgressBar1.TabIndex = 6;
            this.bunifuProgressBar1.Value = 2;
            this.bunifuProgressBar1.ValueByTransition = 2;
            this.bunifuProgressBar1.ProgressChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuProgressBar.ProgressChangedEventArgs>(this.bunifuProgressBar1_ProgressChanged);
            // 
            // UploadProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UploadProgress";
            this.Size = new System.Drawing.Size(445, 76);
            this.Load += new System.EventHandler(this.UploadProgress_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuLabel docNameBunifuLabel;
        private System.Windows.Forms.PictureBox statusPictureBox;
        private Bunifu.UI.WinForms.BunifuLabel speedBunifuLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuProgressBar bunifuProgressBar1;
    }
}
