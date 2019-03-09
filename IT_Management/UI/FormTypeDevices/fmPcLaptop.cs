using IT_Management.DAO;
using IT_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            String strLoaddata = "select di.id, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice='" + txtTypeDiveces.Text+ "' and di.isDelete='0';";
            DataTable datable = DataProvider.Instance.ExecuteQuery(strLoaddata);
            dgvPCLaptop.DataSource = datable;

            lbMACError.Hide();
            lbIpError.Hide();

            txtMAC.Enabled = false;
            ClearDataGipView();
            #region DataBindinds
            txtid.DataBindings.Add("text", datable, "id");
            txtIdPc.DataBindings.Add("text", datable, "idDevice");
            txtUserName.DataBindings.Add("text", datable, "NameUser");
            txtPcName.DataBindings.Add("text", datable, "nameTypeDeviceInfos");
            cbLocation.DataBindings.Add("text", datable, "NameLocation");
            cbFactorys.DataBindings.Add("text", datable, "NameFactory");
            cbParts.DataBindings.Add("text", datable, "NamePart");
            cbPartment.DataBindings.Add("text", datable, "NamePartment");
            cbModel.DataBindings.Add("text", datable, "Model");
            txtIP.DataBindings.Add("text", datable, "IPAdress");
            txtMAC.DataBindings.Add("text", datable, "MACAdress");
            cbCPU.DataBindings.Add("text", datable, "CPU");
            cbRAM.DataBindings.Add("text", datable, "RAM");
            cbHDD.DataBindings.Add("text", datable, "HDD");
            cbOS.DataBindings.Add("text", datable, "OS");
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
            txtid.DataBindings.Clear();
            txtIdPc.DataBindings.Clear();
            txtUserName.DataBindings.Clear();
            txtPcName.DataBindings.Clear();
            cbLocation.DataBindings.Clear();
            cbFactorys.DataBindings.Clear();
            cbParts.DataBindings.Clear();
            cbPartment.DataBindings.Clear();
            cbModel.DataBindings.Clear();
            txtIP.DataBindings.Clear();
            txtMAC.DataBindings.Clear();
            cbCPU.DataBindings.Clear();
            cbRAM.DataBindings.Clear();
            cbHDD.DataBindings.Clear();
            cbOS.DataBindings.Clear();
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
            cbModel.Text = "";
            txtIP.Clear();
            txtMAC.Clear();
            cbCPU.Text = "";
            cbRAM.Text = "";
            cbHDD.Text = "";
            cbOS.Text = "";
            txtSW.Clear();
            lbSW.Text = "";
            rtbNote.Clear();
            
            txtUserName.Focus();
        }
        public void enableTrue() {
            rtbNote.Enabled = true;
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
            cbCPU.Enabled = true;
            cbRAM.Enabled = true;
            cbHDD.Enabled = true;
            cbOS.Enabled = true;
            cbModel.Enabled = true;
            txtBuydate.Enabled = true;
            txtSW.Enabled = true;
            lbSW.Enabled = true;
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbLocation.SelectedValue !=null) {
                var idLocation = this.cbLocation.SelectedValue.ToString();
                LoadListFactoryByLocation(idLocation);
            }
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
            try
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
            catch
            {
                MessageBox.Show("Vui Lòng nhập IP");
                txtIP.Focus();
            }
        }

        private void cbFactorys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbLocation.SelectedValue != null)
            {
                var idFactory = this.cbFactorys.SelectedValue.ToString();
                LoadListPartByFactory(idFactory);
            }
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
            //var idPart = this.cbParts.SelectedValue.ToString();
            //LoadListPartmentByPart(idPart);
        }

        public void Inserted()
        {
            #region length=0
            int note = rtbNote.Text.Length;
            int id = txtid.Text.Length;
            int idPC = txtIdPc.Text.Length;
            int user = txtUserName.Text.Length;
            int pcname = txtPcName.Text.Length;
            int location = cbLocation.Text.Length;
            int factory = cbFactorys.Text.Length;
            int part = cbParts.Text.Length;
            int partment = cbPartment.Text.Length;
            int model = cbModel.Text.Length;
            int ip = txtIP.Text.Length;
            int mac = txtMAC.Text.Length;
            int cpu = cbCPU.Text.Length;
            int ram = cbRAM.Text.Length;
            int hdd = cbHDD.Text.Length;
            int os = cbOS.Text.Length;
            int buydate = txtBuydate.Text.Length;
            int sw = lbSW.Text.Length;
            #endregion
            if (note <= 0 | id <= 0 | idPC <= 0 || user <= 0 || pcname <= 0 || location <= 0 || factory <= 0 || part <= 0 || partment <= 0 || model <= 0 ||
                ip <= 0 || mac <= 0 || cpu <= 0 || ram <= 0 || hdd <= 0 || os <= 0 || buydate <= 0 || sw <= 0)
            {
                DialogResult dia = MessageBox.Show("Thông tin chưa đầy đủ, Bạn vẫn muốn tiếp tục Insert?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dia == DialogResult.Yes)
                {
                    var soft = "";
                    foreach (var item in lbSW.Items)
                    {
                        soft = soft + "," + item;
                    }
                    //var idDevideInfo = Guid.NewGuid();
                    var IdDevices = String.Format("select Id from TypeDevices where NameDeviceType='" + txtTypeDiveces.Text + "'");
                    var IdDevice = DataProvider.Instance.ExecuteQuery(IdDevices);
                    String getIdDevices = IdDevice.Rows[0][0].ToString();
                    var idPartment = cbPartment.SelectedValue.ToString();

                    var query = String.Format("insert into DeviceInfos(IdDevice,NameDevice,NameUser,nameTypeDeviceInfos,MACAdress,IPAdress,Model,CPU,RAM,HDD,OS,BuyDate,SoftWare,idDeviceType,IdPartment,Note,isDelete) values('" + txtIdPc.Text + "', 'Laptop', '" + txtUserName.Text + "','" + txtPcName.Text + "', '" + txtMAC.Text + "', '" + txtIP.Text + "', '" + cbModel.Text + "', '" + cbCPU.Text + "', '" + cbRAM.Text + "', '" + cbHDD.Text + "', '" + cbOS.Text + "', '" + txtBuydate.Text + "','" + soft.Substring(1) + "', '" + getIdDevices.ToString() + "', '" + idPartment.ToString() + "','" + rtbNote.Text + "',0)");
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
                else
                {
                    txtUserName.Focus();
                }
            }
            
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Inserted();
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
            var model = cbModel.Text;
            var ip = txtIP.Text;
            var mac = txtMAC.Text;
            var cpu = cbCPU.Text;
            var ram = cbRAM.Text;
            var hdd = cbHDD.Text;
            var os = cbOS.Text;
            var buydate = txtBuydate.Text;
            var sw = lbSW.Text;

            String strInsert = string.Format("");
            DataTable datable = DataProvider.Instance.ExecuteQuery(strInsert);
            dgvPCLaptop.DataSource = datable;

            pcLoaddata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var strDelete = String.Format("update DeviceInfos set isDelete=1 where Id='"+txtid.Text+"'");
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
            var strUpdate = "update DeviceInfos set nameTypeDeviceInfos='" + txtPcName.Text + "',idDevice='" + txtIdPc.Text + "',NameUser='" + txtUserName.Text + "',MACAdress='" + txtMAC.Text + "',IPAdress='" + txtIP.Text + "',Model='" + cbModel.Text + "',CPU='" + cbCPU.Text + "',RAM='" + cbRAM.Text + "',HDD='" + cbHDD.Text + "',OS='" + cbOS.Text + "',SoftWare='" + soft.Substring(1) + "',BuyDate='" + txtBuydate.Text + "',IdPartment='" + getIdPartmnet.ToString() + "',Note='"+rtbNote.Text+"' where id='" + txtid.Text + "'";
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

        private void cbParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbParts.SelectedValue != null)
            {
                var idPart = this.cbParts.SelectedValue.ToString();
                LoadListPartmentByPart(idPart);
            }
        }

        private void LoadListPartmentByPart(string idPart)
        {
            //cbPartment.DataSource = null;
            List<Partment> lstPartment = PartmentDAO.Instance.GetListPartmentByPart(idPart);
            cbPartment.DataSource = lstPartment;
            cbPartment.DisplayMember = "PartmentName";
            cbPartment.ValueMember = "Id";
        }

        private void lbSW_DoubleClick_1(object sender, EventArgs e)
        {
            lbSW.Items.Remove(lbSW.SelectedItem);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIP_Leave(object sender, EventArgs e)
        {
            var a = txtIP.Text;
            if (a.Length < 7 | a.Length > 15)
            {
                MessageBox.Show("The IP address must be in the form of 000.111.222.333");
                lbIpError.Show();
                txtIP.Focus();
            }
            else {
                lbIpError.Hide();
            }
        }

        private void txtMAC_Leave(object sender, EventArgs e)
        {
            var a = txtMAC.Text;
            if (a.Length != 17)
            {
                MessageBox.Show("The MAC address must be in the form of A1:B2:C3:D4:E5:G6");
                lbMACError.Show();
                txtMAC.Focus();
            }
            else {
                lbMACError.Hide();
            }
        }

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            var a = txtIP.Text;
            var b = Regex.IsMatch(a, @"\.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String search = "select di.id, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.nameTypeDeviceInfos like '%" + txtSearchByPcName.Text + "%' and NameDevice ='" + txtTypeDiveces.Text + "'";
                DataTable datable = DataProvider.Instance.ExecuteQuery(search);
                dgvPCLaptop.DataSource = datable;

                txtSearchByPcName.Clear();
                ClearDataGipView();
                txtMAC.Enabled = false;

                #region DataBindinds
                txtid.DataBindings.Add("text", datable, "id");
                txtIdPc.DataBindings.Add("text", datable, "idDevice");
                txtUserName.DataBindings.Add("text", datable, "NameUser");
                txtPcName.DataBindings.Add("text", datable, "nameTypeDeviceInfos");
                cbLocation.DataBindings.Add("text", datable, "NameLocation");
                cbFactorys.DataBindings.Add("text", datable, "NameFactory");
                cbParts.DataBindings.Add("text", datable, "NamePart");
                cbPartment.DataBindings.Add("text", datable, "NamePartment");
                cbModel.DataBindings.Add("text", datable, "Model");
                txtIP.DataBindings.Add("text", datable, "IPAdress");
                txtMAC.DataBindings.Add("text", datable, "MACAdress");
                cbCPU.DataBindings.Add("text", datable, "CPU");
                cbRAM.DataBindings.Add("text", datable, "RAM");
                cbHDD.DataBindings.Add("text", datable, "HDD");
                cbOS.DataBindings.Add("text", datable, "OS");
                txtBuydate.DataBindings.Add("text", datable, "BuyDate");
                txtSW.DataBindings.Add("text", datable, "SoftWare");
                var arrData = txtSW.Text.Split(',');
                loadDataListBox(arrData);
                #endregion
            }
            catch
            {
                MessageBox.Show("Lỗi rồi gọi cho phòng IT nhé", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void loadDataListBox(string[] arrData)
        {
            foreach (string item in arrData)
            {
                lbSW.Items.Add(item);
            }
        }

        private void txtSearchByPcName_Click(object sender, EventArgs e)
        {
            txtSearchByPcName.Clear();
        }
    }
}
