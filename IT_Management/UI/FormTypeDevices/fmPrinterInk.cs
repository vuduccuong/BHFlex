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
    public partial class fmPrinterInk : Form
    {
        public fmPrinterInk()
        {
            InitializeComponent();
        }

        private void fmPrinterInk_Load(object sender, EventArgs e)
        {
            printerLoaddata();
        }
        public void printerLoaddata()
        {// di.IdDevice
            String strLoaddata = "select di.id,di.NameDevice, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.IPAdress, di.BuyDate, di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice='" + txtTypeDiveces.Text + "' and di.isDelete='0'";
            DataTable datable = DataProvider.Instance.ExecuteQuery(strLoaddata);
            dgvPCDesktop.DataSource = datable;
            #region ClearDataBindings
            txtid.DataBindings.Clear();
            txtIdPrinter.DataBindings.Clear();
            txtUserName.DataBindings.Clear();
            txtPrinterName.DataBindings.Clear();
            cbLocation.DataBindings.Clear();
            cbFactorys.DataBindings.Clear();
            cbParts.DataBindings.Clear();
            cbPartment.DataBindings.Clear();
            txtModel.DataBindings.Clear();
            txtIPPrinter.DataBindings.Clear();
            txtBuydate.DataBindings.Clear();
            #endregion
            #region DataBindinds
            txtid.DataBindings.Add("text",datable,"id");
            txtIdPrinter.DataBindings.Add("text", datable, "idDevice");
            txtUserName.DataBindings.Add("text", datable, "NameUser");
            txtPrinterName.DataBindings.Add("text", datable, "nameTypeDeviceInfos");
            cbLocation.DataBindings.Add("text", datable, "NameLocation");
            cbFactorys.DataBindings.Add("text", datable, "NameFactory");
            cbParts.DataBindings.Add("text", datable, "NamePart");
            cbPartment.DataBindings.Add("text", datable, "NamePartment");
            txtModel.DataBindings.Add("text", datable, "Model");
            txtIPPrinter.DataBindings.Add("text", datable, "IPAdress");
            txtBuydate.DataBindings.Add("text", datable, "BuyDate");
            #endregion
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

        private void cbFactorys_SelectedIndexChanged_1(object sender, EventArgs e)
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
            LoadListPartmentByPart(idPart);
        }
        private void LoadListPartmentByPart(string idPart)
        {
            List<Partment> lstPartment = PartmentDAO.Instance.GetListPartmentByPart(idPart);
            cbPartment.DataSource = lstPartment;

            cbPartment.DisplayMember = "PartmentName";
            cbPartment.ValueMember = "Id";
        }

        private void txtBuydate_Leave(object sender, EventArgs e)
        {
            String lastIp = null;
            string[] listPara = txtIPPrinter.Text.ToString().Split('.');
            lastIp += listPara[2];
            lastIp += listPara[3];
            var a = txtBuydate.Value;
            var setBuydate = (String.Format("{0:yy/MM}", a)).Replace("-", "");


            String CodeLocation = "select CodeLocation from Locations where NameLocation ='" + cbLocation.Text + "'";
            var getCodeLocation = DataProvider.Instance.ExecuteQuery(CodeLocation);
            string name = getCodeLocation.Rows[0][0].ToString();

            txtIdPrinter.Text = (String.Format(name + "PR" + lastIp + setBuydate));
            txtPrinterName.Text = (String.Format(name + "PR" + lastIp + setBuydate));
        }

        private void btnNew_Click_2(object sender, EventArgs e)
        {
            #region Enabled=true
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            cbFactorys.Enabled = true;
            cbParts.Enabled = true;
            cbPartment.Enabled = true;
            cbLocation.Enabled = true;
            txtUserName.Enabled = true;
            txtIPPrinter.Enabled = true;
            txtModel.Enabled = true;
            txtBuydate.Enabled = true;
            #endregion
            txtIdPrinter.Clear();
            txtUserName.Clear();
            txtPrinterName.Clear();
            cbLocation.Text = "-- Select location --";
            cbFactorys.Text = "";
            cbParts.Text = "";
            cbPartment.Text = "";
            txtModel.Clear();
            txtIPPrinter.Clear();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            var strDelete = String.Format("update DeviceInfos set isDelete=1 where Id='" + txtid.Text + "'");
            var Delete = DataProvider.Instance.ExecuteNonQuery(strDelete);
            if (Delete > 0)
            {
                MessageBox.Show("Delete Sucess !!!");
                printerLoaddata();
            }
            else
            {
                MessageBox.Show("Delete Fall :(");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            var strSelectIdPartmet = "select Partments.id from DeviceInfos left join Partments on Partments.id = DeviceInfos.idPartment where Partments.NamePartment='" + cbPartment.Text + "'";
            var idPartment = DataProvider.Instance.ExecuteQuery(strSelectIdPartmet);
            String getIdPartmnet = idPartment.Rows[0][0].ToString();

            var strUpdate = "update DeviceInfos set NameUser='" + txtUserName.Text + "',IPAdress='" + txtIPPrinter.Text + "',Model='" + txtModel.Text + "',BuyDate='" + txtBuydate.Text + "',IdPartment='" + getIdPartmnet.ToString() + "' where id='" + txtid.Text + "'";
            var Updated = DataProvider.Instance.ExecuteNonQuery(strUpdate);
            if (Updated > 0)
            {
                MessageBox.Show("Update Sucess !!!");
                printerLoaddata();
            }
            else
            {
                MessageBox.Show("Update Fall \nLỗi lòi mắt rồi :(");
            }
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            var strIdDevices = String.Format("select Id from TypeDevices where NameDeviceType='" + txtTypeDiveces.Text + "'");
            var IdDevice = DataProvider.Instance.ExecuteQuery(strIdDevices);
            String getIdDevices = IdDevice.Rows[0][0].ToString();

            var idPartment = cbPartment.SelectedValue.ToString();

            var query = String.Format("insert into DeviceInfos(IdDevice,NameDevice,NameUser,nameTypeDeviceInfos,IPAdress,Model,BuyDate,idDeviceType,IdPartment,isDelete) values('" + txtIdPrinter.Text + "', '" + txtTypeDiveces.Text + "', '" + txtUserName.Text + "','" + txtPrinterName.Text + "','" + txtIPPrinter.Text + "', '" + txtModel.Text + "', '" + txtBuydate.Text + "', '" + getIdDevices.ToString() + "', '" + idPartment.ToString() + "',0)");
            var check = DataProvider.Instance.ExecuteNonQuery(query);
            if (check > 0)
            {
                MessageBox.Show("Succes !!!");
                printerLoaddata();
            }
            else
            {
                MessageBox.Show("Error !!!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
