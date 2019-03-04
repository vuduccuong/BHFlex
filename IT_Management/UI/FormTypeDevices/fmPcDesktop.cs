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

        public fmPcDesktop()
        {
            

            InitializeComponent();
        }

        private void fmPcDesktop_Load(object sender, EventArgs e)
        {
            pcLoaddata();
            cbLocation.Enabled = false;
            cbFactorys.Enabled = false;
            cbParts.Enabled = false;
            cbPartment.Enabled = false;
            //LoadLocation();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string split = grbSW.Text;
            string[] words = split.Split('_');
            foreach (string word in words)
            {
                var a = words;
            }

            

            var idDevideInfo = Guid.NewGuid();
            var getIdDevices = "select Id from TypeDevices where NameDeviceType='"+txtPcName.Text+"'";
            string query = "insert into DeviceInfos(Id,NameDevice,NameUser,MACAdress,IPAdress,Model,CPU,RAM,HDD,OS,BuyDate,IdDevice,IdPartment) values('Desktop001', 'Desktop', '"+txtUserName.ToString()+"', '"+txtMAC.ToString()+"', '"+txtIP.ToString()+"', '"+txtModel.ToString()+"', '"+txtCPU.ToString()+"', '"+txtRAM.ToString()+"', '"+txtHDD.ToString()+"', '"+txtOS.ToString()+"', '"+txtBuydate.ToString()+"', '"+getIdDevices.ToString()+"', '"+idDevideInfo.ToString()+"')";



        }

        private void btnAddSW_Click(object sender, EventArgs e)
        {
            if (txtSW.Text == null) {
                MessageBox.Show("Không có dữ liệu");
            }
            else
            {
                var a = txtSW.Text;
                grbSW.Text += "\n_ "+a;
                txtSW.Text = "";
            }
        }

        private void dgvPCDesktop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void pcLoaddata() {

            //txtIdPc.Clear();
            //txtUserName.Clear();
            //txtPcName.Clear();
            //cbLocation.SelectedIndex=-1;
            //cbFactorys.SelectedIndex = -1;
            //cbParts.SelectedIndex = -1;
            //cbPartment.SelectedIndex = -1;
            //txtModel.Clear();
            //txtIP.Clear();
            //txtMAC.Clear();
            //txtCPU.Clear();
            //txtRAM.Clear();
            //txtHDD.Clear();
            //txtOS.Clear();
            //txtBuydate.Clear();
            //cbSoftware.SelectedIndex = -1;
            //grbSW.Text = "";
            String strLoaddata = "select di.Id, di.IdDevice , di.NameUser, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id";
            DataTable datable = DataProvider.Instance.ExecuteQuery(strLoaddata);
            dgvPCDesktop.DataSource = datable;

            txtIdPc.DataBindings.Clear();
            txtUserName.DataBindings.Clear();
            txtPcName.DataBindings.Clear();
            cbLocation.DataBindings.Clear();
            cbLocation.Enabled = false;
            cbFactorys.DataBindings.Clear();
            cbFactorys.Enabled = false;
            cbParts.DataBindings.Clear();
            cbParts.Enabled = false;
            cbPartment.DataBindings.Clear();
            cbPartment.Enabled = false;
            txtModel.DataBindings.Clear();
            txtIP.DataBindings.Clear();
            txtMAC.DataBindings.Clear();
            txtCPU.DataBindings.Clear();
            txtRAM.DataBindings.Clear();
            txtHDD.DataBindings.Clear();
            txtOS.DataBindings.Clear();
            txtBuydate.DataBindings.Clear();
            txtSW.DataBindings.Clear();
            grbSW.DataBindings.Clear();
            
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
            //cbSoftware.DataBindings.Add("text", datable, "SoftWare");
            grbSW.DataBindings.Add("text", datable, "SoftWare");
        }

        public void InsertData() {
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
            grbSW.DataBindings.Clear();

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
            var sw = grbSW.Text;

            String strInsert = string.Format("");
            DataTable datable = DataProvider.Instance.ExecuteQuery(strInsert);
            dgvPCDesktop.DataSource = datable;

            pcLoaddata();
        }
        public String getIDPCLoction = null;

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbLocation.Enabled = true;
            this.cbLocation.Text = "-- Select location --";
            this.cbFactorys.Enabled = true;
            this.cbFactorys.Text = "-- Select factory --";
            this.cbParts.Enabled = true;
            this.cbParts.Text = "-- Select part";
            this.cbPartment.Enabled = true;
            this.cbPartment.Text = "-- Select Partment --";
            
            
        }
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
            

            //String getCodeLocation = "select CodeLocation from Locations where NameLocation ='"+cbLocation.Text+"'";
            //String IPAdress = txtIP.ToString().Substring(6);
           // var strSetIdLocation = getCodeLocation+"PC"+ IPAdress +  ;
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
            grbSW.Text = "";

            txtUserName.Focus();
        }

        private void cbLocation_Click(object sender, EventArgs e)
        {
            LoadLocation();
        }

        private void txtBuydate_Leave(object sender, EventArgs e)
        {
            String lastIp = null;
            string[] listPara = txtIP.ToString().Split('.');
            lastIp += listPara[2];
            lastIp += listPara[3];
            MessageBox.Show(lastIp);
            var a = txtBuydate.Value;
            var setBuydate = (String.Format("{0:yy/MM}", a)).Replace("-", "");
            MessageBox.Show(setBuydate);

            String getCodeLocation = "select CodeLocation from Locations where NameLocation ='" + cbLocation.Text + "'";
            SqlCommand comm = new SqlCommand(getCodeLocation);

            txtIdPc.Text = getIDPCLoction + lastIp + setBuydate;

        }
    }
}
