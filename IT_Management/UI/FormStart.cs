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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            fmAddData a = new fmAddData();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // this.Hide();
            new fmTypeDevices().ShowDialog();
        }
    }
}
