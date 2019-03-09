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
using IT_Management.DTO;

namespace IT_Management.UI.ADD_DATA
{
    public partial class fmPart : Form
    {
        public fmPart()
        {
            InitializeComponent();
        }

        private void fmPart_Load(object sender, EventArgs e)
        {
            btnSave.Hide();
            cbbListLocation.Enabled = false;
            cbbListFactory.Enabled = false;
            txtPartName.Enabled = false;
            txtID.Hide();

            LoadListPart();

            LoadListLocation();
            
        }

        private void LoadListFactory(string idLocation)
        {
            cbbListFactory.DataSource = null;
            List<Factory> lstFactory = FactoryDAO.Instance.GetListFactoryByLocation(idLocation);
            
                cbbListFactory.DataSource = lstFactory;
                cbbListFactory.DisplayMember = "FactoryName";
                cbbListFactory.ValueMember = "Id";
        }

        private void LoadListLocation()
        {
            List<Location> lstLocation = LocationDAO.Instance.GetListCustommer();
            if (lstLocation.Count == 0)
            {
                MessageBox.Show("No data in Location!");
            }

            cbbListLocation.DataSource = lstLocation;
            cbbListLocation.DisplayMember = "LocationName";
            cbbListLocation.ValueMember = "Id";
        }

        private void LoadListPart()
        {
            List<Part> lstPart = PartDAO.Instance.GetListPart();
            if (lstPart.Count == 0)
            {
                MessageBox.Show("No data in Part");
            }
            else { 
            dtgPart.DataSource = lstPart;

            this.txtPartName.DataBindings.Clear();
            this.txtPartName.DataBindings.Add(new Binding("Text", lstPart, "PartName", true));

            this.txtID.DataBindings.Clear();
            this.txtID.DataBindings.Add(new Binding("Text", lstPart, "Id", true));


            this.cbbListLocation.DataBindings.Clear();
            this.cbbListLocation.DataBindings.Add(new Binding("Text", lstPart, "LocationName",true));

            this.cbbListFactory.DataBindings.Clear();
            this.cbbListFactory.DataBindings.Add(new Binding("Text", lstPart, "FactoryName", true));

            }
        }

        private void cbbListLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var location = this.cbbListLocation.SelectedValue.ToString();
            LoadListFactory(location);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbbListLocation.Enabled = true;
            cbbListFactory.Enabled = true;
            txtPartName.Enabled = true;
            txtPartName.Text = null;
            btnSave.Text = "Save";
            btnSave.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.btnSave.Hide();
            cbbListLocation.Enabled = false;
            cbbListFactory.Enabled = false;
            txtPartName.Enabled = false;
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            var idLocation = this.cbbListLocation.SelectedValue.ToString();
            var idFactory = this.cbbListFactory.SelectedValue.ToString();
            var idPart = txtID.Text;
            var namePart = txtPartName.Text;
            if (btnSave.Text == "Save")
            {
                AddPart(namePart, idFactory);
            }

            if (btnSave.Text == "Update")
            {
                UpdatePart(idPart,idFactory,namePart);
            }
        }

        private void UpdatePart(string idPart,string idFactory,string namePart)
        {
            var checkStatus = PartDAO.Instance.UpdatePart(idPart, idFactory, namePart);
            if (checkStatus > 0)
            {
                MessageBox.Show("Success!");
                LoadListPart();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void AddPart(string namePart, string idFactory)
        {
            var checkStatus = PartDAO.Instance.CreateNewPart(namePart, idFactory);
            if (checkStatus > 0)
            {
                MessageBox.Show("Success!");
                LoadListPart();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = false;
            this.btnSave.Text = "Update";
            this.cbbListLocation.Enabled = true;
            this.cbbListFactory.Enabled = true;
            this.txtPartName.Enabled = true;
            this.btnSave.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
