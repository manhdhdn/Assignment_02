using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMemberManagement : Form
    {
        readonly IMemberRepository memberRepository = new MemberRepository();
        BindingSource source = null!;

        public frmMemberManagement()
        {
            InitializeComponent();
        }

        public void LoadMemberList()
        {

            var members = memberRepository.GetMembers();

            //var members = memberRepository.GetMembers(null, null, null);
            //Stashed changes
            try
            {
                source = new BindingSource
                {
                    DataSource = members
                };

                txtMemberId.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "MemberID");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtCity.DataBindings.Add("Text", source, "City");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (!members.Any())
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        private Member GetMemberObject()
        {
            Member memberObject = null!;
            try
            {
                memberObject = new Member
                {
                    MemberId = int.Parse(txtMemberId.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    Country = txtCountry.Text,
                    City = txtCity.Text,
                    Password = txtPassword.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return memberObject;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Add new member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberId);
                LoadMemberList();
                source.Position = source.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update member profile",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository,
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();






    }
}
