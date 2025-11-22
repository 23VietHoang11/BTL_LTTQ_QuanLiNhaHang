using System;
using System.Windows.Forms;
using BTL_QLNH.BUS; // Gọi BUS

namespace BTL_QLNH
{
    // Ví dụ cho frmUcHomeAdmin (Các file khác làm y hệt)
    public partial class frmUcManagerHome : UserControl
    {
        private FoodBUS foodBUS;

        public frmUcManagerHome()
        {
            InitializeComponent();
            foodBUS = new FoodBUS(); // Khởi tạo BUS
            LoadMenu();
        }

        private void LoadMenu()
        {
            // Gọi hàm lấy danh sách món ăn từ FoodBUS
            // (Hàm GetAllFoods hoặc GetListFood tuỳ tên bạn đặt trong FoodBUS trước đó)
            dgvMenu.DataSource = foodBUS.GetListFood();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                LoadMenu();
            else
                dgvMenu.DataSource = foodBUS.SearchFood(txtSearch.Text);
        }
    }
}