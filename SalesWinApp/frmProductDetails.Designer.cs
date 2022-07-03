namespace SalesWinApp
{
    partial class frmProductDetails
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtUnitStock = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(124, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(272, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(198, 33);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(225, 27);
            this.txtProductId.TabIndex = 2;
            // 
            // txtUnitStock
            // 
            this.txtUnitStock.Location = new System.Drawing.Point(198, 288);
            this.txtUnitStock.Name = "txtUnitStock";
            this.txtUnitStock.Size = new System.Drawing.Size(225, 27);
            this.txtUnitStock.TabIndex = 3;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(198, 237);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(225, 27);
            this.txtUnitPrice.TabIndex = 4;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(198, 135);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(225, 27);
            this.txtProductName.TabIndex = 5;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(198, 84);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(225, 27);
            this.txtCategoryId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unit Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unit Stock";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(198, 186);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(225, 27);
            this.txtWeight.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Weight";
            // 
            // frmProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(491, 432);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtUnitStock);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmProductDetails";
            this.Text = "frmProductDetails";
            this.Load += new System.EventHandler(this.frmProductDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtProductId;
        private TextBox txtUnitStock;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private TextBox txtCategoryId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtWeight;
        private Label label6;
    }
}