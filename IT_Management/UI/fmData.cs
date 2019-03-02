using IT_Management.DAO;
using IT_Management.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IT_Management.UI
{
    public partial class fmData : Form
    {
        public fmData()
        {
            InitializeComponent();
            button1.Text = "Load Data";
            dtgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //
        }

        private void fmData_Load(object sender, EventArgs e)
        {
            //LoadCustommer();
        }

        private void LoadCustommer()
        {
            List<Custommer> lstCustommer = CustommerDAO.Instance.GetListCustommer();
            if (lstCustommer.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
            }
            dtgData.DataSource = lstCustommer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadCustommer();
        }
    }
}