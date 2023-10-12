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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();

        private BindingSource memberSource;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail();
            frmMemberDetail.Text = "Add Member";
            frmMemberDetail.isInsert = true;
            frmMemberDetail.ShowDialog();
            loadMembers();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail();
            frmMemberDetail.Text = "Update Member";
            frmMemberDetail.isInsert = false;
            frmMemberDetail.ShowDialog();
            loadMembers();

        }

        private MemberObject buildMember()
        {
            string memberId = txtMemberId.Text;
            string memberName = txtMemberName.Text;
            string city = txtCity.Text;
            string country = txtCountry.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            MemberObject member = new MemberObject()
            {
                MemberId = memberId,
                MemberName = memberName,
                City = city,
                Country = country,
                Email = email,
                Password = password
            };
            return member;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            memberRepository.remove(txtMemberId.Text);
            loadMembers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MemberObject member = memberRepository.findByIdAndName(buildMember().MemberId,
                buildMember().MemberName);

        }

        private void cbCountry_Click(object sender, EventArgs e)
        {
            if (cbCountry.Checked && cbCity.Checked)
            {
                txtMemberName.ReadOnly = true;
                txtMemberId.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtCity.ReadOnly = false;
                txtCountry.ReadOnly = false;
            }
            else if (cbCountry.Checked)
            {
                txtMemberName.ReadOnly = true;
                txtMemberId.ReadOnly = true;
                txtCity.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtPassword.ReadOnly = true;
            }
            else if (!cbCountry.Checked && !cbCity.Checked)
            {
                txtMemberName.ReadOnly = false;
                txtMemberId.ReadOnly = false;
                txtCity.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtPassword.ReadOnly = false;
            }
            else if (!cbCountry.Checked && cbCity.Checked)
            {
                txtMemberName.ReadOnly = true;
                txtMemberId.ReadOnly = true;
                txtCity.ReadOnly = false;
                txtEmail.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtCountry.ReadOnly = true;
            }
        }

        private void cbCity_Click(object sender, EventArgs e)
        {
            if (cbCity.Checked && cbCountry.Checked)
            {
                txtMemberName.ReadOnly = true;
                txtMemberId.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtCity.ReadOnly = false;
                txtCountry.ReadOnly = false;
            }
            else if (cbCity.Checked)
            {
                txtMemberName.ReadOnly = true;
                txtMemberId.ReadOnly = true;
                txtCountry.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtPassword.ReadOnly = true;
            }
            else if (!cbCity.Checked && !cbCountry.Checked)
            {
                txtMemberName.ReadOnly = false;
                txtMemberId.ReadOnly = false;
                txtCountry.ReadOnly = false;
                txtCity.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtPassword.ReadOnly = false;
            }
            else if (!cbCity.Checked && cbCountry.Checked)
            {
                txtMemberName.ReadOnly = true;
                txtMemberId.ReadOnly = true;
                txtCountry.ReadOnly = false;
                txtEmail.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtCity.ReadOnly = true;
            }
        }

        private void clearText()
        {
            txtMemberName.Text = string.Empty;
            txtMemberId.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
        }

        public void loadMembers()
        {
            var memberList = memberRepository.findAll();
            memberSource = new BindingSource();
            memberSource.DataSource = memberList;

            txtMemberName.DataBindings.Clear();
            txtMemberId.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtCity.DataBindings.Clear();

            txtMemberName.DataBindings.Add("Text", memberSource, "MemberName");
            txtMemberId.DataBindings.Add("Text", memberSource, "MemberId");
            txtCountry.DataBindings.Add("Text", memberSource, "Country");
            txtEmail.DataBindings.Add("Text", memberSource, "Email"); ;
            txtPassword.DataBindings.Add("Text", memberSource, "Password");
            txtCity.DataBindings.Add("Text", memberSource, "City");

            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = memberSource;

            if (memberList.Count() == 0)
            {
                clearText();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }


        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMemberList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var click = 0;
        }
    }
}
