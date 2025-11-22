using System.Data;
using System.Data.SqlClient;

namespace BTL_QLNH.DAL
{
    public class AccountDAL
    {
        private DataAccess da = new DataAccess();

        public bool Login(string user, string pass)
        {
            SqlParameter[] p = {
                new SqlParameter("@Username", user),
                new SqlParameter("@Password", pass)
            };
            DataTable dt = da.ExecuteQuery("sp_Account_Login", p);
            return dt.Rows.Count > 0;
        }

        public bool CheckUsername(string user)
        {
            SqlParameter[] p = { new SqlParameter("@Username", user) };
            DataTable dt = da.ExecuteQuery("sp_Account_CheckExist", p);
            return (int)dt.Rows[0][0] > 0;
        }

        public bool Register(string user, string pass, string name, string dob, string gender, string role, string email)
        {
            SqlParameter[] p = {
                new SqlParameter("@Username", user),
                new SqlParameter("@Password", pass),
                new SqlParameter("@FullName", name),
                new SqlParameter("@DOB", dob), // Truyền chuỗi yyyy-MM-dd hoặc DateTime
                new SqlParameter("@Gender", gender),
                new SqlParameter("@Role", role),
                new SqlParameter("@Email", email)
            };
            return da.ExecuteNonQuery("sp_Account_Register", p);
        }

        public string GetRole(string user)
        {
            SqlParameter[] p = new SqlParameter[] {
        new SqlParameter("@Username", user)
    };
            // Gọi Procedure lấy quyền
            DataTable dt = da.ExecuteQuery("sp_Account_GetRole", p);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            return "";
        }
    }
}