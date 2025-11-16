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
    public partial class frmSignUp : Form
    {
        private frmAdminLoginForSignUp F1 { get; set; }

        public frmSignUp()
        {
            InitializeComponent();
            this.txtSetPassword.PasswordChar = '•';
            this.txtConfirmPassword.PasswordChar = '•';
        }
        private void frmSignUp_Load(object sender, EventArgs e)
        {
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.CustomFormat = "dd/MM/yyyy";

            cbGender.Items.Add("Nam");
            cbGender.Items.Add("Nữ");

            cbRole.Items.Add("Quản Trị Viên");
            cbRole.Items.Add("Nhân Viên");
            cbRole.Items.Add("Quản Lý");
        }
        

        public frmSignUp(frmAdminLoginForSignUp f1)
        {
            InitializeComponent();
            this.F1 = f1;

        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserName.TextButton) || string.IsNullOrEmpty(txtConfirmPassword.TextButton) || string.IsNullOrEmpty(txtFullName.TextButton) || string.IsNullOrEmpty(txtEmail.TextButton)
                    || string.IsNullOrEmpty(cbRole.Text) || string.IsNullOrEmpty(txtSetPassword.TextButton) || string.IsNullOrEmpty(txtConfirmPassword.TextButton))
                {
                 
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc");
                }
                else
                {
                    DataAccess d = new DataAccess();

                    string sqlSelect = "SELECT * FROM LoginInfo WHERE Username = '" + txtUserName.TextButton + "';";

                    d.ExecuteQueryTable(sqlSelect);

                    if (d.Ds.Tables[0].Rows.Count > 0)
                    {
                        
                        MessageBox.Show("Tên đăng nhập đã tồn tại");
                    }
                    else
                    {
                        if (txtSetPassword.TextButton == txtConfirmPassword.TextButton)
                        {

                            string sql = "INSERT INTO LoginInfo (Username, Password) VALUES ('" + txtUserName.TextButton + "', '" + txtConfirmPassword.TextButton + "');";
                            string sql2 = "INSERT INTO UserInfo (Username, FullName, DOB, Gender, Role, Email) VALUES ('" + txtUserName.TextButton + "', '" + txtFullName.TextButton + "', '" + dtpDOB.Value + "', '" + cbGender.Text + "', '" + cbRole.Text + "', '" + txtEmail.TextButton + "');";

                            int a = d.ExecuteDMLQuery(sql);
                            int b = d.ExecuteDMLQuery(sql2);

                            if (a > 0 && b > 0)
                            {
                              
                                MessageBox.Show("Tạo tài khoản người dùng thành công");

                                frmLogin f = new frmLogin(this);
                                f.Visible = true;
                                this.Hide();
                            }
                            else
                            {
                                
                                MessageBox.Show("Tạo tài khoản người dùng thất bại");
                            }
                        }
                        else if (txtSetPassword.TextButton != txtConfirmPassword.TextButton)
                        {
                           
                            MessageBox.Show("Mật khẩu không khớp.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Đã dịch
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.TextButton = "";
            txtUserName.TextButton = "";
            cbGender.SelectedIndex = -1;
            cbGender.Text = "";
            dtpDOB.Value = DateTime.Now;
            cbRole.SelectedIndex = -1;
            cbRole.Text = "";
            txtEmail.TextButton = "";
            txtSetPassword.TextButton = "";
            txtConfirmPassword.TextButton = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            F1.Visible = true;
            this.Hide();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                this.txtSetPassword.PasswordChar = '\0';
                this.txtConfirmPassword.PasswordChar = '\0';

            }
            else
            {
                this.txtSetPassword.PasswordChar = '●';
                this.txtConfirmPassword.PasswordChar = '●';

            }
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
