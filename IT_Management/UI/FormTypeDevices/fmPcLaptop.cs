using IT_Management.DAO;
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

namespace IT_Management.UI.FormTypeDevices
{
    public partial class fmPcLaptop : Form
    {
        public string NameDevice;

        public fmPcLaptop()
        {
            InitializeComponent();
        }
        private void fmPcLaptop_Load(object sender, EventArgs e)
        {
            pcLoaddata();
            btnInsertLap.Enabled = false;
            btnUpdateLap.Enabled = false;
            btnDeleteLap.Enabled = false;
            LoadLocation();
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

        public void pcLoaddata()
        {
            String strLoaddata = "select di.Id, di.NameUser,di.pcName, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice='"+txtTypeDiveces.Text+ "' and di.isDelete='0';";
            DataTable datable = DataProvider.Instance.ExecuteQuery(strLoaddata);
            dgvPCLaptop.DataSource = datable;
            ClearDataGipView();
            #region DataBindinds
            txtIdPc.DataBindings.Add("text", datable, "id");
            txtUserName.DataBindings.Add("text", datable, "NameUser");
            txtPcName.DataBindings.Add("text", datable, "pcName");
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
            txtSW.DataBindings.Add("text", datable, "SoftWare");
            var arrData = txtSW.Text.Split(',');
            LoadDataToListView(arrData);
            #endregion

        }

        private void LoadDataToListView(string[] arrData)
        {
           foreach(var item in arrData)
            {
                lbSW.Items.Add(item);
            }
        }

        private void ClearDataGipView()
        {
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            enableTrue();
            txtSW.Clear();
            txtIdPc.Clear();
            txtUserName.Clear();
            txtPcName.Clear();
            cbLocation.Text = "-- Select location --";
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
        public void enableTrue() {
            btnInsertLap.Enabled = true;
            btnUpdateLap.Enabled = true;
            btnDeleteLap.Enabled = true;
            btnAddSW.Enabled = true;
            cbFactorys.Enabled = true;
            cbParts.Enabled = true;
            cbPartment.Enabled = true;
            cbLocation.Enabled = true;
            txtUserName.Enabled = true;
            txtIP.Enabled = true;
            txtMAC.Enabled = true;
            txtCPU.Enabled = true;
            txtRAM.Enabled = true;
            txtHDD.Enabled = true;
            txtOS.Enabled = true;
            txtModel.Enabled = true;
            txtBuydate.Enabled = true;
            txtSW.Enabled = true;
            lbSW.Enabled = true;
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void cbLocation_Click(object sender, EventArgs e)
        {
            this.cbLocation.Text = "-- Select location --";
            //this.cbFactorys.Enabled = true;
            //this.cbFactorys.Text = "-- Select factory --";
            //LoadLocation();
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

            txtIdPc.Text = (String.Format(name + "PC" + lastIp + setBuydate));
            txtPcName.Text = (String.Format(name + "PC" + lastIp + setBuydate));
        }

        private void cbFactorys_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void cbParts_Click(object sender, EventArgs e)
        {
            var idPart = this.cbParts.SelectedValue.ToString();
            LoadListPartmentByPart(idPart);
        }

        private void LoadListPartmentByPart(string idPart)
        {
            cbPartment.DataSource = null;
            List<Partment> lstPartment = PartmentDAO.Instance.GetListPartmentByPart(idPart);
            cbPartment.DataSource = lstPartment;
            cbPartment.DisplayMember = "PartmentName";
            cbPartment.ValueMember = "Id";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var soft = "";
            foreach (var item in lbSW.Items)
            {
                soft = soft + "," + item;
            }
            //var idDevideInfo = Guid.NewGuid();
            var IdDevices = String.Format("select Id from TypeDevices where NameDeviceType='"+txtTypeDiveces.Text+"'");
            var IdDevice = DataProvider.Instance.ExecuteQuery(IdDevices);
            String getIdDevices = IdDevice.Rows[0][0].ToString();
            var idPartment = cbPartment.SelectedValue.ToString();

            var query = String.Format("insert into DeviceInfos(Id,NameDevice,NameUser,pcName,MACAdress,IPAdress,Model,CPU,RAM,HDD,OS,BuyDate,SoftWare,IdDevice,IdPartment,isDelete) values('" + txtIdPc.Text + "', 'Laptop', '" + txtUserName.Text + "','"+txtPcName.Text+"', '" + txtMAC.Text + "', '" + txtIP.Text + "', '" + txtModel.Text + "', '" + txtCPU.Text + "', '" + txtRAM.Text + "', '" + txtHDD.Text + "', '" + txtOS.Text + "', '" + txtBuydate.Text + "','" + soft.Substring(1) + "', '" + getIdDevices.ToString() + "', '" + idPartment.ToString() + "',0)");
            var check = DataProvider.Instance.ExecuteNonQuery(query);
            if (check > 0)
            {
                MessageBox.Show("Succes !!!");
                pcLoaddata();
            }
            else
            {
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

        public void InsertData()
        {
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
            dgvPCLaptop.DataSource = datable;

            pcLoaddata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var strDelete = String.Format("update DeviceInfos set isDelete=1 where Id='"+txtIdPc.Text+"'");
            var Delete = DataProvider.Instance.ExecuteNonQuery(strDelete);
            if (Delete > 0)
            {
                MessageBox.Show("Delete Sucess !!!");
                pcLoaddata();
            }
            else {
                MessageBox.Show("Delete Fall :(");
            }
        }

        private void btnUpdateLap_Click(object sender, EventArgs e)
        {
            var soft = "";
            foreach (var item in lbSW.Items)
            {
                soft = soft + "," + item;
            }
            var strSelectIdPartmet = "select Partments.id from DeviceInfos left join Partments on Partments.id = DeviceInfos.idPartment where Partments.NamePartment='"+cbPartment.Text+"'";
            var idPartment = DataProvider.Instance.ExecuteQuery(strSelectIdPartmet);
            String getIdPartmnet = idPartment.Rows[0][0].ToString();
            var strUpdate = "update DeviceInfos set NameUser='" + txtUserName.Text + "',MACAdress='" + txtMAC.Text + "',IPAdress='" + txtIP.Text + "',Model='" + txtModel.Text + "',CPU='" + txtCPU.Text + "',RAM='" + txtRAM.Text + "',HDD='" + txtHDD.Text + "',OS='" + txtOS.Text + "',SoftWare='" + soft.Substring(1) + "',BuyDate='" + txtBuydate.Text + "',IdPartment='" + getIdPartmnet.ToString() + "' where id='" + txtIdPc.Text + "'";
            var Updated = DataProvider.Instance.ExecuteNonQuery(strUpdate);
            if (Updated > 0)
            {
                MessageBox.Show("Update Sucess !!!");
                pcLoaddata();
            }
            else
            {
                MessageBox.Show("Update fall \nLỗi lòi mắt rồi :(");
            }
        }
        private void lbSW_DoubleClick(object sender, EventArgs e)
        {
            lbSW.Items.Remove(lbSW.SelectedItem);
        }

        private void lbSW_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
