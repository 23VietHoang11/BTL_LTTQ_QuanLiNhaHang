using System;
using System.Data;
using System.Data.SqlClient;

namespace BTL_QLNH.DAL
{
    public class FoodDAL
    {
        private DataAccess da;

        public FoodDAL()
        {
            da = new DataAccess();
        }

        public DataTable GetAll()
        {
            return da.ExecuteQuery("sp_Food_GetAll");
        }

        public DataTable Search(string keyword)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@Keyword", keyword);
            return da.ExecuteQuery("sp_Food_Search", p);
        }

        public string GetLastID()
        {
            DataTable dt = da.ExecuteQuery("sp_Food_GetLastID");
            if (dt.Rows.Count > 0) return dt.Rows[0][0].ToString();
            return null;
        }

        public bool Insert(string id, string name, string category, float price)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@FoodId", id),
                new SqlParameter("@FoodName", name),
                new SqlParameter("@Category", category),
                new SqlParameter("@Price", price)
            };
            return da.ExecuteNonQuery("sp_Food_Insert", p);
        }

        public bool Update(string id, string name, string category, float price)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@FoodId", id),
                new SqlParameter("@FoodName", name),
                new SqlParameter("@Category", category),
                new SqlParameter("@Price", price)
            };
            return da.ExecuteNonQuery("sp_Food_Update", p);
        }

        public bool Delete(string id)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@FoodId", id)
            };
            return da.ExecuteNonQuery("sp_Food_Delete", p);
        }
    }
}