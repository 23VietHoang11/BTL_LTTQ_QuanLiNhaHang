using BTL_QLNH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace BTL_QLNH
{
    public partial class frmUcSalesReport : UserControl
    {

        private DataAccess Da { get; set; }
        private DataTable dtReport;
        public frmUcSalesReport()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            this.PopulateGridView();

            this.dtpStartDate.Value = DateTime.Now;
            this.dtpEndDate.Value = DateTime.Now;
        }

        private void PopulateGridView(string sql = "select OrdersInfo.OrderID,OrdersInfo.CustomerName,OrdersInfo.OrderDate,OrdersInfo.Total,OrdersItems.Item,OrdersItems.Quantity from OrdersInfo,OrdersItems where OrdersInfo.OrderID=OrdersItems.OrderID;\r\n")
        {
        try
    {
        // 1. Lấy dữ liệu và LƯU VÀO dtReport
        this.dtReport = this.Da.ExecuteQueryTable(sql); 
        
        // 2. Gán dữ liệu cho DataGridView
        this.dgvSales.DataSource = this.dtReport;
    }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       }


        private void ClearContent()
        {
            dtpEndDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
            lblTK.Text = "0.0";

            dgvSales.DataSource = null;
            dgvSales.Rows.Clear();
            this.dtReport = null;
        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            string dateStart = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string dateEnd = dtpEndDate.Value.ToString("yyyy-MM-dd");

            string query = @"
                SELECT 
                    OrderDate AS [Ngày], 
                    SUM(CAST(Total AS float)) AS [Tổng doanh thu]
                FROM 
                    OrdersInfo
                WHERE 
                    OrderDate BETWEEN '" + dateStart + "' AND '" + dateEnd + @"'
                GROUP BY 
                    OrderDate
                ORDER BY
                    OrderDate ASC;";

            // Hàm này bây giờ sẽ tự động lưu kết quả vào dtReport
            PopulateGridView(query);

            decimal totalSale = 0;
            // Tính tổng tiền từ DataTable (chính xác hơn là từ DataGridView)
            if (this.dtReport != null)
            {
                foreach (DataRow row in this.dtReport.Rows)
                {
                    // Lấy từ cột "Tổng doanh thu"
                    totalSale += Convert.ToDecimal(row[1]);
                }
            }

            lblTK.Text = totalSale.ToString("N0");
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
                   
                
            
        }
    }
 }

