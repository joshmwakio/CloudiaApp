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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // set the initial value of the progress bar
            //bunifuProgressBar1.Value = 0;
            // set the actual value with time taken to transition to the value
            /*
             * First parameter is the progress value
             * Second parameter is time in milliseconds
             */
           // bunifuProgressBar1.TransitionValue(92, 1500);
            
        }
    }
}
