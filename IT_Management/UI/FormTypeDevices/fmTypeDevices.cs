using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Management.UI.FormTypeDevices
{
    public partial class fmTypeDevices : Form
    {
        public fmTypeDevices()
        {
            InitializeComponent();
        }

        private void fmTypeDevices_Load(object sender, EventArgs e)
        {

        }

        private void treeViewTypeDevices_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "DeskTop")
            {
                fmPcDesktop DeskTop = new fmPcDesktop();

                DeskTop.NameDevice = "PC";
                panelTypeDevices.Controls.Clear();
                DeskTop.TopLevel = false;
                panelTypeDevices.Controls.Add(DeskTop);
                //location.FormBorderStyle = FormBorderStyle.None;
                DeskTop.Dock = DockStyle.Fill;
                DeskTop.Show();
            }
            if (e.Node.Text == "LapTop")
            {
                fmPcLaptop LapTop = new fmPcLaptop();
                LapTop.NameDevice = "MT";
                panelTypeDevices.Controls.Clear();
                LapTop.TopLevel = false;
                panelTypeDevices.Controls.Add(LapTop);
                //location.FormBorderStyle = FormBorderStyle.None;
                LapTop.Dock = DockStyle.Fill;
                LapTop.Show();
            }
            if (e.Node.Text == "Ink")
            {
                fmPrinterInk Ink = new fmPrinterInk();

                panelTypeDevices.Controls.Clear();
                Ink.TopLevel = false;
                panelTypeDevices.Controls.Add(Ink);
                //location.FormBorderStyle = FormBorderStyle.None;
                Ink.Dock = DockStyle.Fill;
                Ink.Show();
            }
            if (e.Node.Text == "Laser")
            {
                fmPrinterLaser Laser = new fmPrinterLaser();

                panelTypeDevices.Controls.Clear();
                Laser.TopLevel = false;
                panelTypeDevices.Controls.Add(Laser);
                //location.FormBorderStyle = FormBorderStyle.None;
                Laser.Dock = DockStyle.Fill;
                Laser.Show();
            }
            if (e.Node.Text == "PhotoCopy")
            {
                fmPrinterPhotoCopy PhotoCopy = new fmPrinterPhotoCopy();

                panelTypeDevices.Controls.Clear();
                PhotoCopy.TopLevel = false;
                panelTypeDevices.Controls.Add(PhotoCopy);
                //location.FormBorderStyle = FormBorderStyle.None;
                PhotoCopy.Dock = DockStyle.Fill;
                PhotoCopy.Show();
            }
            if (e.Node.Text == "PDA 1D")
            {
                fmPDA1D pda1D = new fmPDA1D();

                panelTypeDevices.Controls.Clear();
                pda1D.TopLevel = false;
                panelTypeDevices.Controls.Add(pda1D);
                //location.FormBorderStyle = FormBorderStyle.None;
                pda1D.Dock = DockStyle.Fill;
                pda1D.Show();
            }
            if (e.Node.Text == "PDA 2D")
            {
                fmPDA2D pda2D = new fmPDA2D();

                panelTypeDevices.Controls.Clear();
                pda2D.TopLevel = false;
                panelTypeDevices.Controls.Add(pda2D);
                //location.FormBorderStyle = FormBorderStyle.None;
                pda2D.Dock = DockStyle.Fill;
                pda2D.Show();
            }

            if (e.Node.Text == "Scanner 1D")
            {
                fmScanner1D sc1D = new fmScanner1D();

                panelTypeDevices.Controls.Clear();
                sc1D.TopLevel = false;
                panelTypeDevices.Controls.Add(sc1D);
                //location.FormBorderStyle = FormBorderStyle.None;
                sc1D.Dock = DockStyle.Fill;
                sc1D.Show();
            }

            if (e.Node.Text == "Scanner 2D")
            {
                fmBarScanner2D sc2D = new fmBarScanner2D();

                panelTypeDevices.Controls.Clear();
                sc2D.TopLevel = false;
                panelTypeDevices.Controls.Add(sc2D);
                //location.FormBorderStyle = FormBorderStyle.None;
                sc2D.Dock = DockStyle.Fill;
                sc2D.Show();
            }

            if (e.Node.Text == "Scanner Wifi 2D")
            {
                fmBarScannerWifi2D scWifi2D = new fmBarScannerWifi2D();

                panelTypeDevices.Controls.Clear();
                scWifi2D.TopLevel = false;
                panelTypeDevices.Controls.Add(scWifi2D);
                //location.FormBorderStyle = FormBorderStyle.None;
                scWifi2D.Dock = DockStyle.Fill;
                scWifi2D.Show();
            }
            if (e.Node.Text == "Barcode Printer") {
                fmBarcodePrinter barPrinter= new fmBarcodePrinter();

                panelTypeDevices.Controls.Clear();
                barPrinter.TopLevel = false;
                panelTypeDevices.Controls.Add(barPrinter);
                barPrinter.Dock = DockStyle.Fill;
                barPrinter.Show();
            }
        }

        private void fmTypeDevices_Leave(object sender, EventArgs e)
        {
            this.Hide();
            new FormStart().ShowDialog();
        }
    }
}
