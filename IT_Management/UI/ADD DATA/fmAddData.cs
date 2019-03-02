using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Management.UI.ADD_DATA
{
    public partial class fmAddData : Form
    {
        public fmAddData()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Location")
            {
                fmLocation location = new fmLocation();

                pnData.Controls.Clear();
                location.TopLevel = false;
                pnData.Controls.Add(location);
                //location.FormBorderStyle = FormBorderStyle.None;
                location.Dock = DockStyle.Fill;
                location.Show();
            }

            if (e.Node.Text == "Factory")
            {
                fmFactory factory = new fmFactory();

                pnData.Controls.Clear();
                factory.TopLevel = false;
                pnData.Controls.Add(factory);
                //location.FormBorderStyle = FormBorderStyle.None;
                factory.Dock = DockStyle.Fill;
                factory.Show();
            }

            if (e.Node.Text == "Part")
            {
                fmPart part = new fmPart();

                pnData.Controls.Clear();
                part.TopLevel = false;
                pnData.Controls.Add(part);
                //location.FormBorderStyle = FormBorderStyle.None;
                part.Dock = DockStyle.Fill;
                part.Show();
            }

            if (e.Node.Text == "Factory")
            {
                fmFactory factory = new fmFactory();

                pnData.Controls.Clear();
                factory.TopLevel = false;
                pnData.Controls.Add(factory);
                //location.FormBorderStyle = FormBorderStyle.None;
                factory.Dock = DockStyle.Fill;
                factory.Show();
            }

            if (e.Node.Text == "Factory")
            {
                fmFactory factory = new fmFactory();

                pnData.Controls.Clear();
                factory.TopLevel = false;
                pnData.Controls.Add(factory);
                //location.FormBorderStyle = FormBorderStyle.None;
                factory.Dock = DockStyle.Fill;
                factory.Show();
            }

            if (e.Node.Text == "Factory")
            {
                fmFactory factory = new fmFactory();

                pnData.Controls.Clear();
                factory.TopLevel = false;
                pnData.Controls.Add(factory);
                //location.FormBorderStyle = FormBorderStyle.None;
                factory.Dock = DockStyle.Fill;
                factory.Show();
            }
        }

        private void fmAddData_Load(object sender, EventArgs e)
        {

        }
    }
}
