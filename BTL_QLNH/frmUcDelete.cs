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
    public partial class frmUcDelete : UserControl
    {
        private DataAccess Da { get; set; }

        public frmUcDelete()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select FoodDetails.FoodId,FoodDetails.FoodName,FoodPrices.Category,FoodPrices.Price from FoodDetails,FoodPrices where FoodDetails.FoodId = FoodPrices.FoodId;")
        {
            this.Da.ExecuteQueryTable(sql);

            //this.dgvAdd.AutoGenerateColumns = false;
            this.dgvDelete.DataSource = Da.Ds.Tables[0];
        }

        private void ClearContent()
        {
            this.txtFoodId.Clear();
            this.txtFoodName.Clear();
            this.txtPrice.Clear();
            this.txtCategory.Text = null;
            this.txtSearch.Clear();

            this.dgvDelete.ClearSelection();
            //this.AutoIdGenerate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvDelete.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var FoodId = this.dgvDelete.CurrentRow.Cells[0].Value.ToString();
                var FoodName = this.dgvDelete.CurrentRow.Cells[1].Value.ToString();

              
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }

                var query = "delete from FoodDetails where FoodId = '" + FoodId + "';";
                var query2 = "delete from FoodPrices where FoodId = '" + FoodId + "';";
                var count = this.Da.ExecuteDMLQuery(query);
                var count2 = this.Da.ExecuteDMLQuery(query2);

                if (count == 1 && count2 == 1)
                {
                   
                    MessageBox.Show(FoodName + " đã được xóa khỏi danh sách.");
                }
                else
                {
                   
                    MessageBox.Show("Xóa dữ liệu thất bại");
                }

                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + exc.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        // --- Đã cập nhật hàm tìm kiếm cho nhất quán với frmUcAdd ---
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // 1. Nếu ô tìm kiếm trống -> Load lại toàn bộ danh sách
                if (string.IsNullOrWhiteSpace(this.txtSearch.Text))
                {
                    this.PopulateGridView();
                    return;
                }

                // 2. Tìm kiếm theo từ khóa (giống hệt frmUcAdd)
                string keyword = this.txtSearch.Text.Trim();
                string sql = @"SELECT FoodDetails.FoodId, FoodDetails.FoodName, FoodPrices.Category, FoodPrices.Price 
                                FROM FoodDetails, FoodPrices 
                                WHERE FoodDetails.FoodId = FoodPrices.FoodId 
                                AND (FoodDetails.FoodName LIKE N'%" + keyword + "%' OR FoodPrices.Category LIKE N'%" + keyword + "%');";

                this.PopulateGridView(sql);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void dgvDelete_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDelete.SelectedRows != null && dgvDelete.SelectedRows.Count > 0 && dgvDelete.CurrentRow != null)
            {
                string FoodId = dgvDelete.CurrentRow.Cells[0].Value.ToString();
                string FoodName = dgvDelete.CurrentRow.Cells[1].Value.ToString();
                string Category = dgvDelete.CurrentRow.Cells[2].Value.ToString();
                string Price = dgvDelete.CurrentRow.Cells[3].Value.ToString();

                txtFoodId.Text = FoodId;
                txtFoodName.Text = FoodName;
                txtCategory.Text = Category;
                txtPrice.Text = Price;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}