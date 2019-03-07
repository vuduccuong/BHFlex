namespace IT_Management.UI.FormTypeDevices
{
    partial class fmPDA2D
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPDA2D));
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPDAName = new System.Windows.Forms.TextBox();
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
            this.dgvPDA2D = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel1D = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPPDA1D = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDA2D)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(887, 72);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(213, 128);
            this.rtbNote.TabIndex = 88;
            this.rtbNote.Text = "";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(1041, 180);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(59, 20);
            this.txtid.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "PDA Name";
            // 
            // txtPDAName
            // 
            this.txtPDAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPDAName.Location = new System.Drawing.Point(530, 72);
            this.txtPDAName.Name = "txtPDAName";
            this.txtPDAName.Size = new System.Drawing.Size(190, 26);
            this.txtPDAName.TabIndex = 64;
            // 
            // cbPartment
            // 
            this.cbPartment.Enabled = false;
            this.cbPartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPartment.FormattingEnabled = true;
            this.cbPartment.Location = new System.Drawing.Point(162, 200);
            this.cbPartment.Name = "cbPartment";
            this.cbPartment.Size = new System.Drawing.Size(190, 26);
            this.cbPartment.TabIndex = 73;
            // 
            // labelPartment
            // 
            this.labelPartment.AutoSize = true;
            this.labelPartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartment.Location = new System.Drawing.Point(60, 202);
            this.labelPartment.Name = "labelPartment";
            this.labelPartment.Size = new System.Drawing.Size(74, 20);
            this.labelPartment.TabIndex = 85;
            this.labelPartment.Text = "Partment";
            // 
            // cbLocation
            // 
            this.cbLocation.CausesValidation = false;
            this.cbLocation.Enabled = false;
            this.cbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(162, 72);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(190, 26);
            this.cbLocation.TabIndex = 69;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cbLocation_SelectedIndexChanged);
            this.cbLocation.Click += new System.EventHandler(this.cbLocation_Click);
            // 
            // txtBuydate
            // 
            this.txtBuydate.CustomFormat = "yyyy/MM/dd";
            this.txtBuydate.Enabled = false;
            this.txtBuydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBuydate.Location = new System.Drawing.Point(530, 200);
            this.txtBuydate.Name = "txtBuydate";
            this.txtBuydate.Size = new System.Drawing.Size(190, 26);
            this.txtBuydate.TabIndex = 74;
            this.txtBuydate.Value = new System.DateTime(2019, 3, 4, 15, 59, 37, 0);
            this.txtBuydate.Leave += new System.EventHandler(this.txtBuydate_Leave);
            // 
            // têt
            // 
            this.têt.AutoSize = true;
            this.têt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.têt.Location = new System.Drawing.Point(428, 205);
            this.têt.Name = "têt";
            this.têt.Size = new System.Drawing.Size(75, 20);
            this.têt.TabIndex = 84;
            this.têt.Text = "Buy Date";
            // 
            // cbFactorys
            // 
            this.cbFactorys.Enabled = false;
            this.cbFactorys.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFactorys.FormattingEnabled = true;
            this.cbFactorys.Location = new System.Drawing.Point(162, 114);
            this.cbFactorys.Name = "cbFactorys";
            this.cbFactorys.Size = new System.Drawing.Size(190, 26);
            this.cbFactorys.TabIndex = 70;
            this.cbFactorys.SelectedIndexChanged += new System.EventHandler(this.cbFactorys_SelectedIndexChanged);
            // 
            // cbParts
            // 
            this.cbParts.Enabled = false;
            this.cbParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParts.FormattingEnabled = true;
            this.cbParts.Location = new System.Drawing.Point(162, 156);
            this.cbParts.Name = "cbParts";
            this.cbParts.Size = new System.Drawing.Size(190, 26);
            this.cbParts.TabIndex = 72;
            this.cbParts.SelectedIndexChanged += new System.EventHandler(this.cbParts_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 83;
            this.label6.Text = "Parts";
            // 
            // gr
            // 
            this.gr.AutoSize = true;
            this.gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr.Location = new System.Drawing.Point(60, 74);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(70, 20);
            this.gr.TabIndex = 82;
            this.gr.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 81;
            this.label5.Text = "Factorys";
            // 
            // dgvPDA2D
            // 
            this.dgvPDA2D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPDA2D.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvPDA2D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPDA2D.Location = new System.Drawing.Point(1, 339);
            this.dgvPDA2D.Name = "dgvPDA2D";
            this.dgvPDA2D.Size = new System.Drawing.Size(1130, 360);
            this.dgvPDA2D.TabIndex = 79;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew.Image = global::IT_Management.Properties.Resources.icon3;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(825, 220);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(275, 44);
            this.btnNew.TabIndex = 76;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(821, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Note";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(1025, 273);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 53);
            this.btnDelete.TabIndex = 80;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(925, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 53);
            this.btnUpdate.TabIndex = 78;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Model";
            // 
            // txtModel1D
            // 
            this.txtModel1D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel1D.Location = new System.Drawing.Point(530, 155);
            this.txtModel1D.Name = "txtModel1D";
            this.txtModel1D.Size = new System.Drawing.Size(190, 26);
            this.txtModel1D.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "IP PDA";
            // 
            // txtIPPDA1D
            // 
            this.txtIPPDA1D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPPDA1D.Location = new System.Drawing.Point(530, 113);
            this.txtIPPDA1D.Name = "txtIPPDA1D";
            this.txtIPPDA1D.Size = new System.Drawing.Size(190, 26);
            this.txtIPPDA1D.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(477, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 66;
            this.label1.Text = "PDA 2D";
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.Location = new System.Drawing.Point(825, 273);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 53);
            this.btnInsert.TabIndex = 77;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // fmPDA2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1132, 647);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPDAName);
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
            this.Controls.Add(this.dgvPDA2D);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel1D);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIPPDA1D);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmPDA2D";
            this.Text = "PDA 2D";
            this.Load += new System.EventHandler(this.fmPDA2D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDA2D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPDAName;
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
        private System.Windows.Forms.DataGridView dgvPDA2D;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel1D;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPPDA1D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
    }
}