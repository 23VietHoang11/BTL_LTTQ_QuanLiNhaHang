using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLNH
{
    public partial class frmAdminDashboard : Form
    {
      

        private frmLogin F1 { get; set; }
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        public frmAdminDashboard(frmLogin f1)
        {
            InitializeComponent();
            F1 = f1;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmUcAdd f = new frmUcAdd();
            addUserControl(f);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            frmUcUpdate f = new frmUcUpdate();
            addUserControl(f);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            frmUcDelete f = new frmUcDelete();
            addUserControl(f);
        }

        private void btnUpdateUserInfo_Click_1(object sender, EventArgs e)
        {
            frmUcUpdateUsers f = new frmUcUpdateUsers();
            addUserControl(f);
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            F1.Visible = true;
            this.Hide();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            frmUcHomeAdmin f1 = new frmUcHomeAdmin();
            addUserControl(f1);
        }
    }
}
