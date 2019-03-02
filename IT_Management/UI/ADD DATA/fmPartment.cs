using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.Editors.DateTimeAdv;
using IT_Management.DAO;
using IT_Management.DTO;

namespace IT_Management.UI.ADD_DATA
{
    public partial class fmPartment : Form
    {
        public fmPartment()
        {
            InitializeComponent();
        }

        private void fmPartment_Load(object sender, EventArgs e)
        {
            btnSave.Hide();
            this.txtID.Hide();
            this.cbbListLocation.Enabled = false;
            this.cbbListFactory.Enabled = false;
            this.cbbListPart.Enabled = false;

            LoadLocation();
            //LoadFactory();
            //LoadPart();
            LoadListPartment();
        }

        private void LoadListPartment()
        {
            List<Partment> lstPartment = PartmentDAO.Instance.GetListPartment();
            if (lstPartment.Count == 0)
            {
                MessageBox.Show("No data in Location!");
            }
            else
            {
                dtgPartment.DataSource = lstPartment;

                this.cbbListLocation.DataBindings.Clear();
                this.cbbListLocation.DataBindings.Add(new Binding("Text", lstPartment, "LocationName", true));

                this.cbbListFactory.DataBindings.Clear();
                this.cbbListFactory.DataBindings.Add(new Binding("Text", lstPartment, "FactoryName", true));

                this.cbbListPart.DataBindings.Clear();
                this.cbbListPart.DataBindings.Add(new Binding("Text", lstPartment, "PartName", true));


                this.txtPartmentName.DataBindings.Clear();
                this.txtPartmentName.DataBindings.Add(new Binding("Text", lstPartment, "PartmentName", true));


                this.txtID.DataBindings.Clear();
                this.txtID.DataBindings.Add(new Binding("Text", lstPartment, "Id", true));
            }
        }

        private void LoadPart()
        {
            List<Part> lstPart = PartDAO.Instance.GetListPart();
            if (lstPart.Count == 0)
            {
                MessageBox.Show("No data in Location!");
            }

            cbbListPart.DataSource = lstPart;
            cbbListPart.DisplayMember = "PartName";
            cbbListPart.ValueMember = "Id";
        }

        private void LoadFactory()
        {
            List<Factory> lstFactory = FactoryDAO.Instance.GetListFactory();
            if (lstFactory.Count == 0)
            {
                MessageBox.Show("No data in Location!");
            }

            cbbListFactory.DataSource = lstFactory;
            cbbListFactory.DisplayMember = "FactoryName";
            cbbListFactory.ValueMember = "Id";
        }

        private void LoadLocation()
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

        private void cbbListLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idLocation = this.cbbListLocation.SelectedValue.ToString();
            LoadListFactoryByLocation(idLocation);
        }

        private void LoadListFactoryByLocation(string idLocation)
        {
            cbbListFactory.DataSource = null;
            List<Factory> lstFactory = FactoryDAO.Instance.GetListFactoryByLocation(idLocation);

            cbbListFactory.DataSource = lstFactory;
            cbbListFactory.DisplayMember = "FactoryName";
            cbbListFactory.ValueMember = "Id";
        }

        private void cbbListFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idFactory = this.cbbListFactory.SelectedValue.ToString();
            LoadListPartByFactory(idFactory);
        }

        private void LoadListPartByFactory(string idFactory)
        {
            cbbListPart.DataSource = null;
            List<Part> lstPart = PartDAO.Instance.GetListPartByLocation(idFactory);

            cbbListPart.DataSource = lstPart;
            cbbListPart.DisplayMember = "PartName";
            cbbListPart.ValueMember = "Id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.btnSave.Text = "Save";
            this.btnSave.Show();
            this.cbbListLocation.Enabled = true;
            this.cbbListFactory.Enabled = true;
            this.cbbListPart.Enabled = true;
            this.btnAdd.Enabled = false;
            txtPartmentName.Text = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.btnSave.Hide();
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.cbbListLocation.Enabled = false;
            this.cbbListFactory.Enabled = false;
            this.cbbListPart.Enabled = false;

            var idPart = this.cbbListPart.SelectedValue.ToString();
            var namePart = txtPartmentName.Text;
            var idPartment = txtID.Text;
            if (this.btnSave.Text == "Save")
            {
                AddPartment(idPart, namePart);
            }
        }

        private void AddPartment(string idPart, string namePartment)
        {
            var checkStatus = PartmentDAO.Instance.CreateNewPartment(idPart, namePartment);
            if (checkStatus > 0)
            {
                MessageBox.Show("Success!");
                LoadListPartment();
            }
            else
                MessageBox.Show("Error!");
        }
    }
}
