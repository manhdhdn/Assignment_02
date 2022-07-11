using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public IMemberRepository MemberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("admin@fstore.com") && txtPassword.Text.Equals("admin@@"))
            {
                this.Hide();
                frmMain frmMain = new frmMain
                {
                    Text = "Sale Management",
                    AdminOrMember = true,
                    
                };
                frmMain.ShowDialog();
                this.Close();
            }
            else {
                var memberInfo = MemberRepository.GetMember(0, txtEmail.Text, txtPassword.Text);
                if (memberInfo != null)
                {
                    this.Hide();
                    frmMain frmMain = new frmMain
                    {
                        Text = "Member Details",
                        AdminOrMember = false,
                        MemberInfo = memberInfo,
                    };
                    frmMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Email or Password");
                }
            }
        }       

        private void bntClose_Click(object sender, EventArgs e) => Close();
        
    }
}