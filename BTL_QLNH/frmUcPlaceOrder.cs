using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing; // Để in hóa đơn
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QLNH.BUS; // QUAN TRỌNG: Gọi lớp BUS

namespace BTL_QLNH
{
    public partial class frmUcPlaceOrder : UserControl
    {
        // Khai báo 2 BUS:
        // 1. OrderBUS: Để lưu đơn hàng
        // 2. FoodBUS: Để lấy danh sách món ăn và giá tiền
        private OrderBUS orderBUS;
        private FoodBUS foodBUS;

        protected float total = 0.0f;
        // Biến amount nếu không dùng có thể xóa, nhưng để lại để tránh lỗi CS0169 warning
        int amount;

        public frmUcPlaceOrder()
        {
            InitializeComponent();

            // KHỞI TẠO BUS
            this.orderBUS = new OrderBUS();
            this.foodBUS = new FoodBUS(); // Khởi tạo FoodBUS để tra cứu món ăn

            this.dgvPlaceOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Cài đặt ngày giờ
            dtpOrderDate.Value = DateTime.Now;
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.CustomFormat = "dddd, dd/MM/yyyy";

            // Load danh mục vào ComboBox
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new string[] { "Burger", "Đồ Uống", "Tráng Miệng", "Cà Phê", "Pizza", "Mì Ý" });
            cmbCategory.SelectedIndex = 0;

            // Sinh mã hóa đơn tự động
            this.AutoIdGenerate();
        }

        private void frmUcPlaceOrder_Load(object sender, EventArgs e)
        {
            // Tạo cột cho GridView nếu chưa có
            if (dgvPlaceOrder.Columns.Count == 0)
            {
                dgvPlaceOrder.Columns.Add("colName", "Tên Món");
                dgvPlaceOrder.Columns.Add("colUnitPrice", "Đơn Giá");
                dgvPlaceOrder.Columns.Add("colQty", "Số Lượng");
                dgvPlaceOrder.Columns.Add("colPrice", "Thành Tiền");
            }
            StyleDataGridView(dgvPlaceOrder);
        }

        private void AutoIdGenerate()
        {
            this.txtOrderId.Text = orderBUS.GenerateOrderID();
        }

        private void ClearContent()
        {
            this.txtCustomerName.Clear();
            this.txtItemName.Clear();
            this.nudQuantity.Value = 0;
            this.dtpOrderDate.Value = DateTime.Now;
            this.txtPrice.Clear();
            this.txtTotal.Clear();
            this.cmbCategory.SelectedIndex = 0;
            this.txtSearch.Clear();
            this.listBox1.Items.Clear();
            this.dgvPlaceOrder.Rows.Clear();
            this.lblTK.Text = "0.0";
            this.total = 0.0f;
            this.AutoIdGenerate();
        }

