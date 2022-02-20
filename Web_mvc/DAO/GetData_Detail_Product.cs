using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_mvc.DB;

namespace Web_mvc.DAO
{
    public class GetData_Detail_Product
    {
        public DataB mydb = new DataB();

        public DanhMuc GetData_OneProduct(string id)
        {
            string sql = "Select * from DanhMuc WHERE Id_DanhMuc = '" + id + "'";
            return this.mydb.Database.SqlQuery<DanhMuc>(sql).FirstOrDefault();
        }

        public List<DanhMuc> List_DanhMuc(int MaLoai)
        {
            string sql = "Select TOP 4 * from DanhMuc where MaLoaiDanhMuc = '" + MaLoai + "'";
            return this.mydb.Database.SqlQuery<DanhMuc>(sql).ToList();
        }

        public int MaLoaiDanhMuc(string id)
        {
            string sql = "Select * from DanhMuc WHERE Id_DanhMuc = '" + id + "'";
            try
            {
                DanhMuc a = this.mydb.Database.SqlQuery<DanhMuc>(sql).FirstOrDefault();
                int v = a.MaLoaiDanhMuc;
                return v;
            }
            catch(Exception e)
            {
                return 0;
            }
        }
        //public bool Check_id(string id)
        //{
        //    string sql = ""
        //    return false;
        //}
    }
}