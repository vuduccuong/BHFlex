using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace IT_Management.UI
{
    public partial class fmBarcode : Form
    {
        public fmBarcode()
        {
            InitializeComponent();
        }

        private void fmBarcode_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
            Size size = new Size(100, 80);
            //pictureBox1.Size = size;
            //CodeQrBarcodeDraw barcode = BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = barcode.Draw(textBox1.Text, 250);
        }
    }
}
