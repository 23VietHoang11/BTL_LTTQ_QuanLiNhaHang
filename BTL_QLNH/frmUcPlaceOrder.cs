using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLNH
{
    public partial class frmUcPlaceOrder : UserControl
    {
        private DataAccess Da { get; set; }

        void StyleDataGridView(DataGridView dgv)
        {
            // 1. Cài đặt chung cho Bảng
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); // Màu dòng chẵn
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Chỉ kẻ ngang
            dgv.DefaultCellStyle.SelectionBackColor = Color.SeaGreen; // Màu khi chọn dòng
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White; // Màu nền bảng

            // 2. Cài đặt cho Tiêu đề (Header) - Giống hình bạn gửi
            dgv.EnableHeadersVisualStyles = false; // BẮT BUỘC
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Bỏ viền tiêu đề
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255); // Màu tím xanh (Giống hình)
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Chữ màu trắng
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Font chữ đẹp hơn
            dgv.ColumnHeadersHeight = 40; // Chiều cao tiêu đề

            // 3. Cài đặt cho các dòng dữ liệu
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // 4. Căn chỉnh cột (Tự lấp đầy chiều rộng)
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public frmUcPlaceOrder()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoIdGenerate();
            this.dgvPlaceOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtpOrderDate.Value = DateTime.Now;
            // 1. Xóa các mục cũ (nếu có) để tránh trùng lặp
            cmbCategory.Items.Clear();

            // 2. Thêm từng mục vào danh sách
            cmbCategory.Items.Add("Burger");
            cmbCategory.Items.Add("Beverage");
            cmbCategory.Items.Add("Dessert");
            cmbCategory.Items.Add("Coffee");
            cmbCategory.Items.Add("Pizza");
            cmbCategory.Items.Add("Pasta");

            // 3. Chọn mặc định mục đầu tiên (để ô không bị trống)
            cmbCategory.SelectedIndex = 0;
        }

        private void frmUcPlaceOrder_Load(object sender, EventArgs e)
        {
            // Tạo cột giả lập để xem thử (Nếu bạn chưa kết nối CSDL)
            dgvPlaceOrder.Columns.Add("colName", "Item's Name");
            dgvPlaceOrder.Columns.Add("colUnitPrice", "Unit Price");
            dgvPlaceOrder.Columns.Add("colQty", "Quantity");
            dgvPlaceOrder.Columns.Add("colPrice", "Price");

            // Áp dụng giao diện
            StyleDataGridView(dgvPlaceOrder);
        }

        private void AutoIdGenerate()
        {
            try
            {
                var q = "select OrderID from OrdersInfo order by OrderID desc;";
                var dt = this.Da.ExecuteQueryTable(q);

                // THÊM BƯỚC KIỂM TRA NÀY
                if (dt.Rows.Count > 0)
                {
                    // 1. Nếu bảng ĐÃ CÓ dữ liệu (đã có đơn hàng)
                    var lastId = dt.Rows[0][0].ToString();

                    // Tách ID cũ (Giả sử ID không có chữ, chỉ có số)
                    int temp = Convert.ToInt32(lastId);

                    string newId = (++temp).ToString("d3"); // Tạo ID mới dạng "002", "003"
                    this.txtOrderId.Text = newId;
                }
                else
                {
                    // 2. Nếu bảng RỖNG (đây là đơn hàng đầu tiên)
                    // Tự gán ID đầu tiên, ví dụ: "001"
                    this.txtOrderId.Text = "001";
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có vấn đề gì khác
                MessageBox.Show("Lỗi khi tạo ID đơn hàng: " + ex.Message);
            }
        }

        private void ClearContent()
        {
            this.txtCustomerName.Clear();
            this.txtItemName.Clear();
            this.txtOrderId.Clear();
            this.nudQuantity.Value = 0;
            this.dtpOrderDate.Value = DateTime.Now;
            this.txtPrice.Clear();
            this.txtTotal.Clear();
            this.cmbCategory.SelectedIndex = 0;
            this.txtSearch.Clear();
            this.listBox1.Items.Clear();
            this.dgvPlaceOrder.Rows.Clear();


            this.AutoIdGenerate();
        }

        protected int n;
        protected float total = 0.0f;

        int amount;

        private void PrintPDF()
        {
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            printDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);

            float y = 50;

            e.Graphics.DrawString("Date & time: " + dtpOrderDate.Value, font, Brushes.Black, new PointF(50, y));
            y += 20;

            e.Graphics.DrawString("Customer Name: " + txtCustomerName.Text, font, Brushes.Black, new PointF(50, y));
            y += 20;

            int i = 0;
            while (i < dgvPlaceOrder.Rows.Count)
            {
                string itemName = dgvPlaceOrder.Rows[i].Cells[0].Value.ToString();
                string quantity = dgvPlaceOrder.Rows[i].Cells[2].Value.ToString();
                string price = dgvPlaceOrder.Rows[i].Cells[1].Value.ToString();
                string total = dgvPlaceOrder.Rows[i].Cells[3].Value.ToString();

                string orderItem = string.Format("{0} x {1} (Price: {2}, Total: {3})", quantity, itemName, price, total);
                e.Graphics.DrawString(orderItem, font, Brushes.Black, new PointF(50, y));
                y += 20;

                i++;
            }


            string totalAmount = "Total Amount: " + lblTK.Text;
            e.Graphics.DrawString(totalAmount, font, Brushes.Black, new PointF(50, y));
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem.ToString();

            try
            {
                string connectionString = @"Data Source=(local);Initial Catalog=RestaurantManagement;User ID=sa;Password=123;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "select FoodDetails.FoodName from FoodDetails,FoodPrices where FoodDetails.FoodId=FoodPrices.FoodId and FoodPrices.Category=@Category and FoodDetails.FoodName like '%" + this.txtSearch.Text + "%';";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Category", selectedCategory);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        listBox1.Items.Clear();
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader["FoodName"].ToString());
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving food names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtItemName.Text) || String.IsNullOrEmpty(this.txtPrice.Text) ||
                String.IsNullOrEmpty(this.nudQuantity.Text) || String.IsNullOrEmpty(this.txtTotal.Text))
                {
                    MessageBox.Show("Fields are blank!");
                }
                else
                {
                    if (nudQuantity.Text != "0" && txtTotal.Text != null)
                    {
                        n = dgvPlaceOrder.Rows.Add();
                        dgvPlaceOrder.Rows[n].Cells[0].Value = txtItemName.Text;
                        dgvPlaceOrder.Rows[n].Cells[1].Value = txtPrice.Text;
                        dgvPlaceOrder.Rows[n].Cells[2].Value = nudQuantity.Text;
                        dgvPlaceOrder.Rows[n].Cells[3].Value = txtTotal.Text;

                        total += int.Parse(txtTotal.Text);
                        lblTK.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Minimum quantity need to be 1!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtOrderId.Text) || String.IsNullOrEmpty(this.txtCustomerName.Text))
            {
                MessageBox.Show("Fields are blank!");
                return; 
            }

            DialogResult d = MessageBox.Show("Are you sure want to confirm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d == DialogResult.No)
                return;

            try
            {
                string sql1 = "INSERT INTO OrdersInfo (OrderID,CustomerName,OrderDate,Total) VALUES ('" + txtOrderId.Text + "', '" + txtCustomerName.Text + "','" + dtpOrderDate.Value.ToString("yyyy-MM-dd") + "','" + lblTK.Text + "');";
                Da.ExecuteDMLQuery(sql1);

                foreach (DataGridViewRow row in dgvPlaceOrder.Rows)
                {
                    if (row.IsNewRow) continue;

                    string itemName = row.Cells[0].Value.ToString();
                    string quantity = row.Cells[2].Value.ToString();

                    string sql2 = "INSERT INTO OrdersItems (OrderID, Item, Quantity) VALUES ('" + txtOrderId.Text + "', '" + itemName + "','" + quantity + "')";
                    Da.ExecuteDMLQuery(sql2); 
                }

                MessageBox.Show("Successfully added!");
                this.ClearContent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured!", ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtTotal.Clear();
            nudQuantity.Text = "0";


            string text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;

            string query = "select FoodPrices.Price from FoodPrices inner join FoodDetails on FoodDetails.FoodId=FoodPrices.FoodId and FoodDetails.FoodName='" + txtItemName.Text + "';";
            Da.ExecuteQueryTable(query);

            try
            {
                txtPrice.Text = Da.Ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (dgvPlaceOrder.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvPlaceOrder.SelectedRows[0];

                int totalValue = int.Parse(selectedRow.Cells[3].Value.ToString());


                dgvPlaceOrder.Rows.Remove(selectedRow);

                total -= totalValue;
                lblTK.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            PrintPDF();
        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem.ToString();

            try
            {
                string connectionString = @"Data Source=(local);Initial Catalog=RestaurantManagement;User ID=sa;Password=123;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT FoodDetails.FoodName FROM FoodDetails " +
                                   "INNER JOIN FoodPrices ON FoodDetails.FoodId = FoodPrices.FoodId " +
                                   "WHERE FoodPrices.Category = @Category";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Category", selectedCategory);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        listBox1.Items.Clear();
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader["FoodName"].ToString());
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving food names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPlaceOrder_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dgvPlaceOrder.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }
        }

        private void nudQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItems.Count > 0)
                {
                    Int64 quantity = Int64.Parse(nudQuantity.Value.ToString());
                    Int64 price = Int64.Parse(txtPrice.Text);

                    txtTotal.Text = (quantity * price).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }
        }
    }
}

    

