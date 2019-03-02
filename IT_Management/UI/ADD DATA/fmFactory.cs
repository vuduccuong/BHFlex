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
    public partial class fmFactory : Form
    {
        public fmFactory()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fmFactory_Load(object sender, EventArgs e)
        {
            txtID.Hide();
            btnSave.Hide();
            txtFactoryName.Enabled = false;
            cbbListLocation.Enabled = false;
            LoadListLocation();
            LoadListFactory();
        }

        private void LoadListFactory()
        {
            var lstFactory = FactoryDAO.Instance.GetListFactory();
            if (lstFactory.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
            }
            else
            {
                dtgListFactory.DataSource = lstFactory;

                this.cbbListLocation.DataBindings.Clear();
                this.cbbListLocation.DataBindings.Add(new Binding("Text", lstFactory, "LocationName", true));

                this.txtFactoryName.DataBindings.Clear();
                this.txtFactoryName.DataBindings.Add(new Binding("Text", lstFactory, "FactoryName", true));


                this.txtID.DataBindings.Clear();
                this.txtID.DataBindings.Add(new Binding("Text", lstFactory, "Id", true));
            }
        }

        private void LoadListLocation()
        {
            List<Location> lstLocation = LocationDAO.Instance.GetListCustommer();
            if (lstLocation.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
            }

            cbbListLocation.DataSource = lstLocation;
            cbbListLocation.DisplayMember = "LocationName";
            cbbListLocation.ValueMember = "Id";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.btnAdd.Enabled = false;
            txtFactoryName.Enabled = true;
            cbbListLocation.Enabled = true;
            txtFactoryName.Focus();
            txtFactoryName.Text = null;
            btnSave.Text = "Save";
            btnSave.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.btnSave.Hide();
            txtFactoryName.Enabled = false;
            cbbListLocation.Enabled = false;
            var nameFactory = txtFactoryName.Text.Trim().ToString();
            string idLocation = cbbListLocation.SelectedValue.ToString();
            this.btnAdd.Enabled = true;
            var idFactory = txtID.Text;
            if (btnSave.Text == "Save")
            {
                AddFactory(idLocation, nameFactory);
            }

            if (btnSave.Text == "Update")
            {
                this.btnEdit.Enabled = true;
                UpdateFactory(idFactory,idLocation, nameFactory);
            }
        }

        private void UpdateFactory(string idFactory, string idLocation, string nameFactory)
        {
            var checkStatus = FactoryDAO.Instance.UpdateFactory(idFactory, idLocation, nameFactory);
            if (checkStatus > 0)
            {
                MessageBox.Show("Success!");
                LoadListFactory();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void AddFactory(string idLocation, string nameFactory)
        {
            var checkStatus = FactoryDAO.Instance.CreateNewFactory(idLocation, nameFactory);
            if (checkStatus > 0)
            {
                MessageBox.Show("Success!");
                LoadListFactory();
            }
            else
            MessageBox.Show("Error!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = false;
            cbbListLocation.Enabled = true;
            txtFactoryName.Enabled = true;
            this.btnSave.Text = "Update";
            this.btnSave.Show();
        }
    }
}
