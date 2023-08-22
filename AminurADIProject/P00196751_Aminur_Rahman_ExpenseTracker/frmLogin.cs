using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P00196751_Aminur_Rahman_ExpenseTracker
{
    public partial class frmLogin : Form
    {
        TrackerDBEntities db = new TrackerDBEntities();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var data = db.tblUsers.Where(u => u.UserName == txtUserName.Text
                          && u.Password == txtPassword.Text).FirstOrDefault(); //Checking username & Password in DB

            if (data != null)
            {
                UserInfo.Id = data.uId;
                UserInfo.FullName = data.FullName;
                UserInfo.UserName = data.UserName;
                UserInfo.UserType = data.UserType;

                //Add logged in user detail in UserCLass
                this.Hide();

                frmMainMenu frm = new frmMainMenu();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid User !!!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
        }

        private void chkViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewPass.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;

            }
        }
    }
}
