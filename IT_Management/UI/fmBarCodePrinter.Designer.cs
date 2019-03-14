namespace IT_Management.UI
{
    partial class fmBarCodePrinter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSelectDevices = new System.Windows.Forms.ComboBox();
            this.cbSelectDeviceInfoPC = new System.Windows.Forms.ComboBox();
            this.txtOption = new System.Windows.Forms.TextBox();
            this.cbSelectDeviceInfoPDA_Scanner = new System.Windows.Forms.ComboBox();
            this.cbSelectDeviceInfoPrinter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(6, 134);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1142, 560);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(831, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSelectDevices
            // 
            this.cbSelectDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectDevices.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cbSelectDevices.FormattingEnabled = true;
            this.cbSelectDevices.Items.AddRange(new object[] {
            "Desktop",
            "Laptop",
            "PDA 1D",
            "PDA 2D",
            "Printer Ink",
            "Printer Laser",
            "Printer Photo Copy",
            "Barcode Scanner 1D",
            "Barcode Scanner 2D",
            "Barcode Scanner Wifi 2D"});
            this.cbSelectDevices.Location = new System.Drawing.Point(216, 23);
            this.cbSelectDevices.Name = "cbSelectDevices";
            this.cbSelectDevices.Size = new System.Drawing.Size(169, 24);
            this.cbSelectDevices.TabIndex = 2;
            this.cbSelectDevices.SelectedIndexChanged += new System.EventHandler(this.cbSelectDevices_SelectedIndexChanged);
            this.cbSelectDevices.Click += new System.EventHandler(this.cbSelectDevices_Click);
            // 
            // cbSelectDeviceInfoPC
            // 
            this.cbSelectDeviceInfoPC.Enabled = false;
            this.cbSelectDeviceInfoPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectDeviceInfoPC.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cbSelectDeviceInfoPC.FormattingEnabled = true;
            this.cbSelectDeviceInfoPC.Items.AddRange(new object[] {
            "Name",
            "IPAdress",
            "MACAdress",
            "CPU",
            "RAM",
            "HDD",
            "OS",
            "BuyDate",
            "Model",
            "NameLocation",
            "NameFactory",
            "NamePart",
            "NamePartment"});
            this.cbSelectDeviceInfoPC.Location = new System.Drawing.Point(407, 23);
            this.cbSelectDeviceInfoPC.Name = "cbSelectDeviceInfoPC";
            this.cbSelectDeviceInfoPC.Size = new System.Drawing.Size(169, 24);
            this.cbSelectDeviceInfoPC.TabIndex = 3;
            this.cbSelectDeviceInfoPC.SelectedIndexChanged += new System.EventHandler(this.cbSelectDeviceInfoPC_SelectedIndexChanged);
            this.cbSelectDeviceInfoPC.Click += new System.EventHandler(this.cbSelectDeviceInfo_Click);
            // 
            // txtOption
            // 
            this.txtOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOption.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtOption.Location = new System.Drawing.Point(596, 23);
            this.txtOption.Name = "txtOption";
            this.txtOption.Size = new System.Drawing.Size(168, 24);
            this.txtOption.TabIndex = 5;
            this.txtOption.Click += new System.EventHandler(this.txtOption_Click);
            // 
            // cbSelectDeviceInfoPDA_Scanner
            // 
            this.cbSelectDeviceInfoPDA_Scanner.Enabled = false;
            this.cbSelectDeviceInfoPDA_Scanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectDeviceInfoPDA_Scanner.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cbSelectDeviceInfoPDA_Scanner.FormattingEnabled = true;
            this.cbSelectDeviceInfoPDA_Scanner.Items.AddRange(new object[] {
            "Name",
            "IPAdress",
            "MACAdress",
            "BuyDate",
            "Model",
            "NameLocation",
            "NameFactory",
            "NamePart",
            "NamePartment"});
            this.cbSelectDeviceInfoPDA_Scanner.Location = new System.Drawing.Point(407, 58);
            this.cbSelectDeviceInfoPDA_Scanner.Name = "cbSelectDeviceInfoPDA_Scanner";
            this.cbSelectDeviceInfoPDA_Scanner.Size = new System.Drawing.Size(169, 24);
            this.cbSelectDeviceInfoPDA_Scanner.TabIndex = 6;
            this.cbSelectDeviceInfoPDA_Scanner.SelectedIndexChanged += new System.EventHandler(this.cbSelectDeviceInfoPDA_Scanner_SelectedIndexChanged);
            this.cbSelectDeviceInfoPDA_Scanner.Click += new System.EventHandler(this.cbSelectDeviceInfoPDA_Scanner_Click);
            // 
            // cbSelectDeviceInfoPrinter
            // 
            this.cbSelectDeviceInfoPrinter.Enabled = false;
            this.cbSelectDeviceInfoPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectDeviceInfoPrinter.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cbSelectDeviceInfoPrinter.FormattingEnabled = true;
            this.cbSelectDeviceInfoPrinter.Items.AddRange(new object[] {
            "Name",
            "IPAdress",
            "MACAdress",
            "BuyDate",
            "Model",
            "NameLocation",
            "NameFactory",
            "NamePart",
            "NamePartment"});
            this.cbSelectDeviceInfoPrinter.Location = new System.Drawing.Point(407, 92);
            this.cbSelectDeviceInfoPrinter.Name = "cbSelectDeviceInfoPrinter";
            this.cbSelectDeviceInfoPrinter.Size = new System.Drawing.Size(169, 24);
            this.cbSelectDeviceInfoPrinter.TabIndex = 7;
            this.cbSelectDeviceInfoPrinter.SelectedIndexChanged += new System.EventHandler(this.cbSelectDeviceInfoPrinter_SelectedIndexChanged);
            this.cbSelectDeviceInfoPrinter.Click += new System.EventHandler(this.cbSelectDeviceInfoPrinter_Click);
            // 
            // fmBarCodePrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1160, 695);
            this.Controls.Add(this.cbSelectDeviceInfoPrinter);
            this.Controls.Add(this.cbSelectDeviceInfoPDA_Scanner);
            this.Controls.Add(this.txtOption);
            this.Controls.Add(this.cbSelectDeviceInfoPC);
            this.Controls.Add(this.cbSelectDevices);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fmBarCodePrinter";
            this.Text = "fmData";
            this.Load += new System.EventHandler(this.fmData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSelectDevices;
        private System.Windows.Forms.ComboBox cbSelectDeviceInfoPC;
        private System.Windows.Forms.TextBox txtOption;
        private System.Windows.Forms.ComboBox cbSelectDeviceInfoPDA_Scanner;
        private System.Windows.Forms.ComboBox cbSelectDeviceInfoPrinter;

        #endregion
        //private DevComponents.DotNetBar.Controls.DataGridViewX dtgData;
    }
}