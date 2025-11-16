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
    public partial class frmUcUpdate : UserControl
    {
        private DataAccess Da { get; set; }

        public frmUcUpdate()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();

            cmbCategory.Items.Add("Burger");
            cmbCategory.Items.Add("Đồ Uống");
            cmbCategory.Items.Add("Tráng Miệng");
            cmbCategory.Items.Add("Cà Phê");
            cmbCategory.Items.Add("Pizza");
            cmbCategory.Items.Add("Mì Ý");

            cmbCategory.SelectedIndex = 0;
        }
        private void PopulateGridView(string sql = "select FoodDetails.FoodId,FoodDetails.FoodName,FoodPrices.Category,FoodPrices.Price from FoodDetails,FoodPrices where FoodDetails.FoodId = FoodPrices.FoodId;")
        {
            this.Da.ExecuteQueryTable(sql);

            //this.dgvAdd.AutoGenerateColumns = false;
            this.dgvUpdate.DataSource = Da.Ds.Tables[0];
        }

        private void ClearContent()
        {
            this.txtFoodId.Clear();
            this.txtFoodName.Clear();
            this.txtPrice.Clear();
            this.cmbCategory.Text = null;

            this.txtSearch.Clear();

            this.dgvUpdate.ClearSelection();
            //this.AutoIdGenerate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtFoodId.Text) || String.IsNullOrEmpty(this.txtFoodName.Text) ||
                String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.cmbCategory.Text))
            {
                MessageBox.Show("Vui lòng chọn một hàng và điền đầy đủ thông tin.");
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
                    var FoodId = this.dgvUpdate.CurrentRow.Cells[0].Value.ToString();
                    var FoodName = this.dgvUpdate.CurrentRow.Cells[1].Value.ToString();

                  
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }

                    var query = "BEGIN TRANSACTION; UPDATE FoodDetails SET FoodName = '" + txtFoodName.Text + "'WHERE FoodId='" + txtFoodId.Text + "';UPDATE FoodPrices SET Category = '" + cmbCategory.Text + "',Price = '" + txtPrice.Text + "'WHERE FoodId='" + txtFoodId.Text + "';COMMIT;";
                    var count = this.Da.ExecuteDMLQuery(query);

                    // if (count == 1)
                    MessageBox.Show(txtFoodName.Text + " đã được cập nhật!");
                    // else
                    //     MessageBox.Show("Cập nhật dữ liệu thất bại");

                    this.PopulateGridView();
                    this.ClearContent();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Đã có lỗi xảy ra: " + exc.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        // --- Đã cập nhật hàm tìm kiếm cho nhất quán với các form khác ---
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

                // 2. Tìm kiếm theo từ khóa (giống hệt frmUcAdd/frmUcDelete)
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

        private void dgvUpdate_SelectionChanged(object sender, EventArgs e)
        {
            // Thêm kiểm tra dgvUpdate.CurrentRow != null
            if (dgvUpdate.SelectedRows != null && dgvUpdate.SelectedRows.Count > 0 && dgvUpdate.CurrentRow != null)
            {
                string FoodId = dgvUpdate.CurrentRow.Cells[0].Value.ToString();
                string FoodName = dgvUpdate.CurrentRow.Cells[1].Value.ToString();
                string Category = dgvUpdate.CurrentRow.Cells[2].Value.ToString();
                string Price = dgvUpdate.CurrentRow.Cells[3].Value.ToString();

                txtFoodId.Text = FoodId;
                txtFoodName.Text = FoodName;
                cmbCategory.Text = Category;
                txtPrice.Text = Price;
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}