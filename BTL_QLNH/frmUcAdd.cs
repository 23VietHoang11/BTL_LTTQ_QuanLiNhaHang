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

    public partial class frmUcAdd : UserControl
    {
    private DataAccess Da { get; set; }
        public frmUcAdd()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();

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

        private void PopulateGridView(string sql = "select FoodDetails.FoodId,FoodDetails.FoodName,FoodPrices.Category,FoodPrices.Price from FoodDetails,FoodPrices where FoodDetails.FoodId = FoodPrices.FoodId;")
        {
            this.Da.ExecuteQueryTable(sql);
            this.dgvAdd.DataSource = Da.Ds.Tables[0];
        }

        private void ClearContent()
        {
            this.txtFoodId.Clear();
            this.txtFoodName.Clear();
            this.txtPrice.Clear();
            this.cmbCategory.Text = null;


            this.txtSearch.Clear();


            this.dgvAdd.ClearSelection();
            this.AutoIdGenerate();
        }


        private void AutoIdGenerate()
        {
            var q = "select FoodId from FoodDetails order by FoodId desc;";
            var dt = this.Da.ExecuteQueryTable(q);

            if (dt.Rows.Count > 0)
            {
                var lastId = dt.Rows[0][0].ToString();
                string[] s = lastId.Split('-');
                int temp = Convert.ToInt32(s[1]);
                string newId = "f-" + (++temp).ToString("d2");
                this.txtFoodId.Text = newId;
            }
            else
            {
                this.txtFoodId.Text = "f-01";
            }
        }

        private void frmUcAdd_Load(object sender, EventArgs e)
        {
            dgvAdd.ClearSelection();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.ClearContent();

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtFoodId.Text) || String.IsNullOrEmpty(this.txtFoodName.Text) ||
    String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.cmbCategory.Text))
            {
                MessageBox.Show("Fields are blank!");
            }

            else
            {
                try
                {
                    string sqlSelect = "SELECT * FROM FoodDetails WHERE FoodId = '" + txtFoodId.Text + "'or FoodName='" + txtFoodName.Text + "';";

                    Da.ExecuteQueryTable(sqlSelect);


                    if (Da.Ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Item already exists");
                    }


                    else
                    {
                        string sql1 = "INSERT INTO FoodDetails (FoodId, FoodName) VALUES ('" + txtFoodId.Text + "', '" + txtFoodName.Text + "');";
                        string sql2 = "INSERT INTO FoodPrices (FoodId, Category, Price) VALUES ('" + txtFoodId.Text + "', '" + cmbCategory.Text + "', '" + txtPrice.Text + "');";

                        DialogResult d = MessageBox.Show("Are you sure want to add food?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (d == DialogResult.No)
                            return;


                        int a = Da.ExecuteDMLQuery(sql1);
                        int b = Da.ExecuteDMLQuery(sql2);



                        if (a > 0 && b > 0)
                        {
                            MessageBox.Show(txtFoodName.Text + " has been added successfully!");
                            this.PopulateGridView();
                            this.ClearContent();

                        }
                        else
                        {
                            MessageBox.Show("Failed to add");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured!", ex.Message);
                }
            }
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                // 1. Nếu ô tìm kiếm trống -> Load lại toàn bộ danh sách gốc
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    this.PopulateGridView();
                    return;
                }

                // 2. Tạo câu lệnh tìm kiếm thông minh hơn:
                // - Dùng '%...%' để tìm kiếm "có chứa" (Contains) thay vì chỉ "bắt đầu bằng"
                // - Tìm kiếm song song cả Tên món (FoodName) HOẶC Loại món (Category)

                string keyword = txtSearch.Text.Trim();

                string sql = @"SELECT FoodDetails.FoodId, FoodDetails.FoodName, FoodPrices.Category, FoodPrices.Price 
                       FROM FoodDetails, FoodPrices 
                       WHERE FoodDetails.FoodId = FoodPrices.FoodId 
                       AND (FoodDetails.FoodName LIKE N'%" + keyword + "%' OR FoodPrices.Category LIKE N'%" + keyword + "%');";

                this.PopulateGridView(sql);
            }
            catch (Exception ex)
            {
                // Tránh crash phần mềm nếu gõ ký tự đặc biệt gây lỗi SQL
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
