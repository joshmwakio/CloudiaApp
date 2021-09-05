using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarDoc
{
    public partial class UploadForm : System.Windows.Forms.Form
    {
        public UploadForm()
        {
            InitializeComponent();
        }
        WebClient webClient;
        Stopwatch stopwatch = new Stopwatch();

        public void UploadFile(string urlAddress)
        {
            using (webClient=new WebClient())
            {
                webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
                webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                //   Uri url = urlAddress.StartsWith("https://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("https://" + urlAddress);
                Uri uri = new Uri(urlAddress);
                stopwatch.Start();
                try
                {
                    webClient.DownloadFileAsync(uri, (Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads","test.jpg")));
                }
                catch( Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            stopwatch.Reset();
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
           //Console.WriteLine("ch"); 
           Console.WriteLine((e.BytesReceived/1024d/stopwatch.Elapsed.TotalSeconds).ToString("0.00"));
            uploadProgress.ProgressValue = e.ProgressPercentage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        UploadProgress uploadProgress;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            UploadFile("http://www.devbg.org/img/Logo-BASD.jpg");
            //Console.WriteLine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),"Downloads"));
           uploadProgress = new UploadProgress();
            
            flowLayoutPanel1.Controls.Add(uploadProgress);
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            int x = flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1].Location.X;
            int y = flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1].Location.Y;
            flowLayoutPanel1.AutoScrollPosition=new Point(x,flowLayoutPanel1.VerticalScroll.Maximum);
        }

        private void UploadForm_DragDrop(object sender, DragEventArgs e)
        {
            UploadProgress uploadProgress = new UploadProgress();
            flowLayoutPanel1.Controls.Add(uploadProgress);
        }
      
        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            NetworkInterface[] network = NetworkInterface.GetAllNetworkInterfaces();
            string[] st = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            Console.WriteLine(st.Length);
            for(int i=1; i <= st.Length; i++)
            {
                UploadProgress uploadProgress = new UploadProgress();
                uploadProgress.DocName = Path.GetFileName(st[i - 1]);
                flowLayoutPanel1.Controls.Add(uploadProgress);
                Console.WriteLine(network.Length);

                foreach(var nt in network)
                {
                    Console.WriteLine(nt.GetIPv4Statistics().BytesReceived);
                }
                
             }
           
        }

        private void UploadForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
