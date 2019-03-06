namespace IT_Management.UI.FormTypeDevices
{
    partial class fmPrinterLaser
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPCDesktop = new System.Windows.Forms.DataGridView();
            this.txtModel = new System.Windows.Forms.TextBox();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCDesktop)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPCDesktop);
            this.panel2.Location = new System.Drawing.Point(3, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 343);
            this.panel2.TabIndex = 9;
            // 
            // dgvPCDesktop
            // 
            this.dgvPCDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPCDesktop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPCDesktop.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvPCDesktop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPCDesktop.Location = new System.Drawing.Point(0, 20);
            this.dgvPCDesktop.Name = "dgvPCDesktop";
            this.dgvPCDesktop.Size = new System.Drawing.Size(1106, 320);
            this.dgvPCDesktop.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(519, 202);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(168, 26);
            this.txtModel.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(410, 206);
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
            this.cbLocation.Location = new System.Drawing.Point(519, 34);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(168, 26);
            this.cbLocation.TabIndex = 5;
            // 
            // txtBuydate
            // 
            this.txtBuydate.CustomFormat = "yyyy/MM/dd";
            this.txtBuydate.Enabled = false;
            this.txtBuydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBuydate.Location = new System.Drawing.Point(519, 244);
            this.txtBuydate.Name = "txtBuydate";
            this.txtBuydate.Size = new System.Drawing.Size(168, 20);
            this.txtBuydate.TabIndex = 9;
            this.txtBuydate.Value = new System.DateTime(2019, 3, 4, 15, 59, 37, 0);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(780, 131);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(272, 40);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtTypeDiveces
            // 
            this.txtTypeDiveces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeDiveces.Location = new System.Drawing.Point(167, 34);
            this.txtTypeDiveces.Name = "txtTypeDiveces";
            this.txtTypeDiveces.ReadOnly = true;
            this.txtTypeDiveces.Size = new System.Drawing.Size(168, 26);
            this.txtTypeDiveces.TabIndex = 0;
            this.txtTypeDiveces.Text = "Printer Ink";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Name Devices";
            // 
            // têt
            // 
            this.têt.AutoSize = true;
            this.têt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.têt.Location = new System.Drawing.Point(410, 244);
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
            this.cbFactorys.Location = new System.Drawing.Point(519, 76);
            this.cbFactorys.Name = "cbFactorys";
            this.cbFactorys.Size = new System.Drawing.Size(168, 26);
            this.cbFactorys.TabIndex = 6;
            // 
            // cbParts
            // 
            this.cbParts.Enabled = false;
            this.cbParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParts.FormattingEnabled = true;
            this.cbParts.Location = new System.Drawing.Point(519, 118);
            this.cbParts.Name = "cbParts";
            this.cbParts.Size = new System.Drawing.Size(168, 26);
            this.cbParts.TabIndex = 7;
            // 
            // cbPartment
            // 
            this.cbPartment.Enabled = false;
            this.cbPartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPartment.FormattingEnabled = true;
            this.cbPartment.Location = new System.Drawing.Point(519, 160);
            this.cbPartment.Name = "cbPartment";
            this.cbPartment.Size = new System.Drawing.Size(168, 26);
            this.cbPartment.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(879, 183);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 46);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(977, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 46);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(780, 183);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 46);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // txtIPPrinter
            // 
            this.txtIPPrinter.Enabled = false;
            this.txtIPPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPPrinter.Location = new System.Drawing.Point(167, 202);
            this.txtIPPrinter.Name = "txtIPPrinter";
            this.txtIPPrinter.Size = new System.Drawing.Size(168, 26);
            this.txtIPPrinter.TabIndex = 4;
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrinterName.Location = new System.Drawing.Point(167, 160);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.ReadOnly = true;
            this.txtPrinterName.Size = new System.Drawing.Size(168, 26);
            this.txtPrinterName.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(167, 118);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 26);
            this.txtUserName.TabIndex = 2;
            // 
            // txtIdPrinter
            // 
            this.txtIdPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPrinter.Location = new System.Drawing.Point(167, 76);
            this.txtIdPrinter.Name = "txtIdPrinter";
            this.txtIdPrinter.ReadOnly = true;
            this.txtIdPrinter.Size = new System.Drawing.Size(168, 26);
            this.txtIdPrinter.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "IP Printer";
            // 
            // labelPartment
            // 
            this.labelPartment.AutoSize = true;
            this.labelPartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartment.Location = new System.Drawing.Point(410, 162);
            this.labelPartment.Name = "labelPartment";
            this.labelPartment.Size = new System.Drawing.Size(74, 20);
            this.labelPartment.TabIndex = 7;
            this.labelPartment.Text = "Partment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Parts";
            // 
            // gr
            // 
            this.gr.AutoSize = true;
            this.gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr.Location = new System.Drawing.Point(410, 36);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(70, 20);
            this.gr.TabIndex = 5;
            this.gr.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Factorys";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Printer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 76);
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
            this.panel1.Controls.Add(this.txtModel);
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
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 275);
            this.panel1.TabIndex = 8;
            // 
            // fmPrinterLaser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmPrinterLaser";
            this.Text = "Printer Laser";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCDesktop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPCDesktop;
        private System.Windows.Forms.TextBox txtModel;
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
    }
}