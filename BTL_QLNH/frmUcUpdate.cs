using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QLNH.BUS; // QUAN TRỌNG: Gọi lớp BUS

namespace BTL_QLNH
{
    public partial class frmUcUpdate : UserControl
    {
        // Khai báo BUS
        private FoodBUS bus;

        public frmUcUpdate()
        {
            InitializeComponent();

            // 1. Khởi tạo BUS
            bus = new FoodBUS();

            // 2. Setup ComboBox Danh mục
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new string[] { "Burger", "Đồ Uống", "Tráng Miệng", "Cà Phê", "Pizza", "Mì Ý" });
            cmbCategory.SelectedIndex = 0;

            // 3. Tải dữ liệu lên lưới
            LoadData();
        }

        // Hàm tải dữ liệu (Gọi BUS)
        private void LoadData()
        {
            // SỬA LỖI: Gọi GetListFood() thay vì GetList()
            dgvUpdate.DataSource = bus.GetListFood();
        }

        // Nút Cập Nhật
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn hàng nào chưa
            if (dgvUpdate.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn món cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra dữ liệu trống (cơ bản)
            if (String.IsNullOrEmpty(this.txtFoodId.Text) || String.IsNullOrEmpty(this.txtFoodName.Text) ||
                String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.cmbCategory.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi xác nhận
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn cập nhật món này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // GỌI BUS ĐỂ UPDATE
                string result = bus.UpdateFood(txtFoodId.Text, txtFoodName.Text, cmbCategory.Text, txtPrice.Text);

                if (result == "Success")
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();     // Tải lại lưới
                    ClearContent(); // Xóa trắng ô nhập
                }
                else
                {
                    // Hiển thị lỗi do BUS trả về (ví dụ: sai định dạng giá tiền)
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sự kiện khi click vào một dòng trên lưới
        private void dgvUpdate_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra để tránh lỗi khi lưới trống hoặc đang load
            if (dgvUpdate.SelectedRows != null && dgvUpdate.SelectedRows.Count > 0 && dgvUpdate.CurrentRow != null)
            {
                // Đổ dữ liệu từ lưới vào các ô Textbox
                txtFoodId.Text = dgvUpdate.CurrentRow.Cells[0].Value.ToString();
                txtFoodName.Text = dgvUpdate.CurrentRow.Cells[1].Value.ToString();
                cmbCategory.Text = dgvUpdate.CurrentRow.Cells[2].Value.ToString();
                txtPrice.Text = dgvUpdate.CurrentRow.Cells[3].Value.ToString();
            }
        }

        // Chức năng Tìm kiếm
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadData(); // Nếu ô tìm kiếm trống thì load lại tất cả
            }
            else
            {
                // SỬA LỖI: Gọi SearchFood() thay vì Search()
                dgvUpdate.DataSource = bus.SearchFood(txtSearch.Text.Trim());
            }
        }

        // Hàm xóa trắng các ô nhập liệu
        private void ClearContent()
        {
            this.txtFoodId.Clear();
            this.txtFoodName.Clear();
            this.txtPrice.Clear();
            this.cmbCategory.SelectedIndex = 0;
            this.txtSearch.Clear();
            this.dgvUpdate.ClearSelection();
        }

        // Nút Làm mới (Clear)
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        // Nút Hiển thị lại (Show All)
        private void btnShow_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        // Các sự kiện thừa (Giữ lại để tránh lỗi designer nếu bạn đã lỡ double click vào nó)
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}