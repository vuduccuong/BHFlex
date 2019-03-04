namespace IT_Management.UI.ADD_DATA
{
    partial class fmPartment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbbListPart = new System.Windows.Forms.ComboBox();
            this.cbbListFactory = new System.Windows.Forms.ComboBox();
            this.cbbListLocation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartmentName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgPartment = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.cbbListPart);
            this.panel1.Controls.Add(this.cbbListFactory);
            this.panel1.Controls.Add(this.cbbListLocation);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPartmentName);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 246);
            this.panel1.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(1089, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 30);
            this.txtID.TabIndex = 11;
            // 
            // cbbListPart
            // 
            this.cbbListPart.FormattingEnabled = true;
            this.cbbListPart.Location = new System.Drawing.Point(176, 89);
            this.cbbListPart.Name = "cbbListPart";
            this.cbbListPart.Size = new System.Drawing.Size(394, 33);
            this.cbbListPart.TabIndex = 10;
            // 
            // cbbListFactory
            // 
            this.cbbListFactory.FormattingEnabled = true;
            this.cbbListFactory.Location = new System.Drawing.Point(176, 50);
            this.cbbListFactory.Name = "cbbListFactory";
            this.cbbListFactory.Size = new System.Drawing.Size(394, 33);
            this.cbbListFactory.TabIndex = 10;
            this.cbbListFactory.SelectedIndexChanged += new System.EventHandler(this.cbbListFactory_SelectedIndexChanged);
            // 
            // cbbListLocation
            // 
            this.cbbListLocation.FormattingEnabled = true;
            this.cbbListLocation.Location = new System.Drawing.Point(176, 11);
            this.cbbListLocation.Name = "cbbListLocation";
            this.cbbListLocation.Size = new System.Drawing.Size(394, 33);
            this.cbbListLocation.TabIndex = 10;
            this.cbbListLocation.SelectedIndexChanged += new System.EventHandler(this.cbbListLocation_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Part Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Partment Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Factory Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Location Name :";
            // 
            // txtPartmentName
            // 
            this.txtPartmentName.Location = new System.Drawing.Point(176, 130);
            this.txtPartmentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPartmentName.Name = "txtPartmentName";
            this.txtPartmentName.Size = new System.Drawing.Size(394, 30);
            this.txtPartmentName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 182);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 56);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(191, 182);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(160, 56);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(363, 182);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 56);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dtgPartment);
            this.panel2.Location = new System.Drawing.Point(6, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1189, 440);
            this.panel2.TabIndex = 4;
            // 
            // dtgPartment
            // 
            this.dtgPartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPartment.Location = new System.Drawing.Point(6, 3);
            this.dtgPartment.Name = "dtgPartment";
            this.dtgPartment.RowTemplate.Height = 24;
            this.dtgPartment.Size = new System.Drawing.Size(1176, 432);
            this.dtgPartment.TabIndex = 0;
            // 
            // fmPartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmPartment";
            this.Text = "fmPartment";
            this.Load += new System.EventHandler(this.fmPartment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbbListPart;
        private System.Windows.Forms.ComboBox cbbListFactory;
        private System.Windows.Forms.ComboBox cbbListLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPartmentName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgPartment;
    }
}