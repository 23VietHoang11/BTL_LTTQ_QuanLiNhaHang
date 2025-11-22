using System;
using System.Windows.Forms;
using BTL_QLNH.BUS; // Gọi BUS

namespace BTL_QLNH
{
    public partial class frmUcDelete : UserControl
    {
        private FoodBUS bus;

        public frmUcDelete()
        {
            InitializeComponent();
            bus = new FoodBUS();
            LoadData();
        }

        private void LoadData()
        {
            // SỬA LỖI: Gọi GetListFood thay vì GetList
            dgvDelete.DataSource = bus.GetListFood();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDelete.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy ID và Tên từ dòng đang chọn
            string FoodId = this.dgvDelete.CurrentRow.Cells[0].Value.ToString();
            string FoodName = this.dgvDelete.CurrentRow.Cells[1].Value.ToString();

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa món '" + FoodName + "' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                // Gọi BUS để Xóa
                string result = bus.DeleteFood(FoodId);

                if (result == "Success")
                {
                    MessageBox.Show(FoodName + " đã được xóa khỏi danh sách.");
                    this.LoadData();
                    this.ClearContent();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        private void ClearContent()
        {
            this.txtFoodId.Clear();
            this.txtFoodName.Clear();
            this.txtPrice.Clear();
            this.txtCategory.Text = null;
            this.txtSearch.Clear();
            this.dgvDelete.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtSearch.Text))
            {
                this.LoadData();
            }
            else
            {
                // SỬA LỖI: Gọi SearchFood thay vì Search
                this.dgvDelete.DataSource = bus.SearchFood(txtSearch.Text.Trim());
            }
        }

        private void dgvDelete_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDelete.SelectedRows != null && dgvDelete.SelectedRows.Count > 0 && dgvDelete.CurrentRow != null)
            {
                txtFoodId.Text = dgvDelete.CurrentRow.Cells[0].Value.ToString();
                txtFoodName.Text = dgvDelete.CurrentRow.Cells[1].Value.ToString();
                txtCategory.Text = dgvDelete.CurrentRow.Cells[2].Value.ToString();
                txtPrice.Text = dgvDelete.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}