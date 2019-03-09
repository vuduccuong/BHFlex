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

        public fmBarCodePrinter()
        {
            InitializeComponent();
           
            //dtgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    
        }

        private void fmData_Load(object sender, EventArgs e)
        {
            GetAllDeviceInfos();
        }

        private void GetAllDeviceInfos()
        {
            var query = "Select * from DeviceInfos";
            
           var tlbDeviceInfos = DataProvider.Instance.ExecuteQuery(query);

            TEST rp = new TEST();
            rp.SetDataSource(tlbDeviceInfos);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.RefreshReport();

        }
    }
}