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
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            bunifuPanel1.BackgroundColor = colorDialog1.Color;
            bunifuProgressBar1.ProgressColorLeft = colorDialog1.Color;

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            bunifuPanel2.BackgroundColor = colorDialog1.Color;
            bunifuProgressBar1.ProgressColorRight = colorDialog1.Color;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // bunifuProgressBar1.TransitionValue(100,1500);
           

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
            if (bunifuProgressBar1.InvokeRequired)
            {
                bunifuProgressBar1.Invoke(new Action(() =>
                {
                    bunifuProgressBar1.TransitionValue(100, 1500);
                   
                }));

            }
           

        }

        private async void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            await Task.Delay(1600);
            bunifuProgressBar1.TransitionValue(20, 1500);
            //bunifuProgressBar1.TransitionValue(20, 600);
            await Task.Delay(1600);
            backgroundWorker1.RunWorkerAsync();

        }
    }
}
