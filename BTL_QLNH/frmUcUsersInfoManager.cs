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
    public partial class frmUcUsersInfoManager : UserControl
    {
        private DataAccess Da { get; set; }
        public frmUcUsersInfoManager()
        {
            // Thêm 2 dòng này đểDateTimePicker hiển thị tiếng Việt
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");

            InitializeComponent();

            this.Da = new DataAccess();

            this.PopulateGridView();

            // Thêm các mục ComboBox bằng tiếng Việt
            cmbGender.Items.Add("Nam");
            cmbGender.Items.Add("Nữ");

            cmbRole.Items.Add("Quản Trị Viên");
            cmbRole.Items.Add("Nhân Viên");
            cmbRole.Items.Add("Quản Lý");

            // Thêm định dạng ngày sinh
            this.dtpDOB.Format = DateTimePickerFormat.Custom;
            this.dtpDOB.CustomFormat = "dddd, dd/MM/yyyy";
        }
        private void PopulateGridView(string sql = "select * from UserInfo;")
        {
            this.Da.ExecuteQueryTable(sql);
            this.dgvUpdate.DataSource = Da.Ds.Tables[0];
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            // Cập nhật hàm tìm kiếm cho tốt hơn
            try
            {
                string keyword = this.txtSearch.Text.Trim();
                string sql;
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    sql = "select * from UserInfo;"; // Tải lại tất cả
                }
                else
                {
                    // Tìm kiếm theo Tên, Tên đăng nhập hoặc Vai trò
                    sql = "select * from UserInfo where FullName LIKE N'%" + keyword + "%' OR Username LIKE N'%" + keyword + "%' OR Role LIKE N'%" + keyword + "%';";
                }
                this.PopulateGridView(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void dgvUpdate_SelectionChanged(object sender, EventArgs e)
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

                // Sửa lỗi gán ngày:
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
    }
}