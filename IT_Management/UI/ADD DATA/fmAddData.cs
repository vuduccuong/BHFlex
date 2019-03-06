﻿using System;
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

            if (e.Node.Text == "Partment")
            {
                fmPartment partment = new fmPartment();

                pnData.Controls.Clear();
                partment.TopLevel = false;
                pnData.Controls.Add(partment);
                //location.FormBorderStyle = FormBorderStyle.None;
                partment.Dock = DockStyle.Fill;
                partment.Show();
            }

            if (e.Node.Text == "DeviceType")
            {
                fmDevice device = new fmDevice();

                pnData.Controls.Clear();
                device.TopLevel = false;
                pnData.Controls.Add(device);
                //location.FormBorderStyle = FormBorderStyle.None;
                device.Dock = DockStyle.Fill;
                device.Show();
            }
        }

        private void fmAddData_Load(object sender, EventArgs e)
        {

        }

        private void fmAddData_Leave(object sender, EventArgs e)
        {
            this.Hide();
            new FormStart().ShowDialog();
        }
    }
}
