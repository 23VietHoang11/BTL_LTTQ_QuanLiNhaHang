using System;
using System.Data;
using System.Data.SqlClient;

namespace BTL_QLNH.DAL
{
    public class UserDAL
    {
        private DataAccess da;

        public UserDAL()
        {
            da = new DataAccess();
        }

        public DataTable GetAllUsers()
        {
            // Lấy tất cả nhân viên
            return da.ExecuteQuery("sp_User_GetAll"); // Hoặc câu SQL: "SELECT * FROM UserInfo"
        }

        // --- HÀM TÌM KIẾM (BUS SẼ GỌI HÀM NÀY) ---
        public DataTable SearchUsers(string keyword)
        {
            // Tìm theo Tên, Username hoặc Role
            // Lưu ý: Dùng N'...' để tìm tiếng Việt có dấu
            string sql = "SELECT * FROM UserInfo WHERE FullName LIKE N'%" + keyword + "%' OR Username LIKE N'%" + keyword + "%' OR Role LIKE N'%" + keyword + "%'";

            // Vì DataAccess của bạn đã nâng cấp để chạy SP, 
            // nếu muốn chạy câu SQL thường thì phải dùng SqlDataAdapter thủ công hoặc viết thêm hàm ExecuteQueryTable cho SQL text.
            // Cách đơn giản nhất là dùng hàm ExecuteQuery (nếu bạn đã giữ lại overload hỗ trợ string SQL)
            // Nếu DataAccess của bạn chỉ hỗ trợ SP, bạn nên tạo SP sp_User_Search.

            // TUY NHIÊN, để nhanh nhất và không phải sửa DB, ta tạo đối tượng Command thủ công ở đây:
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=123;TrustServerCertificate=True"))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                sda.Fill(dt);
            }
            return dt;
        }
        // ----------------------------------------

        public bool UpdateUser(string user, string name, string dob, string gender, string role, string email)
        {
            SqlParameter[] p = new SqlParameter[] {
                new SqlParameter("@Username", user),
                new SqlParameter("@FullName", name),
                new SqlParameter("@DOB", dob),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@Role", role),
                new SqlParameter("@Email", email)
            };
            return da.ExecuteNonQuery("sp_User_Update", p);
        }

        public bool DeleteUser(string user)
        {
            SqlParameter[] p = new SqlParameter[] {
                new SqlParameter("@Username", user)
            };
            return da.ExecuteNonQuery("sp_User_Delete", p);
        }
    }
}