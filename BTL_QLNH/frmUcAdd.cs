using System;
using System.Windows.Forms;
using BTL_QLNH.BUS; // Gọi BUS

namespace BTL_QLNH
{
    public partial class frmUcAdd : UserControl
    {
        private FoodBUS bus;

        public frmUcAdd()
        {
            InitializeComponent();
            bus = new FoodBUS(); // Khởi tạo BUS

            // Setup ComboBox
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new string[] { "Burger", "Đồ Uống", "Tráng Miệng", "Cà Phê", "Pizza", "Mì Ý" });
            cmbCategory.SelectedIndex = 0;

            LoadData();
            RefreshID();
        }

        private void LoadData()
        {
            // SỬA LỖI: Gọi GetListFood thay vì GetList
            dgvAdd.DataSource = bus.GetListFood();
        }

        private void RefreshID()
        {
            txtFoodId.Text = bus.GenerateNewID();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // Gọi BUS xử lý, Form không cần biết DB là gì
            string result = bus.AddFood(txtFoodId.Text, txtFoodName.Text, cmbCategory.Text, txtPrice.Text);

            if (result == "Success")
            {
                MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show(result, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtFoodName.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedIndex = 0;
            txtSearch.Clear();
            dgvAdd.ClearSelection();
            RefreshID(); // Sinh ID mới
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                LoadData();
            else
                // SỬA LỖI: Gọi SearchFood thay vì Search
                dgvAdd.DataSource = bus.SearchFood(txtSearch.Text.Trim());
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmUcAdd_Load(object sender, EventArgs e)
        {
            dgvAdd.ClearSelection();
        }

        // Các hàm event thừa có thể giữ trống
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}