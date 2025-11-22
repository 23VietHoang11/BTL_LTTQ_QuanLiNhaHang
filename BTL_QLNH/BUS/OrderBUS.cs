using System;
using System.Collections.Generic;
using System.Windows.Forms; // Để dùng DataGridViewRow
using BTL_QLNH.DAL;

namespace BTL_QLNH.BUS
{
    public class OrderBUS
    {
        private OrderDAL dal = new OrderDAL();

        // Sinh mã hóa đơn tự động
        public string GenerateOrderID()
        {
            string lastId = dal.GetLastID();
            if (string.IsNullOrEmpty(lastId)) return "001";

            try
            {
                int temp = Convert.ToInt32(lastId);
                return (++temp).ToString("d3");
            }
            catch { return "001"; }
        }

        // Hàm lưu toàn bộ đơn hàng
        public string SaveOrder(string orderId, string cusName, DateTime date, string total, DataGridViewRowCollection rows)
        {
            if (string.IsNullOrEmpty(cusName)) return "Vui lòng nhập tên khách hàng";
            if (rows.Count <= 1) return "Giỏ hàng trống"; // rows luôn có 1 dòng trống cuối cùng

            try
            {
                // 1. Lưu Header
                bool headerOk = dal.InsertOrder(orderId, cusName, date.ToString("yyyy-MM-dd"), total);

                if (!headerOk) return "Lỗi khi tạo hóa đơn!";

                // 2. Lưu từng món (Loop)
                foreach (DataGridViewRow row in rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng trống

                    string itemName = row.Cells[0].Value?.ToString();
                    string qty = row.Cells[2].Value?.ToString();

                    if (!string.IsNullOrEmpty(itemName))
                    {
                        dal.InsertOrderDetail(orderId, itemName, qty);
                    }
                }
                return "Success";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
    }
}