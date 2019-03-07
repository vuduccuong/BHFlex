﻿using IT_Management.DAO;
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
    public partial class fmBarScanner2D : Form
    {
        public fmBarScanner2D()
        {
            InitializeComponent();
        }

        private void fmBarScanner2D_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            txtBarcodeScannerName.Enabled = false;
            txtIPBarcodeScanner.Enabled = false;
            txtModel.Enabled = false;
            cbLocation.Enabled = false;
            cbFactorys.Enabled = false;
            cbParts.Enabled = false;
            cbPartment.Enabled = false;
            rtbNote.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            BarcodeScannerLoaddata();
        }
        public void BarcodeScannerLoaddata()
        {
            String strLoaddata = "select di.id,di.NameDevice, di.nameTypeDeviceInfos, di.IPAdress, di.Model, di.BuyDate, lc.NameLocation, fa.NameFactory, p.NamePart, pt.NamePartment, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice='Barcode Scanner 2D' and di.isDelete='0'";
            DataTable datable = DataProvider.Instance.ExecuteQuery(strLoaddata);
            dgvPDA1D.DataSource = datable;

            #region ClearDataBindings
            txtid.DataBindings.Clear();
            txtBarcodeScannerName.DataBindings.Clear();
            txtIPBarcodeScanner.DataBindings.Clear();
            txtModel.DataBindings.Clear();
            rtbNote.DataBindings.Clear();
            cbLocation.DataBindings.Clear();
            cbFactorys.DataBindings.Clear();
            cbParts.DataBindings.Clear();
            cbPartment.DataBindings.Clear();

            #endregion
            #region DataBindinds
            txtid.DataBindings.Add("text", datable, "id");
            txtBarcodeScannerName.DataBindings.Add("text", datable, "nameTypeDeviceInfos");
            txtIPBarcodeScanner.DataBindings.Add("text", datable, "IPAdress");
            txtModel.DataBindings.Add("text", datable, "Model");
            rtbNote.DataBindings.Add("text", datable, "Note");
            cbLocation.DataBindings.Add("text", datable, "NameLocation");
            cbFactorys.DataBindings.Add("text", datable, "NameFactory");
            cbParts.DataBindings.Add("text", datable, "NamePart");
            cbPartment.DataBindings.Add("text", datable, "NamePartment");
            #endregion
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cbLocation.Text = "-- Select location --";
            cbFactorys.Text = "";
            cbParts.Text = "";
            cbPartment.Text = "";
            txtBarcodeScannerName.Clear();
            txtModel.Clear();
            txtIPBarcodeScanner.Clear();
            rtbNote.Clear();

            txtIPBarcodeScanner.Enabled = true;
            txtModel.Enabled = true;
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

        private void txtBuydate_Leave(object sender, EventArgs e)
        {
            String lastIp = null;
            string[] listPara = txtIPBarcodeScanner.Text.ToString().Split('.');
            lastIp += listPara[2];
            lastIp += listPara[3];
            var a = txtBuydate.Value;
            var setBuydate = (String.Format("{0:yy/MM}", a)).Replace("-", "");


            String CodeLocation = "select CodeLocation from Locations where NameLocation ='" + cbLocation.Text + "'";
            var getCodeLocation = DataProvider.Instance.ExecuteQuery(CodeLocation);
            string name = getCodeLocation.Rows[0][0].ToString();

            txtBarcodeScannerName.Text = (String.Format(name + "P1D" + lastIp + setBuydate));
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
            // load Location
            List<Location> lstLocation = LocationDAO.Instance.GetListCustommer();
            if (lstLocation.Count == 0)
            {
                MessageBox.Show("No data in Location!");
            }

            cbLocation.DataSource = lstLocation;
            cbLocation.DisplayMember = "LocationName";
            cbLocation.ValueMember = "Id";
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var strIdDevices = String.Format("select id from TypeDevices where NameDeviceType='Barcode Scanner 2D'");
            var IdDevice = DataProvider.Instance.ExecuteQuery(strIdDevices);
            String getIdDevices = IdDevice.Rows[0][0].ToString();

            var idPartment = cbPartment.SelectedValue.ToString();

            var query = String.Format("insert into DeviceInfos(IdDevice,nameTypeDeviceInfos,NameDevice,IPAdress,Model,BuyDate,Note,idDeviceType,IdPartment,isDelete) values('" + txtBarcodeScannerName.Text + "','" + txtBarcodeScannerName.Text + "','Barcode Scanner 2D','" + txtIPBarcodeScanner.Text + "', '" + txtModel.Text + "', '" + txtBuydate.Text + "','" + rtbNote.Text + "', '" + getIdDevices.ToString() + "', '" + idPartment.ToString() + "',0)");
            var check = DataProvider.Instance.ExecuteNonQuery(query);
            if (check > 0)
            {
                MessageBox.Show("Insert Succes !!!");
                BarcodeScannerLoaddata();
            }
            else
            {
                MessageBox.Show("Faill !!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var strSelectIdPartmet = "select Partments.id from DeviceInfos left join Partments on Partments.id = DeviceInfos.idPartment where Partments.NamePartment='" + cbPartment.Text + "'";
            var idPartment = DataProvider.Instance.ExecuteQuery(strSelectIdPartmet);
            String getIdPartmnet = idPartment.Rows[0][0].ToString();

            var strUpdate = "update DeviceInfos set Model='" + txtModel.Text + "',idDevice='" + txtBarcodeScannerName.Text + "',nameTypeDeviceInfos='" + txtBarcodeScannerName.Text + "', IPAdress='" + txtIPBarcodeScanner.Text + "',BuyDate='" + txtBuydate.Text + "',IdPartment='" + getIdPartmnet + "' where id='" + txtid.Text + "'";
            var Updated = DataProvider.Instance.ExecuteNonQuery(strUpdate);
            if (Updated > 0)
            {
                MessageBox.Show("Update Sucess !!!");
                BarcodeScannerLoaddata();
            }
            else
            {
                MessageBox.Show("Update Fall \nLỗi lòi mắt rồi :(");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var strDelete = String.Format("update DeviceInfos set isDelete=1 where Id='" + txtid.Text + "'");
            var Delete = DataProvider.Instance.ExecuteNonQuery(strDelete);
            if (Delete > 0)
            {
                MessageBox.Show("Delete Sucess !!!");
                BarcodeScannerLoaddata();
            }
            else
            {
                MessageBox.Show("Delete Fall :(");
            }
        }
    }
}
