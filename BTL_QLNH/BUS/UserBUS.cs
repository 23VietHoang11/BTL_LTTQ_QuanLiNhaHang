using System;
using System.Data;
using BTL_QLNH.DAL;

namespace BTL_QLNH.BUS
{
    public class UserBUS
    {
        private UserDAL dal;

        public UserBUS()
        {
            dal = new UserDAL();
        }

        public DataTable GetList()
        {
            return dal.GetAllUsers();
        }

        // --- HÀM BẠN ĐANG THIẾU ĐÂY ---
        public DataTable Search(string keyword)
        {
            return dal.SearchUsers(keyword);
        }
        // -------------------------------

        public string UpdateInfo(string user, string name, DateTime dob, string gender, string role, string email)
        {
            if (string.IsNullOrEmpty(name)) return "Tên không được để trống";

            // Convert ngày tháng sang chuẩn yyyy-MM-dd
            if (dal.UpdateUser(user, name, dob.ToString("yyyy-MM-dd"), gender, role, email))
            {
                return "Success";
            }
            return "Lỗi cập nhật database";
        }

        public string DeleteUser(string user)
        {
            if (dal.DeleteUser(user))
            {
                return "Success";
            }
            return "Lỗi xóa người dùng";
        }
    }
}