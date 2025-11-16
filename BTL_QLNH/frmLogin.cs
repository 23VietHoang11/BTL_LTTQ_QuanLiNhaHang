using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_QLNH
{
    public partial class frmLogin : Form
    {
        private frmSignUp F3 { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '●';
            cbShow.Checked = false;
        }

        public frmLogin(frmSignUp f3)
        {
            InitializeComponent();
            this.F3 = f3;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.TextButton = "";
            txtPassword.TextButton = "";
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM LoginInfo WHERE Username='" + this.txtUsername.TextButton + "' and Password='" + this.txtPassword.TextButton + "';";



                DataAccess d = new DataAccess();
                d.ExecuteQueryTable(sql);


                if (d.Ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Successful Login.\nWelcome, " + txtUsername.TextButton);

                    string sqlDashboard = "select * from UserInfo where Role ='Admin' and Username='" + txtUsername.TextButton + "';";
                    d.ExecuteQueryTable(sqlDashboard);
                    if (d.Ds.Tables[0].Rows.Count == 1)
                    {
                        frmAdminDashboard admin = new frmAdminDashboard(this);
                        admin.Show();
                        this.Hide();
                    }

                    string sqlDashboard2 = "select * from UserInfo where Role ='Staff' and Username='" + txtUsername.TextButton + "';";
                    d.ExecuteQueryTable(sqlDashboard2);
                    if (d.Ds.Tables[0].Rows.Count == 1)
                    {
                        frmStaffDashboard emp = new frmStaffDashboard(this);
                        emp.Show();
                        this.Hide();
                    }

                    string sqlDashboard3 = "select * from UserInfo where Role ='Manager' and Username='" + txtUsername.TextButton + "';";
                    d.ExecuteQueryTable(sqlDashboard3);

                    if (d.Ds.Tables[0].Rows.Count == 1)
                    {
                        frmManagerDashboard man = new frmManagerDashboard(this);
                        man.Show();
                        this.Hide();
                    }
                    txtUsername.TextButton = "";
                    txtPassword.TextButton = "";
                }
                else
                {
                    MessageBox.Show("Invalid Login.\nPlease Try Again");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblSignUpNow_Click(object sender, EventArgs e)
        {
            frmAdminLoginForSignUp f = new frmAdminLoginForSignUp(this);
            f.Show();
            this.Hide();
        }
    }
}
