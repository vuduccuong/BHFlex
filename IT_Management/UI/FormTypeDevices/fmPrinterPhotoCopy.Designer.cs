namespace IT_Management.UI.FormTypeDevices
{
    partial class fmPrinterPhotoCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPrinterPhotoCopy));
            this.dgvPCDesktop = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.txtBuydate = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtTypeDiveces = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.têt = new System.Windows.Forms.Label();
            this.cbFactorys = new System.Windows.Forms.ComboBox();
            this.cbParts = new System.Windows.Forms.ComboBox();
            this.cbPartment = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtIPPrinter = new System.Windows.Forms.TextBox();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtIdPrinter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPartment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.lbMACError = new System.Windows.Forms.Label();
            this.lbIpError = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCDesktop)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPCDesktop
            // 
            this.dgvPCDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPCDesktop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPCDesktop.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvPCDesktop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPCDesktop.Location = new System.Drawing.Point(3, 339);
            this.dgvPCDesktop.Name = "dgvPCDesktop";
            this.dgvPCDesktop.Size = new System.Drawing.Size(1110, 339);
            this.dgvPCDesktop.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(425, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 49;
            this.label15.Text = "Model";
            // 
            // cbLocation
            // 
            this.cbLocation.CausesValidation = false;
            this.cbLocation.Enabled = false;
            this.cbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(534, 72);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(168, 26);
            this.cbLocation.TabIndex = 3;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cbLocation_SelectedIndexChanged);
            this.cbLocation.Click += new System.EventHandler(this.cbLocation_Click);
            // 
            // txtBuydate
            // 
            this.txtBuydate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuydate.CustomFormat = "yyyy/MM/dd";
            this.txtBuydate.Enabled = false;
            this.txtBuydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBuydate.Location = new System.Drawing.Point(534, 280);
            this.txtBuydate.Name = "txtBuydate";
            this.txtBuydate.Size = new System.Drawing.Size(168, 26);
            this.txtBuydate.TabIndex = 8;
            this.txtBuydate.Value = new System.DateTime(2019, 3, 4, 15, 59, 37, 0);
            this.txtBuydate.Leave += new System.EventHandler(this.txtBuydate_Leave);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Tomato;
            this.btnNew.Image = global::IT_Management.Properties.Resources.icon3;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(795, 193);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(272, 44);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtTypeDiveces
            // 
            this.txtTypeDiveces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeDiveces.Location = new System.Drawing.Point(182, 72);
            this.txtTypeDiveces.Name = "txtTypeDiveces";
            this.txtTypeDiveces.ReadOnly = true;
            this.txtTypeDiveces.Size = new System.Drawing.Size(168, 26);
            this.txtTypeDiveces.TabIndex = 0;
            this.txtTypeDiveces.Text = "Printer Photo Copy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Name Devices";
            // 
            // têt
            // 
            this.têt.AutoSize = true;
            this.têt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.têt.Location = new System.Drawing.Point(425, 282);
            this.têt.Name = "têt";
            this.têt.Size = new System.Drawing.Size(75, 20);
            this.têt.TabIndex = 43;
            this.têt.Text = "Buy Date";
            // 
            // cbFactorys
            // 
            this.cbFactorys.Enabled = false;
            this.cbFactorys.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFactorys.FormattingEnabled = true;
            this.cbFactorys.Location = new System.Drawing.Point(534, 114);
            this.cbFactorys.Name = "cbFactorys";
            this.cbFactorys.Size = new System.Drawing.Size(168, 26);
            this.cbFactorys.TabIndex = 4;
            this.cbFactorys.SelectedIndexChanged += new System.EventHandler(this.cbFactorys_SelectedIndexChanged);
            // 
            // cbParts
            // 
            this.cbParts.Enabled = false;
            this.cbParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParts.FormattingEnabled = true;
            this.cbParts.Location = new System.Drawing.Point(534, 156);
            this.cbParts.Name = "cbParts";
            this.cbParts.Size = new System.Drawing.Size(168, 26);
            this.cbParts.TabIndex = 5;
            this.cbParts.SelectedIndexChanged += new System.EventHandler(this.cbParts_SelectedIndexChanged);
            // 
            // cbPartment
            // 
            this.cbPartment.Enabled = false;
            this.cbPartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPartment.FormattingEnabled = true;
            this.cbPartment.Location = new System.Drawing.Point(534, 198);
            this.cbPartment.Name = "cbPartment";
            this.cbPartment.Size = new System.Drawing.Size(168, 26);
            this.cbPartment.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(894, 249);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 57);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(992, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 57);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(795, 249);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 57);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtIPPrinter
            // 
            this.txtIPPrinter.Enabled = false;
            this.txtIPPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPPrinter.Location = new System.Drawing.Point(182, 240);
            this.txtIPPrinter.Name = "txtIPPrinter";
            this.txtIPPrinter.Size = new System.Drawing.Size(168, 26);
            this.txtIPPrinter.TabIndex = 1;
            this.txtIPPrinter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIPPrinter_KeyPress);
            this.txtIPPrinter.Leave += new System.EventHandler(this.txtIPPrinter_Leave);
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrinterName.Location = new System.Drawing.Point(182, 198);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.ReadOnly = true;
            this.txtPrinterName.Size = new System.Drawing.Size(168, 26);
            this.txtPrinterName.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(182, 156);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 26);
            this.txtUserName.TabIndex = 0;
            // 
            // txtIdPrinter
            // 
            this.txtIdPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPrinter.Location = new System.Drawing.Point(182, 114);
            this.txtIdPrinter.Name = "txtIdPrinter";
            this.txtIdPrinter.ReadOnly = true;
            this.txtIdPrinter.Size = new System.Drawing.Size(168, 26);
            this.txtIdPrinter.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "IP Printer";
            // 
            // labelPartment
            // 
            this.labelPartment.AutoSize = true;
            this.labelPartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartment.Location = new System.Drawing.Point(425, 200);
            this.labelPartment.Name = "labelPartment";
            this.labelPartment.Size = new System.Drawing.Size(74, 20);
            this.labelPartment.TabIndex = 7;
            this.labelPartment.Text = "Partment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Parts";
            // 
            // gr
            // 
            this.gr.AutoSize = true;
            this.gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr.Location = new System.Drawing.Point(425, 74);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(70, 20);
            this.gr.TabIndex = 5;
            this.gr.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Factorys";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Printer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Printer";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rtbNote);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.cbModel);
            this.panel1.Controls.Add(this.lbMACError);
            this.panel1.Controls.Add(this.lbIpError);
            this.panel1.Controls.Add(this.txtMAC);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cbLocation);
            this.panel1.Controls.Add(this.txtBuydate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.txtTypeDiveces);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.têt);
            this.panel1.Controls.Add(this.cbFactorys);
            this.panel1.Controls.Add(this.cbParts);
            this.panel1.Controls.Add(this.cbPartment);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.txtIPPrinter);
            this.panel1.Controls.Add(this.txtPrinterName);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtIdPrinter);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.labelPartment);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.gr);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 335);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rtbNote
            // 
            this.rtbNote.Enabled = false;
            this.rtbNote.Location = new System.Drawing.Point(795, 72);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(272, 102);
            this.rtbNote.TabIndex = 9;
            this.rtbNote.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(736, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 20);
            this.label17.TabIndex = 108;
            this.label17.Text = "Note";
            // 
            // cbModel
            // 
            this.cbModel.Enabled = false;
            this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Items.AddRange(new object[] {
            "HP",
            "Dell",
            "Asus",
            "LG",
            "Motorola"});
            this.cbModel.Location = new System.Drawing.Point(534, 241);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(168, 26);
            this.cbModel.TabIndex = 7;
            // 
            // lbMACError
            // 
            this.lbMACError.AutoSize = true;
            this.lbMACError.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMACError.ForeColor = System.Drawing.Color.Red;
            this.lbMACError.Location = new System.Drawing.Point(356, 285);
            this.lbMACError.Name = "lbMACError";
            this.lbMACError.Size = new System.Drawing.Size(29, 37);
            this.lbMACError.TabIndex = 69;
            this.lbMACError.Text = "*";
            // 
            // lbIpError
            // 
            this.lbIpError.AutoSize = true;
            this.lbIpError.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIpError.ForeColor = System.Drawing.Color.Red;
            this.lbIpError.Location = new System.Drawing.Point(356, 243);
            this.lbIpError.Name = "lbIpError";
            this.lbIpError.Size = new System.Drawing.Size(29, 37);
            this.lbIpError.TabIndex = 68;
            this.lbIpError.Text = "*";
            // 
            // txtMAC
            // 
            this.txtMAC.Enabled = false;
            this.txtMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAC.Location = new System.Drawing.Point(182, 280);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(168, 26);
            this.txtMAC.TabIndex = 2;
            this.txtMAC.Leave += new System.EventHandler(this.txtMAC_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "MAC";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(626, 245);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(76, 20);
            this.txtid.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(435, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 31);
            this.label4.TabIndex = 50;
            this.label4.Text = "Printer Photo Copy";
            // 
            // fmPrinterPhotoCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1113, 637);
            this.Controls.Add(this.dgvPCDesktop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmPrinterPhotoCopy";
            this.Text = "Printer Photo Copy";
            this.Load += new System.EventHandler(this.fmPrinterPhotoCopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCDesktop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPCDesktop;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.DateTimePicker txtBuydate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtTypeDiveces;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label têt;
        private System.Windows.Forms.ComboBox cbFactorys;
        private System.Windows.Forms.ComboBox cbParts;
        private System.Windows.Forms.ComboBox cbPartment;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtIPPrinter;
        private System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtIdPrinter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label gr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbMACError;
        private System.Windows.Forms.Label lbIpError;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label label17;
    }
}