using System;
using System.Windows.Forms;
using BTL_QLNH.BUS;

namespace BTL_QLNH
{
    public partial class frmSignUp : Form
    {
        private frmAdminLoginForSignUp F1 { get; set; }
        private AccountBUS bus;

        public frmSignUp(frmAdminLoginForSignUp f1)
        {
            InitializeComponent();
            this.F1 = f1;
            bus = new AccountBUS();
        }
        public frmSignUp() { InitializeComponent(); bus = new AccountBUS(); }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.CustomFormat = "dd/MM/yyyy";
            cbGender.Items.AddRange(new string[] { "Nam", "Nữ" });
            cbRole.Items.AddRange(new string[] { "Quản Trị Viên", "Nhân Viên", "Quản Lý" });
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Gọi BUS để tạo tài khoản
            string result = bus.CreateAccount(
                txtUserName.TextButton,
                txtSetPassword.TextButton,
                txtConfirmPassword.TextButton, // BUS sẽ check khớp pass
                txtFullName.TextButton,
                dtpDOB.Value,
                cbGender.Text,
                cbRole.Text,
                txtEmail.TextButton
            );

            if (result == "Success")
            {
                MessageBox.Show("Tạo tài khoản thành công!");
                frmLogin f = new frmLogin(); // Hoặc quay lại login
                f.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.TextButton = ""; txtUserName.TextButton = ""; cbGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now; cbRole.SelectedIndex = -1; txtEmail.TextButton = "";
            txtSetPassword.TextButton = ""; txtConfirmPassword.TextButton = "";
        }

        private void btnBack_Click(object sender, EventArgs e) { F1.Visible = true; this.Hide(); }
        // Các event khác giữ nguyên
        private void cbShow_CheckedChanged(object sender, EventArgs e) { /*...*/ }
        private void lblCreateAccount_Click(object sender, EventArgs e) { }
        private void lblUsername_Click(object sender, EventArgs e) { }
        private void dtpDOB_ValueChanged(object sender, EventArgs e) { }
    }
}