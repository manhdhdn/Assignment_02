namespace SalesWinApp
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.memberDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.memberToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.productToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.memberToolStripMenuItem.Text = "Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem1
            // 
            this.memberToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberDetailsToolStripMenuItem,
            this.historyOrderToolStripMenuItem});
            this.memberToolStripMenuItem1.Name = "memberToolStripMenuItem1";
            this.memberToolStripMenuItem1.Size = new System.Drawing.Size(101, 24);
            this.memberToolStripMenuItem1.Text = "Information";
            // 
            // memberDetailsToolStripMenuItem
            // 
            this.memberDetailsToolStripMenuItem.Name = "memberDetailsToolStripMenuItem";
            this.memberDetailsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.memberDetailsToolStripMenuItem.Text = "My Details";
            this.memberDetailsToolStripMenuItem.Click += new System.EventHandler(this.memberDetailsToolStripMenuItem_Click);
            // 
            // historyOrderToolStripMenuItem
            // 
            this.historyOrderToolStripMenuItem.Name = "historyOrderToolStripMenuItem";
            this.historyOrderToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.historyOrderToolStripMenuItem.Text = "History Order";
            this.historyOrderToolStripMenuItem.Click += new System.EventHandler(this.historyOrderToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem1;
        private ToolStripMenuItem memberDetailsToolStripMenuItem;
        private ToolStripMenuItem historyOrderToolStripMenuItem;
    }
}