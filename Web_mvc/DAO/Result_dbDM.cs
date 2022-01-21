using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_mvc.Models;
using Web_mvc.DB;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace Web_mvc.DAO
{
    public class Result_dbDM
    {
        public DataB mydb = new DataB();
        public void setobj<T>(T obj)
        {
            this.mydb.Set(obj.GetType()).Add(obj);
        }
        public List<LoaiDanhMuc> Getall_data()
        {
            string sql = "Select * from LoaiDanhMuc";
            return this.mydb.Database.SqlQuery<LoaiDanhMuc>(sql).ToList();
        }
        public void save()
        {
           this.mydb.SaveChanges();
        }
    }
}