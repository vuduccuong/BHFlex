namespace IT_Management.UI.FormTypeDevices
{
    partial class fmBarScanner2D
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmBarScanner2D));
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBarcodeScannerName = new System.Windows.Forms.TextBox();
            this.cbPartment = new System.Windows.Forms.ComboBox();
            this.labelPartment = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.txtBuydate = new System.Windows.Forms.DateTimePicker();
            this.têt = new System.Windows.Forms.Label();
            this.cbFactorys = new System.Windows.Forms.ComboBox();
            this.cbParts = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPDA1D = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPBarcodeScanner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbMACError = new System.Windows.Forms.Label();
            this.lbIpError = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDA1D)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(879, 84);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(213, 128);
            this.rtbNote.TabIndex = 9;
            this.rtbNote.Text = "";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(1033, 192);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(59, 20);
            this.txtid.TabIndex = 112;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 20);
            this.label7.TabIndex = 111;
            this.label7.Text = "Barcode Scanner Name";
            // 
            // txtBarcodeScannerName
            // 
            this.txtBarcodeScannerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcodeScannerName.Location = new System.Drawing.Point(567, 84);
            this.txtBarcodeScannerName.Name = "txtBarcodeScannerName";
            this.txtBarcodeScannerName.Size = new System.Drawing.Size(190, 26);
            this.txtBarcodeScannerName.TabIndex = 4;
            // 
            // cbPartment
            // 
            this.cbPartment.Enabled = false;
            this.cbPartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPartment.FormattingEnabled = true;
            this.cbPartment.Location = new System.Drawing.Point(120, 212);
            this.cbPartment.Name = "cbPartment";
            this.cbPartment.Size = new System.Drawing.Size(190, 26);
            this.cbPartment.TabIndex = 3;
            // 
            // labelPartment
            // 
            this.labelPartment.AutoSize = true;
            this.labelPartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartment.Location = new System.Drawing.Point(18, 214);
            this.labelPartment.Name = "labelPartment";
            this.labelPartment.Size = new System.Drawing.Size(74, 20);
            this.labelPartment.TabIndex = 110;
            this.labelPartment.Text = "Partment";
            // 
            // cbLocation
            // 
            this.cbLocation.CausesValidation = false;
            this.cbLocation.Enabled = false;
            this.cbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(120, 84);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(190, 26);
            this.cbLocation.TabIndex = 0;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cbLocation_SelectedIndexChanged);
            this.cbLocation.Click += new System.EventHandler(this.cbLocation_Click);
            // 
            // txtBuydate
            // 
            this.txtBuydate.CustomFormat = "yyyy/MM/dd";
            this.txtBuydate.Enabled = false;
            this.txtBuydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBuydate.Location = new System.Drawing.Point(567, 257);
            this.txtBuydate.Name = "txtBuydate";
            this.txtBuydate.Size = new System.Drawing.Size(190, 26);
            this.txtBuydate.TabIndex = 8;
            this.txtBuydate.Value = new System.DateTime(2019, 3, 4, 15, 59, 37, 0);
            this.txtBuydate.Leave += new System.EventHandler(this.txtBuydate_Leave);
            // 
            // têt
            // 
            this.têt.AutoSize = true;
            this.têt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.têt.Location = new System.Drawing.Point(376, 262);
            this.têt.Name = "têt";
            this.têt.Size = new System.Drawing.Size(75, 20);
            this.têt.TabIndex = 109;
            this.têt.Text = "Buy Date";
            // 
            // cbFactorys
            // 
            this.cbFactorys.Enabled = false;
            this.cbFactorys.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFactorys.FormattingEnabled = true;
            this.cbFactorys.Location = new System.Drawing.Point(120, 126);
            this.cbFactorys.Name = "cbFactorys";
            this.cbFactorys.Size = new System.Drawing.Size(190, 26);
            this.cbFactorys.TabIndex = 1;
            this.cbFactorys.SelectedIndexChanged += new System.EventHandler(this.cbFactorys_SelectedIndexChanged);
            // 
            // cbParts
            // 
            this.cbParts.Enabled = false;
            this.cbParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParts.FormattingEnabled = true;
            this.cbParts.Location = new System.Drawing.Point(120, 168);
            this.cbParts.Name = "cbParts";
            this.cbParts.Size = new System.Drawing.Size(190, 26);
            this.cbParts.TabIndex = 2;
            this.cbParts.SelectedIndexChanged += new System.EventHandler(this.cbParts_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 108;
            this.label6.Text = "Parts";
            // 
            // gr
            // 
            this.gr.AutoSize = true;
            this.gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr.Location = new System.Drawing.Point(18, 86);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(70, 20);
            this.gr.TabIndex = 107;
            this.gr.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 106;
            this.label5.Text = "Factorys";
            // 
            // dgvPDA1D
            // 
            this.dgvPDA1D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPDA1D.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvPDA1D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPDA1D.Location = new System.Drawing.Point(3, 349);
            this.dgvPDA1D.Name = "dgvPDA1D";
            this.dgvPDA1D.Size = new System.Drawing.Size(1114, 347);
            this.dgvPDA1D.TabIndex = 104;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew.Image = global::IT_Management.Properties.Resources.icon3;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(817, 233);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(275, 44);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(813, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 100;
            this.label4.Text = "Note";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(1017, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 53);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(917, 283);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 53);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 93;
            this.label2.Text = "IP Barcode Scanner";
            // 
            // txtIPBarcodeScanner
            // 
            this.txtIPBarcodeScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPBarcodeScanner.Location = new System.Drawing.Point(567, 125);
            this.txtIPBarcodeScanner.Name = "txtIPBarcodeScanner";
            this.txtIPBarcodeScanner.Size = new System.Drawing.Size(190, 26);
            this.txtIPBarcodeScanner.TabIndex = 5;
            this.txtIPBarcodeScanner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIPBarcodeScanner_KeyPress);
            this.txtIPBarcodeScanner.Leave += new System.EventHandler(this.txtIPBarcodeScanner_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(419, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 33);
            this.label1.TabIndex = 91;
            this.label1.Text = "Barcode Scanner 2D";
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.Location = new System.Drawing.Point(817, 283);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 53);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtMAC
            // 
            this.txtMAC.Enabled = false;
            this.txtMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAC.Location = new System.Drawing.Point(567, 168);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(190, 26);
            this.txtMAC.TabIndex = 6;
            this.txtMAC.Leave += new System.EventHandler(this.txtMAC_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(376, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 114;
            this.label9.Text = "MAC";
            // 
            // lbMACError
            // 
            this.lbMACError.AutoSize = true;
            this.lbMACError.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMACError.ForeColor = System.Drawing.Color.Red;
            this.lbMACError.Location = new System.Drawing.Point(764, 169);
            this.lbMACError.Name = "lbMACError";
            this.lbMACError.Size = new System.Drawing.Size(29, 37);
            this.lbMACError.TabIndex = 116;
            this.lbMACError.Text = "*";
            // 
            // lbIpError
            // 
            this.lbIpError.AutoSize = true;
            this.lbIpError.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIpError.ForeColor = System.Drawing.Color.Red;
            this.lbIpError.Location = new System.Drawing.Point(763, 126);
            this.lbIpError.Name = "lbIpError";
            this.lbIpError.Size = new System.Drawing.Size(29, 37);
            this.lbIpError.TabIndex = 115;
            this.lbIpError.Text = "*";
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
            this.cbModel.Location = new System.Drawing.Point(567, 212);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(190, 26);
            this.cbModel.TabIndex = 7;
            // 
            // fmBarScanner2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1116, 608);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.lbMACError);
            this.Controls.Add(this.lbIpError);
            this.Controls.Add(this.txtMAC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBarcodeScannerName);
            this.Controls.Add(this.cbPartment);
            this.Controls.Add(this.labelPartment);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.txtBuydate);
            this.Controls.Add(this.têt);
            this.Controls.Add(this.cbFactorys);
            this.Controls.Add(this.cbParts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPDA1D);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIPBarcodeScanner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmBarScanner2D";
            this.Text = "Barcode Scanner 2D";
            this.Load += new System.EventHandler(this.fmBarScanner2D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDA1D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBarcodeScannerName;
        private System.Windows.Forms.ComboBox cbPartment;
        private System.Windows.Forms.Label labelPartment;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.DateTimePicker txtBuydate;
        private System.Windows.Forms.Label têt;
        private System.Windows.Forms.ComboBox cbFactorys;
        private System.Windows.Forms.ComboBox cbParts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label gr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPDA1D;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPBarcodeScanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbMACError;
        private System.Windows.Forms.Label lbIpError;
        private System.Windows.Forms.ComboBox cbModel;
    }
}