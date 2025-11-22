using System;
using BTL_QLNH.DAL;

namespace BTL_QLNH.BUS
{
    public class AccountBUS
    {
        // Khởi tạo lớp DAL
        private AccountDAL dal = new AccountDAL();

        // 1. Kiểm tra đăng nhập
        public bool CheckLogin(string user, string pass)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass)) return false;
            return dal.Login(user, pass);
        }

        // 2. Lấy quyền người dùng (Hàm bạn đang thiếu)
        // Hàm này gọi sang AccountDAL để chạy thủ tục sp_Account_GetRole
        public string GetUserRole(string user)
        {
            return dal.GetRole(user);
        }

        // 3. Tạo tài khoản mới
        public string CreateAccount(string user, string pass, string confirmPass, string name, DateTime dob, string gender, string role, string email)
        {
            // Validate dữ liệu
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(name))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (pass != confirmPass) return "Mật khẩu xác nhận không khớp!";

            // Kiểm tra tồn tại
            if (dal.CheckUsername(user)) return "Tên đăng nhập đã tồn tại!";

            // Gọi DAL (Format ngày tháng chuẩn SQL)
            string dobStr = dob.ToString("yyyy-MM-dd");

            if (dal.Register(user, pass, name, dobStr, gender, role, email))
                return "Success";
            else
                return "Lỗi hệ thống khi tạo tài khoản!";
        }
    }
}