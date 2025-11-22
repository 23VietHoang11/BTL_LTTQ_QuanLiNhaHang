using System;
using System.Data;
using System.Data.SqlClient;

namespace BTL_QLNH
{
    public class DataAccess
    {
        private SqlConnection sqlcon;

        public DataAccess()
        {
            // Chuỗi kết nối giữ nguyên theo máy của bạn
            string connectionString = @"Data Source=(local);Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=123;TrustServerCertificate=True";
            sqlcon = new SqlConnection(connectionString);
        }

        // Hàm chạy SP trả về bảng dữ liệu (cho SELECT)
        public DataTable ExecuteQuery(string spName, SqlParameter[] p = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(spName, sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (p != null) cmd.Parameters.AddRange(p);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                // Ghi log hoặc ném lỗi tùy ý
                throw new Exception("Lỗi Database: " + ex.Message);
            }
            return dt;
        }

        // Hàm chạy SP thực thi lệnh (cho INSERT, UPDATE, DELETE)
        public bool ExecuteNonQuery(string spName, SqlParameter[] p)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
                using (SqlCommand cmd = new SqlCommand(spName, sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (p != null) cmd.Parameters.AddRange(p);

                    int rows = cmd.ExecuteNonQuery();
                    return true; // Nếu không văng lỗi nghĩa là Transaction trong SP đã COMMIT
                }
            }
            catch
            {
                return false; // Có lỗi xảy ra
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }
    }
}