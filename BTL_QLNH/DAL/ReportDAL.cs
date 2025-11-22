using System;
using System.Data;
using System.Data.SqlClient;

namespace BTL_QLNH.DAL
{
    public class ReportDAL
    {
        private DataAccess da = new DataAccess();

        public DataTable GetRevenue(DateTime start, DateTime end)
        {
            SqlParameter[] p = {
                new SqlParameter("@StartDate", start.ToString("yyyy-MM-dd")),
                new SqlParameter("@EndDate", end.ToString("yyyy-MM-dd"))
            };
            return da.ExecuteQuery("sp_Report_GetRevenue", p);
        }
    }
}