        // --- SỰ KIỆN NÚT THANH TOÁN ---
        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (dgvPlaceOrder.Rows.Count <= 1) // Chỉ có dòng header hoặc dòng trống
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Thông báo");
                return;
            }

            string result = orderBUS.SaveOrder(
                txtOrderId.Text,
                txtCustomerName.Text,
                dtpOrderDate.Value,
                lblTK.Text,
                dgvPlaceOrder.Rows
            );

            if (result == "Success")
            {
                MessageBox.Show("Đã đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearContent();
            }
            else
            {
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- NÚT THÊM VÀO GIỎ ---
        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtItemName.Text) || String.IsNullOrEmpty(this.txtPrice.Text) ||
                String.IsNullOrEmpty(this.nudQuantity.Text) || String.IsNullOrEmpty(this.txtTotal.Text))
                {
                    MessageBox.Show("Vui lòng chọn món và nhập số lượng!");
                    return;
                }

                if (nudQuantity.Value > 0)
                {
                    int n = dgvPlaceOrder.Rows.Add();
                    dgvPlaceOrder.Rows[n].Cells[0].Value = txtItemName.Text;
                    dgvPlaceOrder.Rows[n].Cells[1].Value = txtPrice.Text;
                    dgvPlaceOrder.Rows[n].Cells[2].Value = nudQuantity.Value.ToString();
                    dgvPlaceOrder.Rows[n].Cells[3].Value = txtTotal.Text;

                    total += float.Parse(txtTotal.Text);
                    lblTK.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // --- NÚT XÓA KHỎI GIỎ ---
        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (dgvPlaceOrder.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPlaceOrder.SelectedRows[0];
                if (selectedRow.IsNewRow) return;

                float totalValue = float.Parse(selectedRow.Cells[3].Value.ToString());
                dgvPlaceOrder.Rows.Remove(selectedRow);
                total -= totalValue;
                lblTK.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món cần xóa.");
            }
        }

        // --- CÁC LOGIC UI ĐÃ ĐƯỢC KHÔI PHỤC (DÙNG BUS) ---

        // 1. Khi chọn Danh mục -> Load món ăn vào ListBox
        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem == null) return;

            string category = cmbCategory.SelectedItem.ToString();
            listBox1.Items.Clear();

            // Lấy toàn bộ danh sách món từ BUS
            DataTable dt = foodBUS.GetListFood();

            // Lọc thủ công (Vì ta chưa viết hàm GetFoodByCategory trong BUS để tiết kiệm thời gian)
            // Cách này vẫn đảm bảo 3 lớp vì dữ liệu lấy từ BUS
            foreach (DataRow row in dt.Rows)
            {
                if (row["Category"].ToString() == category)
                {
                    listBox1.Items.Add(row["FoodName"].ToString());
                }
            }
        }

        // 2. Khi tìm kiếm -> Lọc món trong ListBox
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string category = cmbCategory.Text;
            listBox1.Items.Clear();

            // Dùng hàm Search của BUS
            DataTable dt = foodBUS.SearchFood(keyword);

            foreach (DataRow row in dt.Rows)
            {
                // Chỉ hiển thị nếu đúng category đang chọn
                if (row["Category"].ToString() == category)
                {
                    listBox1.Items.Add(row["FoodName"].ToString());
                }
            }
        }

        // 3. Khi chọn món trong ListBox -> Điền giá và Tên
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            string foodName = listBox1.SelectedItem.ToString();
            txtItemName.Text = foodName;
            nudQuantity.Value = 0;
            txtTotal.Clear();

            // Tìm thông tin món ăn để lấy giá
            DataTable dt = foodBUS.SearchFood(foodName);
            if (dt.Rows.Count > 0)
            {
                txtPrice.Text = dt.Rows[0]["Price"].ToString();
            }
        }

        // 4. Khi thay đổi số lượng -> Tính tổng tiền
        private void nudQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPrice.Text))
                {
                    float price = float.Parse(txtPrice.Text);
                    float qty = (float)nudQuantity.Value;
                    txtTotal.Text = (price * qty).ToString();
                }
            }
            catch { }
        }

        // 5. Khi click vào lưới -> Lấy số tiền (để xử lý logic xóa nếu cần)
        private void dgvPlaceOrder_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvPlaceOrder.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    amount = int.Parse(dgvPlaceOrder.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
            }
            catch { }
        }

        // --- CÁC HÀM HỖ TRỢ KHÁC (IN ẤN, CLEAR...) ---

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            PrintPDF();
        }

        private void PrintPDF()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
            Font font = new Font("Arial", 12);
            float y = 50;
            float x = 50;

            e.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", fontTitle, Brushes.Red, x + 200, y);
            y += 40;
            e.Graphics.DrawString("Ngày: " + dtpOrderDate.Value.ToString("dd/MM/yyyy HH:mm"), font, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString("Khách hàng: " + txtCustomerName.Text, font, Brushes.Black, x, y);
            y += 30;
            e.Graphics.DrawString("----------------------------------------------------------------", font, Brushes.Black, x, y);
            y += 20;

            e.Graphics.DrawString("Món ăn", font, Brushes.Black, x, y);
            e.Graphics.DrawString("SL", font, Brushes.Black, x + 250, y);
            e.Graphics.DrawString("Giá", font, Brushes.Black, x + 300, y);
            e.Graphics.DrawString("Tổng", font, Brushes.Black, x + 400, y);
            y += 20;

            foreach (DataGridViewRow row in dgvPlaceOrder.Rows)
            {
                if (row.IsNewRow) continue;
                string itemName = row.Cells[0].Value?.ToString() ?? "";
                string quantity = row.Cells[2].Value?.ToString() ?? "";
                string price = row.Cells[1].Value?.ToString() ?? "";
                string totalItem = row.Cells[3].Value?.ToString() ?? "";

                if (!string.IsNullOrEmpty(itemName))
                {
                    e.Graphics.DrawString(itemName, font, Brushes.Black, x, y);
                    e.Graphics.DrawString(quantity, font, Brushes.Black, x + 250, y);
                    e.Graphics.DrawString(price, font, Brushes.Black, x + 300, y);
                    e.Graphics.DrawString(totalItem, font, Brushes.Black, x + 400, y);
                    y += 20;
                }
            }

            e.Graphics.DrawString("----------------------------------------------------------------", font, Brushes.Black, x, y);
            y += 20;
            e.Graphics.DrawString("TỔNG CỘNG: " + lblTK.Text + " VNĐ", new Font("Arial", 14, FontStyle.Bold), Brushes.Blue, x + 250, y);
        }

        void StyleDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.RowTemplate.Height = 30;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}