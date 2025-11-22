using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; // Để định dạng ngày tháng VN
using System.Threading;    // Để xử lý luồng giao diện
using BTL_QLNH.BUS;        // QUAN TRỌNG: Gọi lớp BUS

namespace BTL_QLNH
{
    public partial class frmUcUpdateUsers : UserControl
    {
        // Khai báo BUS
        private UserBUS bus;

        public frmUcUpdateUsers()
        {
            // 1. Cài đặt hiển thị Tiếng Việt cho ngày tháng
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");

            InitializeComponent();

            // 2. Khởi tạo BUS
            bus = new UserBUS();

            // 3. Cài đặt giao diện ban đầu
            this.dgvUpdate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpdate.MultiSelect = false;
            this.dgvUpdate.ReadOnly = true;

            // Thêm dữ liệu cho ComboBox Giới tính
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new string[] { "Nam", "Nữ" });

            // Thêm dữ liệu cho ComboBox Vai trò
            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(new string[] { "Quản Trị Viên", "Nhân Viên", "Quản Lý" });

            // Định dạng DateTimePicker
            this.dtpDOB.Format = DateTimePickerFormat.Custom;
            this.dtpDOB.CustomFormat = "dddd, dd/MM/yyyy";

            // 4. Tải dữ liệu lên lưới
            LoadData();
        }

        // Hàm tải dữ liệu từ BUS
        private void LoadData()
        {
            // Gọi BUS lấy danh sách thay vì gọi trực tiếp SQL
            this.dgvUpdate.DataSource = bus.GetList();
        }

        // Hàm làm sạch ô nhập
        private void ClearContent()
        {
            this.txtUserName.Clear();
            this.txtFullName.Clear();
            this.txtEmail.Clear();
            this.cmbGender.SelectedIndex = -1;
            this.cmbRole.SelectedIndex = -1;
            this.dtpDOB.Value = DateTime.Now;
            this.txtSearch.Clear();
            this.dgvUpdate.ClearSelection();
        }

        // Sự kiện chọn dòng trên lưới -> Đổ dữ liệu vào ô nhập
        private void dgvUpdate_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvUpdate.SelectedRows != null && dgvUpdate.SelectedRows.Count > 0 && dgvUpdate.CurrentRow != null)
            {
                // Lấy dữ liệu từ các cột (Cells index phải khớp với Database)
                string userName = dgvUpdate.CurrentRow.Cells[0].Value.ToString();
                string fullName = dgvUpdate.CurrentRow.Cells[1].Value.ToString();
                string dob = dgvUpdate.CurrentRow.Cells[2].Value.ToString();
                string gender = dgvUpdate.CurrentRow.Cells[3].Value.ToString();
                string role = dgvUpdate.CurrentRow.Cells[4].Value.ToString();
                string email = dgvUpdate.CurrentRow.Cells[5].Value.ToString();

                // Gán vào ô nhập
                txtUserName.Text = userName;
                txtFullName.Text = fullName;

                // Xử lý ngày tháng an toàn (tránh lỗi nếu ngày null)
                try
                {
                    dtpDOB.Value = Convert.ToDateTime(dob);
                }
                catch
                {
                    dtpDOB.Value = DateTime.Now;
                }

                cmbGender.Text = gender;
                cmbRole.Text = role;
                txtEmail.Text = email;
            }
        }

        // Nút Cập Nhật (Update)
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvUpdate.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // GỌI BUS ĐỂ XỬ LÝ CẬP NHẬT
                string result = bus.UpdateInfo(
                    txtUserName.Text,
                    txtFullName.Text,
                    dtpDOB.Value,
                    cmbGender.Text,
                    cmbRole.Text,
                    txtEmail.Text
                );

                if (result == "Success")
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();   // Tải lại danh sách
                    ClearContent(); // Xóa trắng form
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Nút Xóa (Delete)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvUpdate.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string user = txtUserName.Text;
            string name = txtFullName.Text;

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên '{name}' ({user})?\nHành động này sẽ xóa cả tài khoản đăng nhập và KHÔNG THỂ hoàn tác!",
                                              "Cảnh báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                // GỌI BUS ĐỂ XỬ LÝ XÓA
                string result = bus.DeleteUser(user);

                if (result == "Success")
                {
                    MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearContent();
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Nút Làm mới (Clear)
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearContent();
        }

        // Tìm kiếm (Search)
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadData(); // Nếu ô tìm kiếm trống thì load lại toàn bộ
            }
            else
            {
                // GỌI BUS TÌM KIẾM
                this.dgvUpdate.DataSource = bus.Search(keyword);
            }
        }

    }
}