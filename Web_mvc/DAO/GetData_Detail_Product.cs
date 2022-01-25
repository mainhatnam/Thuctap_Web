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

        public TenDanhMuc GetData_OneProduct(int id)
        {
            string sql = "Select * from TenDanhMuc WHERE Id_DanhMuc = '"+id+"'";
            return this.mydb.Database.SqlQuery<TenDanhMuc>(sql).FirstOrDefault();
        }

        public List<TenDanhMuc> List_DanhMuc(int MaLoai)
        {
            string sql = "Select TOP 4 * from TenDanhMuc where MaLoaiDanhMuc = '"+MaLoai+"'";
            return this.mydb.Database.SqlQuery<TenDanhMuc>(sql).ToList();
        }

        public int MaLoaiDanhMuc(int id)
        {
            string sql = "Select * from TenDanhMuc WHERE Id_DanhMuc = '" + id + "'";
            TenDanhMuc a = this.mydb.Database.SqlQuery<TenDanhMuc>(sql).FirstOrDefault();
            int v = a.MaLoaiDanhMuc;
            return v;
        }
    }
}