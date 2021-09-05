using Bunifu.UI.WinForms;
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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instatiate bunifu progress bar
            BunifuProgressBar bunifuProgressBar = new BunifuProgressBar();
            //set a value for the progress bar
            bunifuProgressBar.Value = 80;
            //set the location of the progress bar on the form
            bunifuProgressBar.Location = new Point(180, 165);
            //set the orientation of the progress bar
            bunifuProgressBar.Orientation = Orientation.Horizontal;
            //add the progress bar to the form
            this.Controls.Add(bunifuProgressBar);
        }
    }
}
