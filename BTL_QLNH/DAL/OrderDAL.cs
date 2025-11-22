using System.Data;
using System.Data.SqlClient;

namespace BTL_QLNH.DAL
{
    public class OrderDAL
    {
        private DataAccess da = new DataAccess();

        public string GetLastID()
        {
            DataTable dt = da.ExecuteQuery("sp_Order_GetLastID");
            if (dt.Rows.Count > 0) return dt.Rows[0][0].ToString();
            return null;
        }

        public bool InsertOrder(string id, string cusName, string date, string total)
        {
            SqlParameter[] p = {
                new SqlParameter("@OrderID", id),
                new SqlParameter("@CustomerName", cusName),
                new SqlParameter("@OrderDate", date),
                new SqlParameter("@Total", total)
            };
            return da.ExecuteNonQuery("sp_Order_InsertHeader", p);
        }

        public bool InsertOrderDetail(string id, string item, string qty)
        {
            SqlParameter[] p = {
                new SqlParameter("@OrderID", id),
                new SqlParameter("@ItemName", item),
                new SqlParameter("@Quantity", qty)
            };
            return da.ExecuteNonQuery("sp_Order_InsertItem", p);
        }
    }
}