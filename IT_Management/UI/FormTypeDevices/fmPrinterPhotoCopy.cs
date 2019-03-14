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
    public partial class fmPrinterPhotoCopy : Form
    {
        public fmPrinterPhotoCopy()
        {
            InitializeComponent();
        }
        public void PrinterLoadData()
        {
            String strLoaddata = "select di.id, di.NameDevice, di.idDevice as IdPrinter, di.NameUser,di.nameTypeDeviceInfos as PrinterName, di.NameDevice, di.IPAdress,di.MACAdress, di.BuyDate, di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation,di.Note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice='" + txtTypeDiveces.Text + "' and di.isDelete='0'";
            loadAndSearchData(strLoaddata);
            txtMAC.Enabled = false;
            lbMACError.Hide();
            lbIpError.Hide();
        }

        public void loadAndSearchData(string strLoaddata) {
            DataTable datable = DataProvider.Instance.ExecuteQuery(strLoaddata);
            dgvPCDesktop.DataSource = datable;
            #region ClearDatabindings
            rtbNote.DataBindings.Clear();
            txtMAC.DataBindings.Clear();
            txtid.DataBindings.Clear();
            txtIdPrinter.DataBindings.Clear();
            txtUserName.DataBindings.Clear();
            txtPrinterName.DataBindings.Clear();
            cbLocation.DataBindings.Clear();
            cbFactorys.DataBindings.Clear();
            cbParts.DataBindings.Clear();
            cbPartment.DataBindings.Clear();
            cbModel.DataBindings.Clear();
            txtIPPrinter.DataBindings.Clear();
            txtBuydate.DataBindings.Clear();
            #endregion
            #region addDataBindinds
            rtbNote.DataBindings.Add("text", datable, "Note");
            txtMAC.DataBindings.Add("text", datable, "MACAdress");
            txtid.DataBindings.Add("text", datable, "id");
            txtIdPrinter.DataBindings.Add("text", datable, "IdPrinter");
            txtUserName.DataBindings.Add("text", datable, "NameUser");
            txtPrinterName.DataBindings.Add("text", datable, "PrinterName");
            cbLocation.DataBindings.Add("text", datable, "NameLocation");
            cbFactorys.DataBindings.Add("text", datable, "NameFactory");
            cbParts.DataBindings.Add("text", datable, "NamePart");
            cbPartment.DataBindings.Add("text", datable, "NamePartment");
            cbModel.DataBindings.Add("text", datable, "Model");
            txtIPPrinter.DataBindings.Add("text", datable, "IPAdress");
            txtBuydate.DataBindings.Add("text", datable, "BuyDate");
            #endregion
        }
        private void fmPrinterPhotoCopy_Load(object sender, EventArgs e)
        {
            PrinterLoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            #region Enabled=true
            txtUserName.Focus();
            rtbNote.Enabled = true;
            txtMAC.Enabled = true;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            cbFactorys.Enabled = true;
            cbParts.Enabled = true;
            cbPartment.Enabled = true;
            cbLocation.Enabled = true;
            txtUserName.Enabled = true;
            txtIPPrinter.Enabled = true;
            cbModel.Enabled = true;
            txtBuydate.Enabled = true;
            #endregion
            txtIdPrinter.Clear();
            txtUserName.Clear();
            txtPrinterName.Clear();
            rtbNote.Clear();
            cbLocation.Text = "-- Select location --";
            cbFactorys.Text = "";
            cbParts.Text = "";
            cbPartment.Text = "";
            cbModel.Text = "";
            txtIPPrinter.Clear();
        }

        public void Inserted() {
            var strIdDevices = String.Format("select Id from TypeDevices where NameDeviceType='" + txtTypeDiveces.Text + "'");
            var IdDevice = DataProvider.Instance.ExecuteQuery(strIdDevices);
            String getIdDevices = IdDevice.Rows[0][0].ToString();

            var idPartment = cbPartment.SelectedValue.ToString();

            var query = String.Format("insert into DeviceInfos(IdDevice,NameDevice,NameUser,nameTypeDeviceInfos,IPAdress,MACAdress,Model,BuyDate,idDeviceType,IdPartment,Note,isDelete) values('" + txtIdPrinter.Text + "', '" + txtTypeDiveces.Text + "', '" + txtUserName.Text + "','" + txtPrinterName.Text + "','" + txtIPPrinter.Text + "','" + txtMAC.Text + "', '" + cbModel.Text + "', '" + txtBuydate.Text + "', '" + getIdDevices.ToString() + "', '" + idPartment.ToString() + "','" + rtbNote.Text + "',0)");
            var check = DataProvider.Instance.ExecuteNonQuery(query);
            if (check > 0)
            {
                MessageBox.Show("Succes !!!");
                PrinterLoadData();
            }
            else
            {
                MessageBox.Show("Error !!!");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int user = txtUserName.Text.Length;
            int printername = txtPrinterName.Text.Length;
            int mac = txtMAC.Text.Length;
            int locaiton = cbLocation.Text.Length;
            int factory = cbFactorys.Text.Length;
            int part = cbParts.Text.Length;
            int partment = cbPartment.Text.Length;
            int model = cbModel.Text.Length;
            int ip = txtIPPrinter.Text.Length;
            int note = rtbNote.Text.Length;

            if (user <= 0 || printername <= 0 || mac <= 0 || locaiton <= 0 || factory <= 0 || part <= 0 || partment <= 0 || model <= 0 || ip <= 0)
            {
                DialogResult dia = MessageBox.Show("Xin mời nhập đủ thông tin !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dia == DialogResult.OK)
                {
                    rtbNote.Focus();
                }
            }
            else
            {
                Inserted();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn UPdate không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.OK)
            {
                var strSelectIdPartmet = "select Partments.id from DeviceInfos left join Partments on Partments.id = DeviceInfos.idPartment where Partments.NamePartment='" + cbPartment.Text + "'";
                var idPartment = DataProvider.Instance.ExecuteQuery(strSelectIdPartmet);
                String getIdPartmnet = idPartment.Rows[0][0].ToString();

                var strUpdate = "update DeviceInfos set NameUser='" + txtUserName.Text + "',IPAdress='" + txtIPPrinter.Text + "', idDevice='" + txtIdPrinter.Text + "',nameTypeDeviceInfos='" + txtPrinterName.Text + "',Model='" + cbModel.Text + "',BuyDate='" + txtBuydate.Text + "',IdPartment='" + getIdPartmnet.ToString() + "',Note='" + rtbNote.Text + "' where id='" + txtid.Text + "'";
                var Updated = DataProvider.Instance.ExecuteNonQuery(strUpdate);
                if (Updated > 0)
                {
                    MessageBox.Show("Update Sucess !!!");
                    PrinterLoadData();
                }
                else
                {
                    MessageBox.Show("Update Fall \nLỗi lòi mắt rồi :(");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.OK)
            {
                var strDelete = String.Format("update DeviceInfos set isDelete=1 where Id='" + txtid.Text + "'");
                var Delete = DataProvider.Instance.ExecuteNonQuery(strDelete);
                if (Delete > 0)
                {
                    MessageBox.Show("Delete Sucess !!!");
                    PrinterLoadData();
                }
                else
                {
                    MessageBox.Show("Delete Fall :(");
                }
            }
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
        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idLocation = this.cbLocation.SelectedValue.ToString();
            LoadFactorybyLocation(idLocation);
        }
        private void LoadFactorybyLocation(string idLocation)
        {
            List<Factory> lstFactory = FactoryDAO.Instance.GetListFactoryByLocation(idLocation);
            cbFactorys.DataSource = lstFactory;

            cbFactorys.DisplayMember = "FactoryName";
            cbFactorys.ValueMember = "Id";
        }
        private void cbLocation_Click(object sender, EventArgs e)
        {
            LoadLocation();
        }

        private void cbFactorys_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idFactory = this.cbFactorys.SelectedValue.ToString();
            LoadListPartByFactory(idFactory);
        }
        private void LoadListPartByFactory(string idFactory)
        {
            List<Part> lstPart = PartDAO.Instance.GetListPartByFactory(idFactory);
            cbParts.DataSource = lstPart;

            cbParts.DisplayMember = "PartName";
            cbParts.ValueMember = "Id";
        }

        private void cbParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idPart = this.cbParts.SelectedValue.ToString();
            loadListPartmentbyPart(idPart);
        }

        private void loadListPartmentbyPart(string idPart)
        {
            List<Partment> lstPartment = PartmentDAO.Instance.GetListPartmentByPart(idPart);
            cbPartment.DataSource = lstPartment;
            cbPartment.DisplayMember = "PartmentName";
            cbPartment.ValueMember = "Id";
        }

        private void txtBuydate_Leave(object sender, EventArgs e)
        {
            try
            {
                var ip = txtIPPrinter.Text;
                DateTime a = txtBuydate.Value;
                var location = cbLocation.Text;
                var codeName = "PR";
                txtPrinterName.Text = BuydateDAO.Instance.getBuyDate(ip, a, location, codeName);
                txtIdPrinter.Text = BuydateDAO.Instance.getBuyDate(ip, a, location, codeName);
            }
            catch
            {
                MessageBox.Show("Vui Lòng nhập IP");
                txtIPPrinter.Focus();
            }
        }


        private void txtIPPrinter_Leave(object sender, EventArgs e)
        {
            var a = txtIPPrinter.Text;
            if (a.Length < 7 | a.Length > 15)
            {
                MessageBox.Show("The IP address must be in the form of 000.111.222.333");
                lbIpError.Show();
                txtIPPrinter.Focus();
            }
            else
            {
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
            else
            {
                lbMACError.Hide();
            }
        }

        private void txtIPPrinter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            var a = txtIPPrinter.Text;
            var b = Regex.IsMatch(a, @"\.");
        }

        private void txtSearchByPcName_Click(object sender, EventArgs e)
        {
            txtSearchByPcName.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String search = "select di.id,di.NameDevice, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.IPAdress,di.MACAdress, di.BuyDate, di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation,di.Note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.nameTypeDeviceInfos like '%" + txtSearchByPcName.Text + "%' and di.NameDevice='" + txtTypeDiveces.Text + "' and di.isDelete='0'";
                loadAndSearchData(search);

                txtSearchByPcName.Clear();
                txtMAC.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Fall");
            }
        }
    }
}
