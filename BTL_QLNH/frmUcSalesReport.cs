using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using BTL_QLNH.BUS; // Gọi BUS
using Excel = Microsoft.Office.Interop.Excel; // Thư viện Excel

namespace BTL_QLNH
{
    public partial class frmUcSalesReport : UserControl
    {
        private ReportBUS bus;
        private DataTable dtReport; // Biến lưu dữ liệu để xuất Excel
        private SaveFileDialog saveFileDialog1;

        public frmUcSalesReport()
        {
            // Cài đặt tiếng Việt
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");

            InitializeComponent();

            bus = new ReportBUS();
            this.saveFileDialog1 = new SaveFileDialog();

            // Định dạng ngày tháng
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dddd, dd/MM/yyyy";

            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "dddd, dd/MM/yyyy";

            // Mặc định ngày hiện tại
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }

        // Nút TẠO BÁO CÁO
        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            // 1. Gọi BUS lấy dữ liệu
            this.dtReport = bus.GetRevenueReport(dtpStartDate.Value, dtpEndDate.Value);

            if (this.dtReport != null)
            {
                this.dgvSales.DataSource = this.dtReport;

                // 2. Tính tổng tiền hiển thị lên Label
                decimal totalSale = 0;
                if (this.dtReport.Rows.Count > 0 && this.dtReport.Columns.Contains("Tổng doanh thu"))
                {
                    foreach (DataRow row in this.dtReport.Rows)
                    {
                        // Kiểm tra null trước khi cộng
                        if (row["Tổng doanh thu"] != DBNull.Value)
                        {
                            totalSale += Convert.ToDecimal(row["Tổng doanh thu"]);
                        }
                    }
                }
                lblTK.Text = totalSale.ToString("N0");
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            lblTK.Text = "0.0";
            dgvSales.DataSource = null;
            this.dtReport = null;
        }

        // --- CODE XUẤT EXCEL (ĐÃ KHÔI PHỤC LẠI ĐẦY ĐỦ) ---
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (this.dtReport == null || this.dtReport.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất file (Vui lòng nhấn nút 'Tạo' trước)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Khởi tạo Excel
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

            try
            {
                // --- 1. TIÊU ĐỀ CHUNG ---
                Excel.Range header = (Excel.Range)exSheet.Cells[1, 1];
                exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[1, dtReport.Columns.Count + 1]].Merge(true);

                header.Font.Size = 16;
                header.Font.Bold = true;
                header.Font.Color = Color.Red;
                header.Value = "BÁO CÁO DOANH THU";
                header.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // --- 2. TIÊU ĐỀ CỘT (ĐỘNG) ---
                int headerRow = 3;

                // Cột STT
                exSheet.Cells[headerRow, 1] = "STT";
                exSheet.Range[exSheet.Cells[headerRow, 1], exSheet.Cells[headerRow, 1]].Font.Bold = true;
                exSheet.Range[exSheet.Cells[headerRow, 1], exSheet.Cells[headerRow, 1]].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                // Các cột dữ liệu
                for (int j = 0; j < dtReport.Columns.Count; j++)
                {
                    exSheet.Cells[headerRow, j + 2] = dtReport.Columns[j].ColumnName;
                    Excel.Range colHeader = exSheet.Range[exSheet.Cells[headerRow, j + 2], exSheet.Cells[headerRow, j + 2]];
                    colHeader.Font.Bold = true;
                    colHeader.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    colHeader.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                }

                // --- 3. DỮ LIỆU (ĐỘNG) ---
                int dataRowStart = 4;
                for (int i = 0; i < dtReport.Rows.Count; i++)
                {
                    int currentRow = dataRowStart + i;

                    // Điền STT
                    exSheet.Cells[currentRow, 1] = (i + 1).ToString();
                    exSheet.Range[exSheet.Cells[currentRow, 1], exSheet.Cells[currentRow, 1]].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                    // Điền dữ liệu từng cột
                    for (int j = 0; j < dtReport.Columns.Count; j++)
                    {
                        var value = dtReport.Rows[i][j];
                        string colName = dtReport.Columns[j].ColumnName;
                        Excel.Range cell = exSheet.Range[exSheet.Cells[currentRow, j + 2], exSheet.Cells[currentRow, j + 2]];

                        // Định dạng hiển thị
                        if (value is DateTime)
                        {
                            exSheet.Cells[currentRow, j + 2] = ((DateTime)value).ToString("dd/MM/yyyy");
                        }
                        else if (colName == "Total" || colName == "Tổng doanh thu")
                        {
                            exSheet.Cells[currentRow, j + 2] = value;
                            cell.NumberFormat = "#,##0"; // Định dạng số tiền
                        }
                        else
                        {
                            exSheet.Cells[currentRow, j + 2] = value.ToString();
                        }

                        // Kẻ khung
                        cell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    }
                }

                // Tự động giãn cột cho đẹp
                exSheet.Columns.AutoFit();

                // --- 4. THÊM TỔNG CỘNG ---
                int totalRow = dtReport.Rows.Count + dataRowStart + 1;
                Excel.Range tongCongLabel = (Excel.Range)exSheet.Cells[totalRow, 2];
                tongCongLabel.Value = "Tổng cộng:";
                tongCongLabel.Font.Bold = true;
                tongCongLabel.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                Excel.Range tongCongValue = (Excel.Range)exSheet.Cells[totalRow, 3]; // Giả sử cột tiền là cột 3 (Cột C)
                // Tốt nhất là tìm đúng cột tiền, nhưng thường báo cáo doanh thu chỉ có 2 cột: Ngày và Tiền
                // Nếu dtReport có nhiều cột, logic này cần chỉnh lại index cột.
                // Ở đây ta lấy giá trị từ Label đã tính sẵn cho chính xác:
                tongCongValue.Value = lblTK.Text;
                tongCongValue.Font.Bold = true;
                tongCongValue.NumberFormat = "#,##0";

                exSheet.Name = "BaoCaoDoanhThu";
                exBook.Activate();

                // --- 5. LƯU FILE ---
                saveFileDialog1.Filter = "Excel Document(*.xlsx)|*.xlsx|Excel 97-2003 Document(*.xls)|*.xls";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.DefaultExt = ".xlsx";
                saveFileDialog1.FileName = "BaoCao_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
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
                // Dọn dẹp tài nguyên COM để tránh treo Excel
                exApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exSheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
            }
        }
    }
}