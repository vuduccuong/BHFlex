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
    }
}
