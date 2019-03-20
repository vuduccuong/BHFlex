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
    public partial class fmPDA2D : Form
    {
        public fmPDA2D()
        {
            InitializeComponent();
        }

        private void fmPDA2D_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            txtPDAName.Enabled = false;
            txtIPPDA.Enabled = false;
            cbModel.Enabled = false;
            cbLocation.Enabled = false;
            cbFactorys.Enabled = false;
            cbParts.Enabled = false;
            cbPartment.Enabled = false;
            rtbNote.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtMAC.Enabled = false;
            PDALoaddata();
        }

        private void loadAndSearchData(string strLoaddata) {
            DataTable datable = DataProvider.Instance.ExecuteQuery(strLoaddata);
            dgvPDA2D.DataSource = datable;

            #region ClearDataBindings
            txtMAC.DataBindings.Clear();
            txtid.DataBindings.Clear();
            txtPDAName.DataBindings.Clear();
            txtIPPDA.DataBindings.Clear();
            cbModel.DataBindings.Clear();
            rtbNote.DataBindings.Clear();
            cbLocation.DataBindings.Clear();
            cbFactorys.DataBindings.Clear();
            cbParts.DataBindings.Clear();
            cbPartment.DataBindings.Clear();

            #endregion
            #region DataBindinds
            txtMAC.DataBindings.Add("text", datable, "MACAdress");
            txtid.DataBindings.Add("text", datable, "id");
            txtPDAName.DataBindings.Add("text", datable, "nameTypeDeviceInfos");
            txtIPPDA.DataBindings.Add("text", datable, "IPAdress");
            cbModel.DataBindings.Add("text", datable, "Model");
            rtbNote.DataBindings.Add("text", datable, "Note");
            cbLocation.DataBindings.Add("text", datable, "NameLocation");
            cbFactorys.DataBindings.Add("text", datable, "NameFactory");
            cbParts.DataBindings.Add("text", datable, "NamePart");
            cbPartment.DataBindings.Add("text", datable, "NamePartment");
            #endregion
        }
        public void PDALoaddata()
        {
            String strLoaddata = "select di.id,di.NameDevice, di.nameTypeDeviceInfos, di.IPAdress,di.MACAdress, di.Model, di.BuyDate, lc.NameLocation, fa.NameFactory, p.NamePart, pt.NamePartment, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice='PDA 2D' and di.isDelete='0'";
            loadAndSearchData(strLoaddata);
            txtMAC.Enabled = false;
            lbMACError.Hide();
            lbIpError.Hide();
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cbLocation.Focus();
            cbLocation.Text = "-- Select location --";
            cbFactorys.Text = "";
            cbParts.Text = "";
            cbPartment.Text = "";
            txtPDAName.Clear();
            cbModel.Text = "";
            txtIPPDA.Clear();
            rtbNote.Clear();
            txtMAC.Clear();

            txtMAC.Enabled = true;
            cbModel.Enabled = true;
            txtIPPDA.Enabled = true;
            txtBuydate.Enabled = true;
            cbLocation.Enabled = true;
            cbFactorys.Enabled = true;
            cbParts.Enabled = true;
            cbPartment.Enabled = true;
            rtbNote.Enabled = true;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
        public void Inserted()
        {
            var strIdDevices = String.Format("select id from TypeDevices where NameDeviceType='PDA 2D'");
            var IdDevice = DataProvider.Instance.ExecuteQuery(strIdDevices);
            String getIdDevices = IdDevice.Rows[0][0].ToString();

            var idPartment = cbPartment.SelectedValue.ToString();

            var query = String.Format("insert into DeviceInfos(IdDevice,nameTypeDeviceInfos,NameDevice,IPAdress,MACAdress,Model,BuyDate,Note,idDeviceType,IdPartment,isDelete) values('" + txtPDAName.Text + "','" + txtPDAName.Text + "','PDA 2D','" + txtIPPDA.Text + "', '" + txtMAC.Text + "','" + cbModel.Text + "', '" + txtBuydate.Text + "','" + rtbNote.Text + "', '" + getIdDevices.ToString() + "', '" + idPartment.ToString() + "',0)");
            var check = DataProvider.Instance.ExecuteNonQuery(query);
            if (check > 0)
            {
                MessageBox.Show("Insert Succes !!!");
                PDALoaddata();
            }
            else
            {
                MessageBox.Show("Faill !!!");
            }

        }
        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            int model = cbModel.Text.Length;
            int mac = txtMAC.Text.Length;
            int buydate = txtBuydate.Text.Length;
            int location = cbLocation.Text.Length;
            int factory = cbFactorys.Text.Length;
            int part = cbParts.Text.Length;
            int partment = cbPartment.Text.Length;
            int note = rtbNote.Text.Length;

            if (model == 0 || mac == 0 || buydate <= 0 || location <= 0 || factory <= 0 || part <= 0 || partment <= 0)
            {
                DialogResult dia = MessageBox.Show("Xin mời nhập đủ thông tin !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dia == DialogResult.Yes)
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

                var strUpdate = "update DeviceInfos set Model='" + cbModel.Text + "',idDevice='" + txtPDAName.Text + "',nameTypeDeviceInfos='" + txtPDAName.Text + "', IPAdress='" + txtIPPDA.Text + "',BuyDate='" + txtBuydate.Text + "',IdPartment='" + getIdPartmnet + "',Note ='"+rtbNote.Text+"' where id='" + txtid.Text + "'";
                var Updated = DataProvider.Instance.ExecuteNonQuery(strUpdate);
                if (Updated > 0)
                {
                    MessageBox.Show("Update Sucess !!!");
                    PDALoaddata();
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
                    PDALoaddata();
                }
                else
                {
                    MessageBox.Show("Delete Fall :(");
                }
            }
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
        private void cbLocation_Click(object sender, EventArgs e)
        {
            LoadLocation();
        }

        private void cbFactorys_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idFactory = this.cbFactorys.SelectedValue.ToString();
            LoadlistPartbyFactory(idFactory);
        }

        private void LoadlistPartbyFactory(string idFactory)
        {
            List<Part> lstPart = PartDAO.Instance.GetListPartByFactory(idFactory);
            cbParts.DataSource = lstPart;

            cbParts.DisplayMember = "PartName";
            cbParts.ValueMember = "Id";
        }

        private void cbParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbParts.SelectedValue != null)
            {
                var idPart = this.cbParts.SelectedValue.ToString();
                LoadPartmentbyPart(idPart);
            }
        }

        private void LoadPartmentbyPart(string idPart)
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
                var ip = txtIPPDA.Text;
                DateTime a = txtBuydate.Value;
                var location = cbLocation.Text;
                var codeName = "P2D";
                txtPDAName.Text = BuydateDAO.Instance.getBuyDate(ip, a, location, codeName);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập Ip");
                txtIPPDA.Focus();
            }
        }

        private void txtIPPDA_Leave(object sender, EventArgs e)
        {
            var a = txtIPPDA.Text;
            if (a.Length < 7 | a.Length > 15)
            {
                MessageBox.Show("The IP address must be in the form of 000.111.222.333");
                lbIpError.Show();
                txtIPPDA.Focus();
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

        private void txtIPPDA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            var a = txtIPPDA.Text;
            var b = Regex.IsMatch(a, @"\.");
        }

        private void txtSearchByPcName_Click(object sender, EventArgs e)
        {
            txtSearchByPcName.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String search = "select di.id,di.NameDevice, di.nameTypeDeviceInfos, di.IPAdress,di.MACAdress, di.Model, di.BuyDate, lc.NameLocation, fa.NameFactory, p.NamePart, pt.NamePartment, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.nameTypeDeviceInfos like '%" + txtSearchByPcName.Text + "%' and di.NameDevice='PDA 2D' and di.isDelete='0'";
                loadAndSearchData(search);

                txtSearchByPcName.Clear();
                txtMAC.Enabled = false;
                
            }
            catch
            {
                MessageBox.Show("Fall", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
