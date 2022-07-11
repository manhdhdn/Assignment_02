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

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public bool AdminOrMember { get; set; }
        public frmMain()
        {
            InitializeComponent();
            
        }  

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
