using IT_Management.UI.ADD_DATA;
using IT_Management.UI.FormTypeDevices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace IT_Management.UI
{
    public partial class fmStart : Form
    {
        public fmStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            fmAddData a = new fmAddData();
            a.ShowDialog();
            btnShow1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // this.Hide();
            new fmTypeDevices().ShowDialog();
            btnShow2.Show();
        }

        private void fmStart_Load(object sender, EventArgs e)
        {
            btnShow1.Hide();
            btnShow2.Hide();
            button1.Hide();
            button2.Hide();
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            fmAddData a = new fmAddData();
            a.ShowDialog();
            btnShow1.Hide();
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            new fmTypeDevices().ShowDialog();
            btnShow2.Hide();
        }
        private void fmStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != System.Windows.Forms.DialogResult.OK)
            {
                
            }
        }
        int x = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            if (x == 4) {
                timer1.Stop();
                pictureBox1.Hide();
                button1.Show();
                button2.Show();
            }
            
            
        }
        int i;
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            i = label1.Location.X;
            i--;
            if (i > 0)
            {
                label1.Location = new Point(i, label1.Location.Y);
                timer3.Start();
            }
            else
                timer2.Stop();
                timer3.Start();
        }
        private void ranDomColor() {
            var rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            label1.ForeColor = Color.FromArgb(A, R, G, B);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            ranDomColor();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
