using System;
using System.Windows.Forms;
using BTL_QLNH.BUS; // Gọi BUS

namespace BTL_QLNH
{
    public partial class frmLogin : Form
    {
        private frmSignUp F3 { get; set; }
        private AccountBUS accountBUS;

        public frmLogin()
        {
            InitializeComponent();
            accountBUS = new AccountBUS();
            txtPassword.PasswordChar = '●';
        }

        public frmLogin(frmSignUp f3)
        {
            InitializeComponent();
            this.F3 = f3;
            accountBUS = new AccountBUS();
            txtPassword.PasswordChar = '●';
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                // GỌI BUS THAY VÌ DATAACCESS CŨ
                if (accountBUS.CheckLogin(txtUsername.TextButton, txtPassword.TextButton))
                {
                    MessageBox.Show("Đăng nhập thành công.\nChào mừng, " + txtUsername.TextButton);
                    string role = accountBUS.GetUserRole(txtUsername.TextButton);

                    if (role == "Admin" || role == "Quản Trị Viên")
                    {
                        new frmAdminDashboard(this).Show();
                        this.Hide();
                    }
                    else if (role == "Staff" || role == "Nhân Viên")
                    {
                        new frmStaffDashboard(this).Show();
                        this.Hide();
                    }
                    else if (role == "Manager" || role == "Quản Lý")
                    {
                        new frmManagerDashboard(this).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản chưa được phân quyền.");
                    }

                    // Reset ô nhập
                    txtUsername.TextButton = "";
                    txtPassword.TextButton = "";
                }
                else
                {
                    MessageBox.Show("Đăng nhập không hợp lệ.\nVui lòng thử lại");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // Các sự kiện giao diện giữ nguyên
        private void btnClear_Click(object sender, EventArgs e) { txtUsername.TextButton = ""; txtPassword.TextButton = ""; }
        private void cbShow_CheckedChanged(object sender, EventArgs e) { txtPassword.PasswordChar = cbShow.Checked ? '\0' : '●'; }
        private void lblSignUpNow_Click(object sender, EventArgs e) { new frmAdminLoginForSignUp(this).Show(); this.Hide(); }
    }
}