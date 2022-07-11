using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMemberDetails : Form
    {
        public IMemberRepository? MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member? MemberInfo { get; set; }
        
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {

            txtMemberId.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtMemberId.Text = MemberInfo.MemberId.ToString();
                txtEmail.Text = MemberInfo.Email;
                txtCompanyName.Text = MemberInfo.CompanyName;
                cboCountry.Text = MemberInfo.Country.Trim();
                cboCity.Text = MemberInfo.City.Trim();
                txtPassword.Text = MemberInfo.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    MemberId = int.Parse(txtMemberId.Text),
                    CompanyName = txtCompanyName.Text,
                    Email = txtEmail.Text,
                    Country = cboCountry.Text,
                    City = cboCity.Text,
                    Password = txtPassword.Text,
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new member" : "Update member profile");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCity.SelectedIndex = -1;

            switch (cboCountry.SelectedIndex)
            {
                case 0:
                    cboCity.Items.Clear();
                    cboCity.Items.AddRange(new object[]
                    {
                        "HCM",
                        "Ha Noi",
                        "Nha Trang",
                        "Long Xuyen"
                    });
                    break;
                case 1:
                    cboCity.Items.Clear();
                    cboCity.Items.AddRange(new object[]
                    {
                        "Bangkok",
                        "Chiang Mai",
                        "Phuket"
                    });
                    break;
                case 2:
                    cboCity.Items.Clear();
                    cboCity.Items.AddRange(new object[]
                    {
                        "Tokyo",
                        "Hiroshima",
                        "Nagasaki"
                    });
                    break;
                case 3:
                    cboCity.Items.Clear();
                    cboCity.Items.AddRange(new object[]
                    {
                        "Wuhan",
                        "Beijing",
                        "Changsha"
                    });
                    break;
                default:
                    break;
            }
        }
    }
}
