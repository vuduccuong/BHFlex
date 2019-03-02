using IT_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT_Management.DAO;

namespace IT_Management.UI.ADD_DATA
{
    public partial class fmLocation : Form
    {
        public fmLocation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtLocationCode.Enabled = true;
            txtLocationName.Enabled = true;
            txtLocationName.Text = "";
            txtLocationCode.Text = "";
            btnSave.Text = "Save";
            btnSave.Show();
            this.btnAdd.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fmLocation_Load(object sender, EventArgs e)
        {
            txtID.Hide();
            btnSave.Hide();
            txtLocationName.Enabled = false;
            txtLocationCode.Enabled = false;
            LoadListLocation();
        }

        private void LoadListLocation()
        {
            List<Location> lstLocation = LocationDAO.Instance.GetListCustommer();
            if (lstLocation.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
            }
            dtgLocation.DataSource = lstLocation;

            this.txtLocationName.DataBindings.Clear();
            this.txtLocationName.DataBindings.Add(new Binding("Text", lstLocation, "LocationName", true));

            this.txtID.DataBindings.Clear();
            this.txtID.DataBindings.Add(new Binding("Text", lstLocation, "Id", true));


            this.txtLocationCode.DataBindings.Clear();
            this.txtLocationCode.DataBindings.Add(new Binding("Text", lstLocation, "LocationCode", true));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.btnSave.Hide();
            txtLocationCode.Enabled = false;
            txtLocationName.Enabled = false;
            var nameLocation = txtLocationName.Text.Trim().ToString();
            var codeLocation = txtLocationCode.Text.Trim().ToString();
            var id = txtID.Text;
            this.btnEdit.Enabled = true;
            this.btnAdd.Enabled = true;
            if (btnSave.Text == "Save")
            {
                AddLocation(nameLocation, codeLocation);
            }

            if (btnSave.Text == "Update")
            {
                UpdateLocation(id, nameLocation, codeLocation);
            }
        }

        private void UpdateLocation(string id, string nameLocation, string codeLocation)
        {
            int checkStatus = LocationDAO.Instance.UpdateLocation(id, nameLocation, codeLocation);
            if (checkStatus > 0)
            {
                MessageBox.Show("Success!");
                LoadListLocation();
            }
            else
            {
                MessageBox.Show("Error!");
                txtLocationName.Focus();
            }
        }

        private void AddLocation(string nameLocation, string codeLocation)
        {
            var checkStatus = LocationDAO.Instance.CreateNewLocation(nameLocation, codeLocation);
            if (checkStatus >0)
            {
                MessageBox.Show("Success!");
                this.btnSave.Hide();
                LoadListLocation();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLocationName.Text) || !string.IsNullOrEmpty(txtLocationCode.Text))
            {
                this.Enabled = false;
                txtLocationCode.Enabled = true;
                txtLocationName.Enabled = true;
                btnSave.Text = "Update";
                btnSave.Show();
            }
        }
    }
}
