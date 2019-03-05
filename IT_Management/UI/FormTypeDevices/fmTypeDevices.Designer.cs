namespace IT_Management.UI.FormTypeDevices
{
    partial class fmTypeDevices
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("DeskTop");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("LapTop");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("PC", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Ink");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Laser");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("PhotoCopy");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Printer", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("PDA 1D");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("PDA 2D");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("PDA", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Scanner 1D");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Scanner 2D");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Scanner Wifi 2D");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Barcode Scanner", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Barcode Printer");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("TypeDevices", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7,
            treeNode10,
            treeNode14,
            treeNode15});
            this.treeViewTypeDevices = new System.Windows.Forms.TreeView();
            this.panelTypeDevices = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeViewTypeDevices
            // 
            this.treeViewTypeDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewTypeDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewTypeDevices.ItemHeight = 22;
            this.treeViewTypeDevices.Location = new System.Drawing.Point(0, 0);
            this.treeViewTypeDevices.Name = "treeViewTypeDevices";
            treeNode1.Name = "ntPCDesktop";
            treeNode1.Text = "DeskTop";
            treeNode2.Name = "ntPCLaptop";
            treeNode2.Text = "LapTop";
            treeNode3.Name = "ntTypePC";
            treeNode3.Text = "PC";
            treeNode4.Name = "ntPrinterInk";
            treeNode4.Text = "Ink";
            treeNode5.Name = "ntPrinterLaser";
            treeNode5.Text = "Laser";
            treeNode6.Name = "ntPrinterPhotoCopy";
            treeNode6.Text = "PhotoCopy";
            treeNode7.Name = "ntTypePrinter";
            treeNode7.Text = "Printer";
            treeNode8.Name = "ntPDA1D";
            treeNode8.Text = "PDA 1D";
            treeNode9.Name = "ntPDA2D";
            treeNode9.Text = "PDA 2D";
            treeNode10.Name = "ntTypePDA";
            treeNode10.Text = "PDA";
            treeNode11.Name = "ntnbarScanner1D";
            treeNode11.Text = "Scanner 1D";
            treeNode12.Name = "ntnbarScanner2D";
            treeNode12.Text = "Scanner 2D";
            treeNode13.Name = "ntnbarScannerWifi2D";
            treeNode13.Text = "Scanner Wifi 2D";
            treeNode14.Name = "ntTypeBarScanner";
            treeNode14.Text = "Barcode Scanner";
            treeNode15.Name = "ntTypeBarPrinter";
            treeNode15.Text = "Barcode Printer";
            treeNode16.Name = "ntTypeDevices";
            treeNode16.Text = "TypeDevices";
            this.treeViewTypeDevices.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeViewTypeDevices.Size = new System.Drawing.Size(217, 516);
            this.treeViewTypeDevices.TabIndex = 0;
            this.treeViewTypeDevices.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTypeDevices_AfterSelect);
            // 
            // panelTypeDevices
            // 
            this.panelTypeDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTypeDevices.Location = new System.Drawing.Point(223, 0);
            this.panelTypeDevices.Name = "panelTypeDevices";
            this.panelTypeDevices.Size = new System.Drawing.Size(939, 516);
            this.panelTypeDevices.TabIndex = 1;
            // 
            // fmTypeDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 517);
            this.Controls.Add(this.panelTypeDevices);
            this.Controls.Add(this.treeViewTypeDevices);
            this.Name = "fmTypeDevices";
            this.Text = "Type Devices";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmTypeDevices_Load);
            this.Leave += new System.EventHandler(this.fmTypeDevices_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewTypeDevices;
        private System.Windows.Forms.Panel panelTypeDevices;
    }
}