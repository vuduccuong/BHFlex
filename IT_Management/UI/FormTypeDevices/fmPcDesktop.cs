using IT_Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using IT_Management.DTO;

namespace IT_Management.UI.FormTypeDevices
{
    public partial class fmPcDesktop : Form
    {
        public  string NameDevice;

         public fmPcDesktop()
        {
            

            InitializeComponent();
            
        }
       

        private void fmPcDesktop_Load(object sender, EventArgs e)
        {
            pcLoaddata();
            //cbLocation.Enabled = false;
            cbFactorys.Hide();
            cbParts.Hide();
            cbPartment.Hide();
            LoadLocation();
            //LoadListFactory();
            //LoadListPart();
            //LoadListPartment();
        }

        private void LoadListPartment()
        {
            cbPartment.DataSource = null;
            List<Partment> lstPartment = PartmentDAO.Instance.GetListPartment();

            cbPartment.DataSource = lstPartment;
            cbPartment.DisplayMember = "PartmentName";
            cbPartment.ValueMember = "Id";
        }

        private void LoadListPart()
        {
            cbParts.DataSource = null;
            List<Part> lstPart = PartDAO.Instance.GetListPart();

            cbParts.DataSource = lstPart;
            cbParts.DisplayMember = "PartName";
            cbParts.ValueMember = "Id";
        }

        private void LoadListFactory()
        {
            cbFactorys.DataSource = null;
            List<Factory> lstFactory = FactoryDAO.Instance.GetListFactory();
            cbFactorys.DataSource = lstFactory;

            cbFactorys.DisplayMember = "FactoryName";
            cbFactorys.ValueMember = "Id";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var soft = "";
            foreach (var item in lbSW.Items)
            {
                soft = soft + "," + item;
            }

            //var idDevideInfo = Guid.NewGuid();
            var IdDevices = String.Format("select Id from TypeDevices where NameDeviceType='"+NameDevice+"'");
            var IdDevice =DataProvider.Instance.ExecuteQuery(IdDevices);
            String getIdDevices = IdDevice.Rows[0][0].ToString();
            var idPartment = cbPartment.SelectedValue.ToString();
            var query = String.Format("insert into DeviceInfos(Id,NameDevice,NameUser,MACAdress,IPAdress,Model,CPU,RAM,HDD,OS,BuyDate,SoftWare,IdDevice,IdPartment) values('" + txtIdPc.Text+"', 'Desktop', '"+txtUserName.Text+"', '"+txtMAC.Text+"', '"+txtIP.Text+"', '"+txtModel.Text+"', '"+txtCPU.Text+"', '"+txtRAM.Text+"', '"+txtHDD.Text+"', '"+txtOS.Text+"', '"+txtBuydate.Text+"','"+soft.Substring(1)+"', '"+ getIdDevices.ToString()+"', '"+ idPartment.ToString()+"')");
            var check = DataProvider.Instance.ExecuteNonQuery(query);
            if (check > 0)
            {
                MessageBox.Show("Succes !!1");
                pcLoaddata();
            }
            else {
                MessageBox.Show("Error !!!");
            }
        }

        private void btnAddSW_Click(object sender, EventArgs e)
        {
                if (!String.IsNullOrWhiteSpace(txtSW.Text))
                    lbSW.Items.Add(txtSW.Text);
                    txtSW.Text = string.Empty;
                    txtSW.Focus();
            
        }

        private void dgvPCDesktop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void pcLoaddata() {
            String strLoaddata = "select di.Id, di.IdDevice , di.NameUser, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id";
            DataTable datable = DataProvider.Instance.ExecuteQuery(strLoaddata);
            dgvPCDesktop.DataSource = datable;

            ClearDataGipView();
            //cbLocation.Enabled = false;
            //cbFactorys.Enabled = false;
            //cbParts.Enabled = false;
            ///cbPartment.Enabled = false;
            #region DataBindinds
            txtIdPc.DataBindings.Add("text", datable,"id");
            txtUserName.DataBindings.Add("text", datable, "NameUser");
            txtPcName.DataBindings.Add("text", datable, "NameDevice");
            cbLocation.DataBindings.Add("text", datable, "NameLocation");
            cbFactorys.DataBindings.Add("text", datable, "NameFactory");
            cbParts.DataBindings.Add("text", datable, "NamePart");
            cbPartment.DataBindings.Add("text", datable, "NamePartment");
            txtModel.DataBindings.Add("text", datable, "Model");
            txtIP.DataBindings.Add("text", datable, "IPAdress");
            txtMAC.DataBindings.Add("text", datable, "MACAdress");
            txtCPU.DataBindings.Add("text", datable, "CPU");
            txtRAM.DataBindings.Add("text", datable, "RAM");
            txtHDD.DataBindings.Add("text", datable, "HDD");
            txtOS.DataBindings.Add("text", datable, "OS");
            txtBuydate.DataBindings.Add("text", datable, "BuyDate");
            lbSW.DataBindings.Add("text", datable, "SoftWare");
            #endregion
        }

