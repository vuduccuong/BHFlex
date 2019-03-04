using IT_Management.DAO;
using IT_Management.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IT_Management.UI.ADD_DATA
{
    public partial class fmDevice : Form
    {
        public fmDevice()
        {
            InitializeComponent();
        }

        private void fmDevice_Load(object sender, EventArgs e)
        {
            txtDeviceName.Enabled = false;
            this.btnSave.Hide();
            this.txtID.Hide();

            LoadListDeviceType();
        }

        private void LoadListDeviceType()
        {
            List<DeviceType> lstDeviceType = DeviceTypeDAO.Instance.GetListDeviceTypes();
            if (lstDeviceType.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
            }
            else
            {
                dtgDeviceType.DataSource = lstDeviceType;

                this.txtDeviceName.DataBindings.Clear();
                this.txtDeviceName.DataBindings.Add(new Binding("Text", lstDeviceType, "DeviceTypeName", true));

                this.txtID.DataBindings.Clear();
                this.txtID.DataBindings.Add(new Binding("Text", lstDeviceType, "Id", true));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDeviceName.Enabled = true;
            txtDeviceName.Text = null;
            btnSave.Text = "Save";
            btnSave.Show();
            this.btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.btnSave.Hide();
            txtDeviceName.Enabled = false;
            var nameDeviceType = txtDeviceName.Text.Trim().ToString();
            var id = txtID.Text;
            this.btnEdit.Enabled = true;
            this.btnAdd.Enabled = true;
            if (btnSave.Text == "Save")
            {
                AddDeviceType(nameDeviceType);
            }

            if (btnSave.Text == "Update")
            {
                UpdateDeviceType(id, nameDeviceType);
            }
        }

        private void UpdateDeviceType(string id, string nameDeviceType)
        {
            int checkStatus = DeviceTypeDAO.Instance.UpdateDeviceType(id, nameDeviceType);
            if (checkStatus > 0)
            {
                MessageBox.Show("Success!");
                LoadListDeviceType();
            }
            else
            {
                MessageBox.Show("Error!");
                txtDeviceName.Focus();
            }
        }

        private void AddDeviceType(string nameDeviceType)
        {
            var checkStatus = DeviceTypeDAO.Instance.CreateNewDeviceType(nameDeviceType);
            if (checkStatus > 0)
            {
                MessageBox.Show("Success!");
                this.btnSave.Hide();
                LoadListDeviceType();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}