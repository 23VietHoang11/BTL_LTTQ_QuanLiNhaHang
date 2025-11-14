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
    public partial class frmManagerDashboard : Form
    {
        private frmLogin F1 { get; set; }
        public frmManagerDashboard()
        {
            InitializeComponent();
        }

        public frmManagerDashboard(frmLogin f1)
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmUcManagerHome f = new frmUcManagerHome();
            addUserControl(f);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            F1.Visible = true;
            this.Hide();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            frmUcSalesReport f = new frmUcSalesReport();
            addUserControl(f);
        }

        private void btnUpdateUserInfo_Click(object sender, EventArgs e)
        {
            frmUcUsersInfoManager f = new frmUcUsersInfoManager();
            addUserControl(f);
        }
    }
}