        public void ClearDataGipView() {
            txtIdPc.DataBindings.Clear();
            txtUserName.DataBindings.Clear();
            txtPcName.DataBindings.Clear();
            cbLocation.DataBindings.Clear();
            cbFactorys.DataBindings.Clear();
            cbParts.DataBindings.Clear();
            cbPartment.DataBindings.Clear();
            txtModel.DataBindings.Clear();
            txtIP.DataBindings.Clear();
            txtMAC.DataBindings.Clear();
            txtCPU.DataBindings.Clear();
            txtRAM.DataBindings.Clear();
            txtHDD.DataBindings.Clear();
            txtOS.DataBindings.Clear();
            txtBuydate.DataBindings.Clear();
            txtSW.DataBindings.Clear();
            lbSW.DataBindings.Clear();
        }

        public void InsertData() {
            ClearDataGipView();
            var idpc = txtIdPc.Text;
            var username = txtUserName.Text;
            var pcname = txtPcName.Text;
            var model = txtModel.Text;
            var ip = txtIP.Text;
            var mac = txtMAC.Text;
            var cpu = txtCPU.Text;
            var ram = txtRAM.Text;
            var hdd = txtHDD.Text;
            var os = txtOS.Text;
            var buydate = txtBuydate.Text;
            var sw = lbSW.Text;

            String strInsert = string.Format("");
            DataTable datable = DataProvider.Instance.ExecuteQuery(strInsert);
            dgvPCDesktop.DataSource = datable;

            pcLoaddata();
        }
        public String getIDPCLoction = null;

        private void LoadLocation()
        {
            List<Location> lstLocation = LocationDAO.Instance.GetListCustommer();
            if (lstLocation.Count == 0)
            {
                MessageBox.Show("No data in Location!");
            }

            cbLocation.DataSource = lstLocation;
            cbLocation.DisplayMember = "LocationName";
            cbLocation.ValueMember = "Id";
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtIdPc.Clear();
            txtUserName.Clear();
            txtPcName.Clear();
            cbLocation.Text = "-- Select location --";
            cbLocation.Enabled = true;
            cbFactorys.Text = "";
            cbParts.Text = "";
            cbPartment.Text = "";
            txtModel.Clear();
            txtIP.Clear();
            txtMAC.Clear();
            txtCPU.Clear();
            txtRAM.Clear();
            txtHDD.Clear();
            txtOS.Clear();
            txtSW.Clear();
            lbSW.Text = "";

            txtUserName.Focus();
        }

        private void cbLocation_Click(object sender, EventArgs e)
        {
            this.cbLocation.Enabled = true;
            this.cbLocation.Text = "-- Select location --";
            this.cbFactorys.Enabled = true;
            this.cbFactorys.Text = "-- Select factory --";
            LoadLocation();
        }
        private void txtBuydate_Leave(object sender, EventArgs e)
        {
            String lastIp = null;
            string[] listPara = txtIP.Text.ToString().Split('.');
            lastIp += listPara[2];
            lastIp += listPara[3];
            var a = txtBuydate.Value;
            var setBuydate = (String.Format("{0:yy/MM}", a)).Replace("-", "");
            

            String CodeLocation = "select CodeLocation from Locations where NameLocation ='" + cbLocation.Text + "'";
            var getCodeLocation = DataProvider.Instance.ExecuteQuery(CodeLocation);
            string name = getCodeLocation.Rows[0][0].ToString();

            txtIdPc.Text = (String.Format(name +"PC"+ lastIp + setBuydate));
            txtPcName.Text = (String.Format(name + "PC" + lastIp + setBuydate));

        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFactorys.Show();
            var idLocation = this.cbLocation.SelectedValue.ToString();
            LoadListFactoryByLocation(idLocation);
        }

        private void LoadListFactoryByLocation(string idLocation)
        {
            
            List<Factory> lstFactory = FactoryDAO.Instance.GetListFactoryByLocation(idLocation);
            cbFactorys.DataSource = lstFactory;

            cbFactorys.DisplayMember = "FactoryName";
            cbFactorys.ValueMember = "Id";
        }

        private void cbFactorys_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbParts.Show();
            var idFactory = this.cbFactorys.SelectedValue.ToString();
            LoadListPartByFactory(idFactory);
        }

        private void LoadListPartByFactory(string idFactory)
        {
            cbParts.DataSource = null;
            List<Part> lstPart = PartDAO.Instance.GetListPartByFactory(idFactory);

            cbParts.DataSource = lstPart;
            cbParts.DisplayMember = "PartName";
            cbParts.ValueMember = "Id";
        }

        private void cbPartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var idpartment = this.cbPartment.SelectedValue.ToString();
            //LoadlistPartmentbyPart();
        }

        private void cbParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPartment.Show();
               var idPart = this.cbParts.SelectedValue.ToString();
               LoadListPartmentByPart(idPart);
                cbPartment.Show();
          
        }

        private void LoadListPartmentByPart(string idPart)
        {
            cbPartment.DataSource = null;
            List<Partment> lstPartment = PartmentDAO.Instance.GetListPartmentByPart(idPart);
            cbPartment.DataSource = lstPartment;
            cbPartment.DisplayMember = "PartmentName";
            cbPartment.ValueMember = "Id";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
