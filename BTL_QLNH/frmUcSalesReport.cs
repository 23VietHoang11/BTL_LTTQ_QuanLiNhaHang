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
using System.Globalization;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel; // Dùng thư viện Interop (theo file Word)

namespace BTL_QLNH
{
    public partial class frmUcSalesReport : UserControl
    {
        private DataAccess Da { get; set; }
        private DataTable dtReport; // Biến lưu dữ liệu (chi tiết HOẶC tóm tắt)

        private SaveFileDialog saveFileDialog1; // Control để lưu file

        public frmUcSalesReport()
        {
            // Thêm 2 dòng này đểDateTimePicker hiển thị tiếng Việt
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");

            InitializeComponent();

            // Khởi tạo saveFileDialog (vì ta không kéo thả vào Designer)
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();

            this.Da = new DataAccess();
            this.PopulateGridView(); // Tải dữ liệu chi tiết ban đầu

            // Sửa định dạng cho ngày bắt đầu
            this.dtpStartDate.Value = DateTime.Now;
            this.dtpStartDate.Format = DateTimePickerFormat.Custom;
            this.dtpStartDate.CustomFormat = "dddd, dd/MM/yyyy";

            // Sửa định dạng cho ngày kết thúc
            this.dtpEndDate.Value = DateTime.Now;
            this.dtpEndDate.Format = DateTimePickerFormat.Custom;
            this.dtpEndDate.CustomFormat = "dddd, dd/MM/yyyy";
        }

        // Tải dữ liệu (mặc định là chi tiết)
        private void PopulateGridView(string sql = "select OrdersInfo.OrderID,OrdersInfo.CustomerName,OrdersInfo.OrderDate,OrdersInfo.Total from OrdersInfo;\r\n")
        {
            try
            {
                this.dtReport = this.Da.ExecuteQueryTable(sql);
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

            // Tải lại dữ liệu chi tiết gốc
            this.PopulateGridView();
        }

        // Nút "Tạo" (Tạo báo cáo tóm tắt)
        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            string dateStart = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string dateEnd = dtpEndDate.Value.ToString("yyyy-MM-dd");

            // Câu lệnh này tạo ra 2 cột: "Ngày" và "Tổng doanh thu"
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

            // Tải lại GridView với dữ liệu tóm tắt (dtReport bị thay thế)
            PopulateGridView(query);

            // Tính tổng (chỉ cho báo cáo tóm tắt)
            decimal totalSale = 0;
            if (this.dtReport != null && this.dtReport.Columns.Contains("Tổng doanh thu"))
            {
                foreach (DataRow row in this.dtReport.Rows)
                {
                    totalSale += Convert.ToDecimal(row["Tổng doanh thu"]);
                }
            }
            lblTK.Text = totalSale.ToString("N0");
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        // --- CODE XUẤT EXCEL ĐÃ SỬA (ĐỘNG) ---
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (this.dtReport == null || this.dtReport.Rows.Count == 0)
            {
                MessageBox.Show("Không có danh sách để in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

            try
            {
                // --- 1. TIÊU ĐỀ CHUNG ---
                Excel.Range header = (Excel.Range)exSheet.Cells[1, 1];
                // Sửa get_Range thành Range
                exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[1, dtReport.Columns.Count + 1]].Merge(true);
                header.Font.Size = 16;
                header.Font.Bold = true;
                header.Font.Color = Color.Red;
                header.Value = "BÁO CÁO DOANH THU";
                header.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // --- 2. TIÊU ĐỀ CỘT (ĐỘNG) ---
                int headerRow = 3; // Bắt đầu từ dòng 3

                // Thêm cột STT (Cột 1)
                exSheet.Cells[headerRow, 1] = "STT";
                // Sửa get_Range thành Range
                exSheet.Range[exSheet.Cells[headerRow, 1], exSheet.Cells[headerRow, 1]].Font.Bold = true;

                // Lặp qua tất cả các cột trong dtReport
                for (int j = 0; j < dtReport.Columns.Count; j++)
                {
                    // Dữ liệu bắt đầu từ Cột 2 (vì Cột 1 là STT)
                    exSheet.Cells[headerRow, j + 2] = dtReport.Columns[j].ColumnName;
                    // Sửa get_Range thành Range
                    exSheet.Range[exSheet.Cells[headerRow, j + 2], exSheet.Cells[headerRow, j + 2]].Font.Bold = true;
                    exSheet.Range[exSheet.Cells[headerRow, j + 2], exSheet.Cells[headerRow, j + 2]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }

                // --- 3. DỮ LIỆU (ĐỘNG) ---
                int dataRowStart = 4; // Dữ liệu bắt đầu từ dòng 4
                for (int i = 0; i < dtReport.Rows.Count; i++)
                {
                    int currentRow = dataRowStart + i;

                    // Cột 1 là STT
                    exSheet.Cells[currentRow, 1] = (i + 1).ToString();

                    // Lặp qua tất cả cột
                    for (int j = 0; j < dtReport.Columns.Count; j++)
                    {
                        var value = dtReport.Rows[i][j];
                        string colName = dtReport.Columns[j].ColumnName;

                        // Xử lý định dạng (nếu là ngày hoặc số)
                        if (value is DateTime)
                        {
                            exSheet.Cells[currentRow, j + 2] = ((DateTime)value).ToString("dd/MM/yyyy");
                        }
                        else if (colName == "Total" || colName == "Tổng doanh thu")
                        {
                            exSheet.Cells[currentRow, j + 2] = value;
                            // Sửa get_Range thành Range
                            exSheet.Range[exSheet.Cells[currentRow, j + 2], exSheet.Cells[currentRow, j + 2]].NumberFormat = "#,##0";
                        }
                        else
                        {
                            exSheet.Cells[currentRow, j + 2] = value.ToString();
                        }
                    }
                }

                // Tự động giãn cột
                exSheet.Columns.AutoFit();

                // --- 4. THÊM TỔNG CỘNG (NẾU LÀ BÁO CÁO TÓM TẮT) ---
                if (dtReport.Columns.Contains("Tổng doanh thu"))
                {
                    int totalRow = dtReport.Rows.Count + (dataRowStart + 1); // Cách ra 1 dòng

                    Excel.Range tongCongLabel = (Excel.Range)exSheet.Cells[totalRow, 2];
                    tongCongLabel.Value = "Tổng cộng:";
                    tongCongLabel.Font.Bold = true;
                    tongCongLabel.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                    Excel.Range tongCongValue = (Excel.Range)exSheet.Cells[totalRow, 3]; // Cột C
                    tongCongValue.Value = lblTK.Text;
                    tongCongValue.Font.Bold = true;
                    tongCongValue.NumberFormat = "#,##0";
                }

                // Đặt tên sheet
                exSheet.Name = "BaoCao";
                exBook.Activate();

                // --- 5. LƯU FILE ---
                saveFileDialog1.Filter = "Excel Document(*.xlsx)|*.xlsx|Excel 97-2003 Document(*.xls)|*.xls";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.DefaultExt = ".xlsx";
                saveFileDialog1.FileName = "BaoCao_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    exBook.SaveAs(saveFileDialog1.FileName.ToString());
                    MessageBox.Show("Xuất file Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Thoát khỏi ứng dụng
                exApp.Quit();

                // Giải phóng tài nguyên COM
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exSheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
                exSheet = null;
                exBook = null;
                exApp = null;
            }
        }
    }
}