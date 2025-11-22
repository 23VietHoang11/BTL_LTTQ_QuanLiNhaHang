using System;
using System.Data;
using BTL_QLNH.DAL;

namespace BTL_QLNH.BUS
{
    public class FoodBUS
    {
        private FoodDAL dal;

        public FoodBUS()
        {
            dal = new FoodDAL();
        }

        // --- SỬA TÊN HÀM TẠI ĐÂY (GetList -> GetListFood) ---
        public DataTable GetListFood()
        {
            return dal.GetAll();
        }

        // --- SỬA TÊN HÀM TẠI ĐÂY (Search -> SearchFood) ---
        public DataTable SearchFood(string keyword)
        {
            return dal.Search(keyword);
        }

        // Logic sinh mã tự động: f-xx
        public string GenerateNewID()
        {
            string lastId = dal.GetLastID();
            if (string.IsNullOrEmpty(lastId)) return "f-01";

            try
            {
                string[] parts = lastId.Split('-');
                int num = int.Parse(parts[1]);
                return "f-" + (++num).ToString("d2");
            }
            catch
            {
                return "f-01"; // Fallback nếu ID cũ sai định dạng
            }
        }

        public string AddFood(string id, string name, string category, string priceStr)
        {
            // 1. Validate
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(priceStr))
                return "Vui lòng nhập đủ thông tin!";

            if (!float.TryParse(priceStr, out float price) || price < 0)
                return "Giá tiền phải là số dương!";

            // 2. Gọi DAL
            if (dal.Insert(id, name, category, price))
                return "Success";
            else
                return "Thêm thất bại (Lỗi Database)!";
        }

        public string UpdateFood(string id, string name, string category, string priceStr)
        {
            if (!float.TryParse(priceStr, out float price) || price < 0)
                return "Giá tiền không hợp lệ!";

            if (dal.Update(id, name, category, price))
                return "Success";
            else
                return "Cập nhật thất bại!";
        }

        public string DeleteFood(string id)
        {
            if (dal.Delete(id))
                return "Success";
            else
                return "Xóa thất bại!";
        }
    }
}