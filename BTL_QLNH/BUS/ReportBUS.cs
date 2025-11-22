using System;
using System.Data;
using BTL_QLNH.DAL;

namespace BTL_QLNH.BUS
{
    public class ReportBUS
    {
        private ReportDAL dal = new ReportDAL();

        public DataTable GetRevenueReport(DateTime start, DateTime end)
        {
            // Logic: Ngày bắt đầu không được lớn hơn ngày kết thúc
            if (start > end) return null;
            return dal.GetRevenue(start, end);
        }
    }
}