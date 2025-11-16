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
using System.Globalization; // Thêm
using System.Threading;    // Thêm

namespace BTL_QLNH
{
    public partial class frmUcUpdateUsers : UserControl
    {
        private DataAccess Da { get; set; }
        public frmUcUpdateUsers()
        {
            // Thêm 2 dòng này đểDateTimePicker hiển thị tiếng Việt
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");

            InitializeComponent();
            this.Da = new DataAccess();

            this.dgvUpdate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpdate.MultiSelect = false;
            this.dgvUpdate.ReadOnly = true;

            this.PopulateGridView();

            cmbGender.Items.Add("Nam");
            cmbGender.Items.Add("Nữ");

            // Đã dịch (Lưu ý: Cần đồng bộ với logic lưu trữ trong CSDL)
            cmbRole.Items.Add("Quản Trị Viên");
            cmbRole.Items.Add("Nhân Viên");
            cmbRole.Items.Add("Quản Lý");

            // Thêm định dạng ngày sinh
            this.dtpDOB.Format = DateTimePickerFormat.Custom;
            this.dtpDOB.CustomFormat = "dddd, dd/MM/yyyy";
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
            if (dgvUpdate.SelectedRows != null && dgvUpdate.SelectedRows.Count > 0 && dgvUpdate.CurrentRow != null)
            {
                string userName = dgvUpdate.CurrentRow.Cells[0].Value.ToString();
                string FullName = dgvUpdate.CurrentRow.Cells[1].Value.ToString();
                string DOB = dgvUpdate.CurrentRow.Cells[2].Value.ToString();
                string Gender = dgvUpdate.CurrentRow.Cells[3].Value.ToString();
                string role = dgvUpdate.CurrentRow.Cells[4].Value.ToString();
                string Email = dgvUpdate.CurrentRow.Cells[5].Value.ToString();

                txtUserName.Text = userName;
                txtFullName.Text = FullName;
               
                try
                {
                    dtpDOB.Value = Convert.ToDateTime(DOB);
                }
                catch
                {
                    dtpDOB.Value = DateTime.Now; // Gán ngày hiện tại nếu ngày CSDL bị lỗi
                }
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
              
                MessageBox.Show("Vui lòng chọn một hàng và điền đầy đủ thông tin!");
            }
            else
            {
                if (this.dgvUpdate.SelectedRows.Count < 1)
                {
                 
                    MessageBox.Show("Vui lòng chọn một hàng để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    var Username = this.dgvUpdate.CurrentRow.Cells[0].Value.ToString();
                    var FullName = this.dgvUpdate.CurrentRow.Cells[1].Value.ToString();

                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }

                    var query = "UPDATE UserInfo SET FullName = '" + txtFullName.Text + "',DOB = '" + dtpDOB.Value.ToString("yyyy-MM-dd") + "',Gender = '" + cmbGender.Text + "',Role ='" + cmbRole.Text + "',Email ='" + txtEmail.Text + "' WHERE Username='" + txtUserName.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(query);

                 
                    MessageBox.Show("Thông tin của " + txtFullName.Text + " đã được cập nhật thành công!");

                    this.PopulateGridView();
                    this.ClearContent();
                }
                catch (Exception exc)
                {
                   
                    MessageBox.Show("Đã có lỗi xảy ra: " + exc.Message);
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Cập nhật tìm kiếm cho nhất quán (và sửa lỗi logic)
            try
            {
                string keyword = this.txtSearch.Text.Trim();
                // Câu truy vấn gốc chỉ tìm Staff/Manager
                string baseQuery = "(Role = 'Staff' OR Role = 'Manager')";

                string sql;
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    sql = "select * from UserInfo where " + baseQuery + ";";
                }
                else
                {
                    // Tìm theo Tên, Tên đăng nhập hoặc Vai trò VÀ phải là Staff/Manager
                    sql = "select * from UserInfo where (FullName LIKE N'%" + keyword + "%' OR Username LIKE N'%" + keyword + "%' OR Role LIKE N'%" + keyword + "%') AND " + baseQuery + ";";
                }

                this.PopulateGridView(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
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

                // (Lưu ý: Đảm bảo class DataAccess của bạn hỗ trợ SQL Injection an toàn)
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