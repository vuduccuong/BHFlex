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

            LoadLisPart();
            //Load
        }

        private void LoadLisPart()
        {
            List<Part> lstPart = PartDAO.Instance.GetListPart();
            if (lstPart.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
            }
            else { 
            dtgPart.DataSource = lstPart;

            this.txtPartName.DataBindings.Clear();
            this.txtPartName.DataBindings.Add(new Binding("Text", lstPart, "PartName", true));

            this.txtID.DataBindings.Clear();
            this.txtID.DataBindings.Add(new Binding("Text", lstPart, "Id", true));


            this.cbbListLocation.DataBindings.Clear();
            this.cbbListLocation.DataBindings.Add(new Binding("Text", lstPart, "LocationCode",true));
            }
        }

        private void cbbListLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
