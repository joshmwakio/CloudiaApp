using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarDoc
{
    public partial class UploadProgress : UserControl
    {
        private int progressValue;
        public string  DocName { get; set; }
        public string UploadSpeed { get; set; }

        public int ProgressValue
        {
            get { return progressValue; }
            set {
                progressValue = value;
                bunifuProgressBar1.ValueByTransition = progressValue;
            }
        }

        public UploadProgress()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UploadProgress_Load(object sender, EventArgs e)
        {
            timer1.Start();
           bunifuProgressBar1.TransitionValue(100, 1500);
            docNameBunifuLabel.Text = DocName;
        }

        private void bunifuProgressBar1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuProgressBar.ProgressChangedEventArgs e)
        {
            if (e.ProgressValue == 100)
            {
                statusPictureBox.Image = imageList1.Images[1];
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int speed = random.Next(100, 150);
            speedBunifuLabel.Text = string.Format("{0} kb/s", speed);
        }
    }
}
