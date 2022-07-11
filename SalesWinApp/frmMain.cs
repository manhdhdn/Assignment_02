using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BusinessObject;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public bool AdminOrMember { get; set; }
        public Member? MemberInfo { get; set; }
        public frmMain()
        {
            InitializeComponent();
            
        }  

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberManagement frmMemberManagement = new frmMemberManagement();
            frmMemberManagement.MdiParent = this;
            frmMemberManagement.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderManagement frmOrderManagement = new frmOrderManagement();
            frmOrderManagement.MdiParent = this;
            frmOrderManagement.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductManagement frmProductManagement = new frmProductManagement();
            frmProductManagement.MdiParent = this;
            frmProductManagement.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e) => Close();

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (AdminOrMember == true)
            {
                memberToolStripMenuItem1.Visible = false;
            }
            else
            {
                managementToolStripMenuItem.Visible = false;
            }
        }

        private void memberDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                MemberInfo = MemberInfo,
                InsertOrUpdate = true
            };
            frmMemberDetails.MdiParent = this;
            frmMemberDetails.ShowDialog();
        }

        private void historyOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderManagement frmOrderManagement = new frmOrderManagement
            {

            };
            frmOrderManagement.ShowDialog();
        }
    }
}
