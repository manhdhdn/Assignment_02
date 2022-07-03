namespace SalesWinApp
{
    partial class frmMemberManagement
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(758, 636);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(758, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Location = new System.Drawing.Point(758, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(266, 204);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.Size = new System.Drawing.Size(586, 395);
            this.dgvMemberList.TabIndex = 3;
            this.dgvMemberList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellDoubleClick);
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(47, 278);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(188, 27);
            this.txtMemberId.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(47, 568);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(188, 27);
            this.txtPassword.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(47, 510);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(188, 27);
            this.txtCity.TabIndex = 6;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(47, 452);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(188, 27);
            this.txtCountry.TabIndex = 7;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(47, 394);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(188, 27);
            this.txtCompanyName.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(47, 336);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 27);
            this.txtEmail.TabIndex = 9;
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbMemberId.Location = new System.Drawing.Point(47, 251);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(27, 23);
            this.lbMemberId.TabIndex = 10;
            this.lbMemberId.Text = "ID";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(47, 309);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(54, 23);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbCompanyName.Location = new System.Drawing.Point(47, 367);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(136, 23);
            this.lbCompanyName.TabIndex = 12;
            this.lbCompanyName.Text = "Company Name";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbCountry.Location = new System.Drawing.Point(47, 425);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(71, 23);
            this.lbCountry.TabIndex = 13;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbCity.Location = new System.Drawing.Point(47, 483);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(41, 23);
            this.lbCity.TabIndex = 14;
            this.lbCity.Text = "City";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(47, 541);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(82, 23);
            this.lbPassword.TabIndex = 15;
            this.lbPassword.Text = "Password";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(266, 137);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(149, 29);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Load Member";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(249, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 41);
            this.label4.TabIndex = 26;
            this.label4.Text = "Member Management";
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(864, 712);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbMemberId);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Name = "frmMemberManagement";
            this.Text = "Member Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvMemberList;
        private TextBox txtMemberId;
        private TextBox txtPassword;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtCompanyName;
        private TextBox txtEmail;
        private Label lbMemberId;
        private Label lbEmail;
        private Label lbCompanyName;
        private Label lbCountry;
        private Label lbCity;
        private Label lbPassword;
        private Button btnLoad;
        private Label label4;
    }
}