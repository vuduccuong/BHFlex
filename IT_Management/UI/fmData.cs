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
    public partial class fmData : Form
    {

        public fmData()
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

            RPDeviceInfo rp = new RPDeviceInfo();
            rp.SetDataSource(tlbDeviceInfos);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.RefreshReport();

        }
    }
}