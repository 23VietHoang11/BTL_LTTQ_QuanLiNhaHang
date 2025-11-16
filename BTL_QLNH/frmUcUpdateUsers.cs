using BTL_QLNH;
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
    public partial class frmUcUpdateUsers : UserControl
    {

        private DataAccess Da { get; set; }
        public frmUcUpdateUsers()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.dgvUpdate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpdate.MultiSelect = false;
            this.dgvUpdate.ReadOnly = true; 

            this.PopulateGridView();

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");

            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Staff");
            cmbRole.Items.Add("Manager");

        }

        private void PopulateGridView(string sql = "select * from UserInfo where Role = 'Staff' or Role = 'Manager';")
        {
            this.Da.ExecuteQueryTable(sql);

            //this.dgvAdd.AutoGenerateColumns = false;
            this.dgvUpdate.DataSource = Da.Ds.Tables[0];
        }


        private void ClearContent()
        {
            this.txtUserName.Clear();
            this.txtFullName.Clear();
            this.txtEmail.Clear();
            this.cmbGender.Text = null;
            this.cmbRole.Text = null;
            this.dtpDOB.Value = DateTime.Now;


            this.txtSearch.Clear();


            this.dgvUpdate.ClearSelection();
            //this.AutoIdGenerate();
        }

        private void dgvUpdate_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvUpdate.SelectedRows != null && dgvUpdate.SelectedRows.Count > 0)
            {
                string userName = dgvUpdate.CurrentRow.Cells[0].Value.ToString();
                string FullName = dgvUpdate.CurrentRow.Cells[1].Value.ToString();
                string DOB = dgvUpdate.CurrentRow.Cells[2].Value.ToString();
                string Gender = dgvUpdate.CurrentRow.Cells[3].Value.ToString();
                string role = dgvUpdate.CurrentRow.Cells[4].Value.ToString();
                string Email = dgvUpdate.CurrentRow.Cells[5].Value.ToString();


                txtUserName.Text = userName;
                txtFullName.Text = FullName;
                dtpDOB.Text = DOB;
                cmbGender.Text = Gender;
                cmbRole.Text = role;
                txtEmail.Text = Email;
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtFullName.Text) || String.IsNullOrEmpty(this.txtEmail.Text) ||
               String.IsNullOrEmpty(this.cmbRole.Text) || String.IsNullOrEmpty(this.cmbGender.Text))
            {
                MessageBox.Show("Fields are blank!  Plaese select a Row first to Update");
            }

            else
            {
                if (this.dgvUpdate.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Plaese select a Row first to Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    var Username = this.dgvUpdate.CurrentRow.Cells[0].Value.ToString();
                    var FullName = this.dgvUpdate.CurrentRow.Cells[1].Value.ToString();

                    DialogResult dr = MessageBox.Show("Are you sure you want to change?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.No)
                    {
                        //MessageBox.Show("No delete");
                        return;
                    }

                    var query = "UPDATE UserInfo SET FullName = '" + txtFullName.Text + "',DOB = '" + dtpDOB.Value + "',Gender = '" + cmbGender.Text + "',Role ='" + cmbRole.Text + "',Email ='" + txtEmail.Text + "' WHERE Username='" + txtUserName.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(query);

                    // if (count == 1)
                    MessageBox.Show(" Information of " + txtFullName.Text + " has been updated successfully!");
                    // else
                    //     MessageBox.Show("Data upgradation failed");

                    this.PopulateGridView();
                    this.ClearContent();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured: " + exc.Message);
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where FullName like '%" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.dgvUpdate.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn một người dùng để xoá.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string username = dgvUpdate.CurrentRow.Cells[0].Value.ToString();
                string fullName = dgvUpdate.CurrentRow.Cells[1].Value.ToString();

                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xoá người dùng '{fullName}' ({username}) không?\n\nHÀNH ĐỘNG NÀY SẼ XOÁ CẢ TÀI KHOẢN ĐĂNG NHẬP VÀ KHÔNG THỂ HOÀN TÁC!",
                                                    "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    return;
                }

                string query = $@"
            BEGIN TRANSACTION;
                -- Xoá tài khoản đăng nhập
                DELETE FROM LoginInfo WHERE Username = '{username}';
                
                -- Xoá thông tin người dùng
                DELETE FROM UserInfo WHERE Username = '{username}';
            COMMIT TRANSACTION;
        ";

                int rowsAffected = this.Da.ExecuteDMLQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đã xoá người dùng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.PopulateGridView();
                    this.ClearContent();  
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người dùng để xoá (có thể đã bị xoá trước đó).");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Có lỗi xảy ra khi xoá: " + exc.Message);
            }
        }
    }
}
