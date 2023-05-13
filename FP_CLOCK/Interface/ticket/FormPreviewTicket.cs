using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace FPClient.Interface.ticket
{
    public partial class FormPreviewTicket : Form
    {
        private string name;
        private int cntAD = 0, cntCH = 0;
        private string duringDate;
        public FormPreviewTicket()
        {
            InitializeComponent();
        }

        public FormPreviewTicket(string strName, int cntAD, int cntCH, string strDate)
        {
            InitializeComponent();
            this.name = strName;
            this.cntAD = cntAD;
            this.cntCH = cntCH;
            this.duringDate = strDate;

            this.label_name.Text = this.name;
            this.label_cntAD.Text = this.cntAD.ToString();
            this.label_cntCH.Text = this.cntCH.ToString();
            this.label_during.Text = this.duringDate;
            this.GenerateQRCode();
        }

        public void GenerateQRCode()
        {
            string data = "name: " + this.name + ", count:" + (this.cntAD + this.cntCH).ToString(); // Replace with the data you want to encode in the QR code
            int size = this.pictureBox2.Size.Width; // Replace with the size of the QR code image you want to generate

            string url = string.Format("https://chart.googleapis.com/chart?cht=qr&chs={0}x{0}&chl={1}", size, data);

            using (WebClient client = new WebClient())
            {
                byte[] imageBytes = client.DownloadData(url);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    this.pictureBox2.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
