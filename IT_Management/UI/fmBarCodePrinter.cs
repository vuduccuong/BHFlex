using IT_Management.DAO;
using IT_Management.DTO;
using IT_Management.REPORT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace IT_Management.UI
{
    public partial class fmBarCodePrinter : Form
    {
        String str = "Select * from DeviceInfos";

        public fmBarCodePrinter()
        {
            InitializeComponent();
           
            //dtgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    
        }

        private void fmData_Load(object sender, EventArgs e)
        {
            cbSelectDevices.Text = "Select Devices";
            cbSelectDeviceInfoPC.Text = "Select DevicesInfo PC";
            cbSelectDeviceInfoPDA_Scanner.Text = "Select DevicesInfo PDA or Scanner";
            cbSelectDeviceInfoPrinter.Text = "Select DevicesInfo Printer";
            txtOption.Text = "Insert Option";
            //cbSelectDeviceInfoPC.Enabled = false;
            //cbSelectDeviceInfoPDA_Scanner.Enabled = false;
            //cbSelectDeviceInfoPrinter.Enabled = false;
            GetAllDeviceInfos(str);
        }

        private void GetAllDeviceInfos(String str)
        {
            //var query = "Select * from DeviceInfos";
            this.str = str;
            var tlbDeviceInfos = DataProvider.Instance.ExecuteQuery(str);

            TEST rp = new TEST();
            rp.SetDataSource(tlbDeviceInfos);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = "";
            var devices = cbSelectDevices.Text;
            var deviceInfo1 = cbSelectDeviceInfoPC.Text;
            var deviceInfo2 = cbSelectDeviceInfoPDA_Scanner.Text;
            var deviceInfo3 = cbSelectDeviceInfoPrinter.Text;

            String strDevices = "Select di.id, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice = '" + devices + "'";
            String strDeviceInfos1 = "Select di.id, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice = '" + devices + "' and di." + deviceInfo1 + " like '%" + txtOption.Text + "%'";
            String strDeviceInfos2 = "Select di.id, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice = '" + devices + "' and di." + deviceInfo2 + " like '%" + txtOption.Text + "%'";
            String strDeviceInfos3 = "Select di.id, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice = '" + devices + "' and di." + deviceInfo3 + " like '%" + txtOption.Text + "%'";

            if (deviceInfo1 == "NameLocation" || deviceInfo2 == "NameLocation" || deviceInfo3 == "NameLocation")
            {
                a = "lc";
            }
            else if (deviceInfo1 == "NameFactory" || deviceInfo2 == "NameFactory" || deviceInfo3 == "NameFactory")
            {
                a = "fa";
            }
            else if (deviceInfo1 == "NamePart" || deviceInfo2 == "NamePart" || deviceInfo3 == "NamePart")
            {
                a = "p";
            }
            else if (deviceInfo1 == "NamePartment" || deviceInfo2 == "NamePartment" || deviceInfo3 == "NamePartment")
            {
                a = "pt";
            }
            String strDeviceInfosPc = "Select di.id, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice = '" + devices + "' and "+a+"."+ deviceInfo1 + " like '%" + txtOption.Text + "%'";
            String strDeviceInfosPDA_Sc = "Select di.id, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice = '" + devices + "' and fa." + deviceInfo2 + " like'%" + txtOption.Text + "%'";
            String strDeviceInfosPrinter  = "Select di.id, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice = '" + devices + "' and p." + deviceInfo3 + " like '%" + txtOption.Text + "%'";
            

            switch (devices) {

                case "Desktop":
                    switch (deviceInfo1)
                    {
                        case "Name":
                            str = strDevices;//"Select di.id, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice = '" + devices + "'";
                            GetAllDeviceInfos(str);
                            break;
                        case "IPAdress":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "MACAdress":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "CPU":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "HDD":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "RAM":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "OS":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "BuyDate":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "Model":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameLocation":
                            str = strDeviceInfosPc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameFactory":
                            str = strDeviceInfosPc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePart":
                            str = strDeviceInfosPc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePartment":
                            str = strDeviceInfosPc;
                            GetAllDeviceInfos(str);
                            break;
                        default:
                            MessageBox.Show("Vui lòng chọn lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    break;

                case "Laptop":
                    switch (deviceInfo1)
                    {
                        case "Name":
                            str = strDevices;
                            GetAllDeviceInfos(str);
                            break;
                        case "IPAdress":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "MACAdress":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "CPU":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "HDD":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "RAM":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "OS":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "BuyDate":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "Model":
                            str = strDeviceInfos1;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameLocaiton":
                            str = strDeviceInfosPc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameFactory":
                            str = strDeviceInfosPc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePart":
                            str = strDeviceInfosPc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePartment":
                            str = strDeviceInfosPc;
                            GetAllDeviceInfos(str);
                            break;
                        default:
                            MessageBox.Show("Vui lòng chọn lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    break;

                case "PDA 1D":
                    switch (deviceInfo2)
                    {
                        case "Name":
                            str = strDevices;
                            GetAllDeviceInfos(str);
                            break;
                        case "IPAdress":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "MACAdress":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        
                        case "BuyDate":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "Model":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameLocaiton":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameFactory":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePart":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePartment":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;

                        default:
                            MessageBox.Show("Vui lòng chọn lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    break;
                case "PDA 2D":
                    switch (deviceInfo2)
                    {
                        case "Name":
                            str = strDevices;
                            GetAllDeviceInfos(str);
                            break;
                        case "IPAdress":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "MACAdress":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;

                        case "BuyDate":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "Model":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameLocaiton":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameFactory":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePart":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePartment":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;

                        default:
                            MessageBox.Show("Vui lòng chọn lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    break;
                case "Printer Ink":
                    switch (deviceInfo3)
                    {
                        case "Name":
                            str = strDevices;//"Select di.id, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice = '" + devices + "'";
                            GetAllDeviceInfos(str);
                            break;
                        case "IPAdress":
                            str = strDeviceInfos3;
                            GetAllDeviceInfos(str);
                            break;
                        case "MACAdress":
                            str = strDeviceInfos3;
                            GetAllDeviceInfos(str);
                            break;
                        case "BuyDate":
                            str = strDeviceInfos3;
                            GetAllDeviceInfos(str);
                            break;
                        case "Model":
                            str = strDeviceInfos3;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameLocation":
                            str = strDeviceInfosPrinter;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameFactory":
                            str = strDeviceInfosPrinter;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePart":
                            str = strDeviceInfosPrinter;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePartment":
                            str = strDeviceInfosPrinter;
                            GetAllDeviceInfos(str);
                            break;
                        default:
                            MessageBox.Show("Vui lòng chọn lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    break;
                case "Printer Laser":
                    switch (deviceInfo3)
                    {
                        case "Name":
                            str = strDevices;//"Select di.id, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice = '" + devices + "'";
                            GetAllDeviceInfos(str);
                            break;
                        case "IPAdress":
                            str = strDeviceInfos3;
                            GetAllDeviceInfos(str);
                            break;
                        case "MACAdress":
                            str = strDeviceInfos3;
                            GetAllDeviceInfos(str);
                            break;
                        case "BuyDate":
                            str = strDeviceInfos3;
                            GetAllDeviceInfos(str);
                            break;
                        case "Model":
                            str = strDeviceInfos3;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameLocation":
                            str = strDeviceInfosPrinter;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameFactory":
                            str = strDeviceInfosPrinter;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePart":
                            str = strDeviceInfosPrinter;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePartment":
                            str = strDeviceInfosPrinter;
                            GetAllDeviceInfos(str);
                            break;
                        default:
                            MessageBox.Show("Vui lòng chọn lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    break;
                case "Printer Photo Copy":
                    switch (deviceInfo3)
                    {
                        case "Name":
                            str = strDevices;//"Select di.id, di.idDevice, di.NameUser,di.nameTypeDeviceInfos, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation, di.note from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice = '" + devices + "'";
                            GetAllDeviceInfos(str);
                            break;
                        case "IPAdress":
                            str = strDeviceInfos3;
                            GetAllDeviceInfos(str);
                            break;
                        case "MACAdress":
                            str = strDeviceInfos3;
                            GetAllDeviceInfos(str);
                            break;
                        case "BuyDate":
                            str = strDeviceInfos3;
                            GetAllDeviceInfos(str);
                            break;
                        case "Model":
                            str = strDeviceInfos3;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameLocation":
                            str = strDeviceInfosPrinter;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameFactory":
                            str = strDeviceInfosPrinter;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePart":
                            str = strDeviceInfosPrinter;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePartment":
                            str = strDeviceInfosPrinter;
                            GetAllDeviceInfos(str);
                            break;
                        default:
                            MessageBox.Show("Vui lòng chọn lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    break;
                case "Barcode Scanner 1D":
                    switch (deviceInfo2)
                    {
                        case "Name":
                            str = strDevices;
                            GetAllDeviceInfos(str);
                            break;
                        case "IPAdress":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "MACAdress":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "BuyDate":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "Model":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameLocaiton":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameFactory":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePart":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePartment":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;

                        default:
                            MessageBox.Show("Vui lòng chọn lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    break;

                case "Barcode Scanner 2D":
                    switch (deviceInfo2)
                    {
                        case "Name":
                            str = strDevices;
                            GetAllDeviceInfos(str);
                            break;
                        case "IPAdress":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "MACAdress":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;

                        case "BuyDate":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "Model":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameLocaiton":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameFactory":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePart":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePartment":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;

                        default:
                            MessageBox.Show("Vui lòng chọn lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    break;

                case "Barcode Scanner Wifi 2D":
                    switch (deviceInfo2)
                    {
                        case "Name":
                            str = strDevices;
                            GetAllDeviceInfos(str);
                            break;
                        case "IPAdress":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "MACAdress":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;

                        case "BuyDate":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "Model":
                            str = strDeviceInfos2;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameLocaiton":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NameFactory":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePart":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;
                        case "NamePartment":
                            str = strDeviceInfosPDA_Sc;
                            GetAllDeviceInfos(str);
                            break;

                        default:
                            MessageBox.Show("Vui lòng chọn lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    break;

                default:
                    MessageBox.Show("Vui lòng chọn lại", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    break;

            }
            #region
            //if (cbSelectDevices.Text == "Desktop")
            //{
            //    switch (a)
            //    {
            //        case "Pc Name":
            //            str = "Select * from DeviceInfos where NameDevice = '"+cbSelectDevices.Text+"'";
            //            GetAllDeviceInfos(str);
            //            break;
            //        case "RAM":
            //            str = "Select * from DeviceInfos where NameDevice = '" + cbSelectDevices.Text + "' and RAM ='"+txtOption.Text+"'";
            //            GetAllDeviceInfos(str);
            //            break;
            //    }

            //}
            //else if (cbSelectDevices.Text == "Laptop") {
            //    str = "Select * from DeviceInfos where NameDevice = 'Laptop'";
            //    GetAllDeviceInfos(str);
            //}
            #endregion
        }

        private void cbSelectDevices_Click(object sender, EventArgs e)
        {
            cbSelectDevices.Text = "";
        }

        private void cbSelectDeviceInfo_Click(object sender, EventArgs e)
        {
            cbSelectDeviceInfoPC.Text = "";
        }

        private void txtOption_Click(object sender, EventArgs e)
        {
            txtOption.Clear();
        }

        private void cbSelectDeviceInfoPDA_Scanner_Click(object sender, EventArgs e)
        {
            cbSelectDeviceInfoPDA_Scanner.Text = "";
        }

        private void cbSelectDeviceInfoPrinter_Click(object sender, EventArgs e)
        {
            cbSelectDeviceInfoPrinter.Text = "";
        }

        private void cbSelectDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbSelectDevices.Text == "Desktop" || this.cbSelectDevices.Text == "Laptop")
            {
                cbSelectDeviceInfoPC.Enabled = true;
                cbSelectDeviceInfoPDA_Scanner.Enabled = false;
                cbSelectDeviceInfoPrinter.Enabled = false;
            }
            if (this.cbSelectDevices.Text == "PDA 1D" || this.cbSelectDevices.Text == "PDA 2D"
                || this.cbSelectDevices.Text == "Barcode Scanner 1D" || this.cbSelectDevices.Text == "Barcode Scanner 2D"
                || this.cbSelectDevices.Text == "Barcode Scanner Wifi 2D")
            {
                cbSelectDeviceInfoPDA_Scanner.Enabled = true;
                cbSelectDeviceInfoPrinter.Enabled = false;
                cbSelectDeviceInfoPC.Enabled = false;
            }
            if (this.cbSelectDevices.Text == "Printer Ink" || this.cbSelectDevices.Text == "Printer Laser"
                || this.cbSelectDevices.Text == "Printer Photo Copy")
            {
                cbSelectDeviceInfoPrinter.Enabled = true;
                cbSelectDeviceInfoPDA_Scanner.Enabled = false;
                cbSelectDeviceInfoPC.Enabled = false;
            }
        }

        private void cbSelectDeviceInfoPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectDeviceInfoPC.Text == "Name")
            {
                txtOption.Enabled = false;
            }
            else
                txtOption.Enabled = true;
        }

        private void cbSelectDeviceInfoPDA_Scanner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectDeviceInfoPDA_Scanner.Text == "Name")
            {
                txtOption.Enabled = false;
            }
            else
                txtOption.Enabled = true;
        }

        private void cbSelectDeviceInfoPrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectDeviceInfoPrinter.Text == "Name")
            {
                txtOption.Enabled = false;
            }
            else
                txtOption.Enabled = true;
        }
    }
}