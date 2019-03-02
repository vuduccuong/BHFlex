namespace IT_Management.UI.ADD_DATA
{
    partial class fmAddData
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Location");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Factory");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Part");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Partment");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Room");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("DeviceType");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("DeviceInfo");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Category", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pnData = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 505);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(6, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "ntLocation";
            treeNode1.Text = "Location";
            treeNode2.Name = "ntFactory";
            treeNode2.Text = "Factory";
            treeNode3.Name = "ntPart";
            treeNode3.Text = "Part";
            treeNode4.Name = "ntPartment";
            treeNode4.Text = "Partment";
            treeNode5.Name = "ntRoom";
            treeNode5.Text = "Room";
            treeNode6.Name = "ntDeviceType";
            treeNode6.Text = "DeviceType";
            treeNode7.Name = "ntDeviceInfo";
            treeNode7.Text = "DeviceInfo";
            treeNode8.Name = "ntCategory";
            treeNode8.Text = "Category";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(212, 493);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pnData
            // 
            this.pnData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnData.Location = new System.Drawing.Point(233, 6);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(792, 505);
            this.pnData.TabIndex = 1;
            // 
            // fmAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 514);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.panel1);
            this.Name = "fmAddData";
            this.Text = "fmAddData";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmAddData_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel pnData;
    }
}