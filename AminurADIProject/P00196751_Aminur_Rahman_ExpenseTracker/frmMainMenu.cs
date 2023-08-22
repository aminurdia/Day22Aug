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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            statusWelcome.Text = "Welcome - " + UserInfo.UserName;
            openChildForm(new frmHome());

        }

        private Form activeForm = null;

        private void openChildForm(Form childform)
        {
            if  (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(childform);
            pnlContainer. Dock = DockStyle.Fill;
            childform.BringToFront();
            childform.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHome());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}
