using System;
using System.Windows.Forms;
using BTL_QLNH.BUS;

namespace BTL_QLNH
{
    public partial class frmAdminLoginForSignUp : Form
    {
        private frmLogin F1 { get; set; }
        private AccountBUS bus;

        public frmAdminLoginForSignUp(frmLogin f1)
        {
            InitializeComponent();
            F1 = f1;
            bus = new AccountBUS();
            txtPassword.PasswordChar = '●';
        }
        // Constructor mặc định
        public frmAdminLoginForSignUp() { InitializeComponent(); bus = new AccountBUS(); }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Kiểm tra đăng nhập
            if (bus.CheckLogin(txtUsername.TextButton, txtPassword.TextButton))
            {
                // Kiểm tra quyền Admin
                string role = bus.GetUserRole(txtUsername.TextButton);
                if (role == "Admin" || role == "Quản Trị Viên")
                {
                    MessageBox.Show("Xác thực thành công!");
                    frmSignUp signUpForm = new frmSignUp(this);
                    signUpForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Chỉ tài khoản Quản trị viên mới được phép truy cập!");
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e) { F1.Visible = true; this.Hide(); }
        private void btnClear_Click(object sender, EventArgs e) { txtUsername.TextButton = ""; txtPassword.TextButton = ""; }
        private void cbShow_CheckedChanged(object sender, EventArgs e) { txtPassword.PasswordChar = cbShow.Checked ? '\0' : '●'; }
    }
}