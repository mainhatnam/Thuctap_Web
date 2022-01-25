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
        public List<LoaiDanhMuc> Getall_data_loaidanhmuc()
        {
            List<LoaiDanhMuc> LoaiDanhMuc = this.mydb.LoaiDanhMuc.ToList(); ;
            return LoaiDanhMuc;
        }
        public List<DanhMucHoTro> Getall_data_danhmuchotro()
        {
            List<DanhMucHoTro> DanhMucHoTro = this.mydb.DanhMucHoTro.ToList();
            return DanhMucHoTro;
        }
        public List<Hinh_GT_MAIN> Getall_data_Hinhanh()
        {
            List<Hinh_GT_MAIN> Hinh_GT_MAIN = (from hinh in this.mydb.Hinh_GT_MAIN
                                               where hinh.trangthai == true select hinh).ToList();
            return Hinh_GT_MAIN;
        }
        public List<Hinh_GT_extra> Getall_data_Hinhanh_ex()
        {
            List<Hinh_GT_extra> Hinh_GT_extra = (from hinh in this.mydb.Hinh_GT_extra
                                                 where hinh.trangthai == true
                                                 select hinh).ToList();
            return Hinh_GT_extra;
        }

        public List<DanhMuc> Getall_data_danhmuc_theoloai(int id)
        {
            var DanhMuc = (from danhmuc in this.mydb.DanhMuc
                                               where danhmuc.MaLoaiDanhMuc == id                                     
                                               select danhmuc).OrderByDescending(p=>p.Id_DanhMuc).Take(4).ToList();
            return DanhMuc;
        }
        public List<GiamGia> Getall_dataGG()
        {
            string sql = "Select * from GiamGia";
            return this.mydb.Database.SqlQuery<GiamGia>(sql).ToList();
        }
        public List<DanhMuc> Getall_data_danhmuc()
        {
            
            List<DanhMuc> list2 = new List<DanhMuc>();
            list2 = (from g in this.mydb.DanhMuc
                     from u in this.mydb.LoaiDanhMuc
                     where g.MaLoaiDanhMuc == u.MaLoaiDanhMuc
                     select g).ToList();


            //custom table

            var a = (from dm in this.mydb.DanhMuc
                    from ldm in this.mydb.LoaiDanhMuc
                 .Where(c => c.MaLoaiDanhMuc == dm.MaLoaiDanhMuc)
                 select new {dm.MaLoaiDanhMuc,dm.TenDanhMuc,ldm.TenLoaiDanhMuc }).ToList();
            a.ToList();
            
            List<Custom> list3 = new List<Custom>();
            foreach (var item in a)
            {
                list3.Add(new Custom { MaLoaiDanhMuc = item.MaLoaiDanhMuc, TenDanhMuc = item.TenDanhMuc, TenLoaiDanhMuc = item.TenLoaiDanhMuc });
            }    
                
            //string sql = "Select * from DanhMuc as t,LoaiDanhMuc Where t.MaLoaiDanhMuc = LoaiDanhMuc.MaLoaiDanhMuc ";
            //var a = this.mydb.Database.SqlQuery<DanhMuc>(sql).ToList();

          
         //string sql = "Select * from DanhMuc as t,LoaiDanhMuc Where t.MaLoaiDanhMuc = LoaiDanhMuc.MaLoaiDanhMuc ";
            //var a = this.mydb.Database.SqlQuery<DanhMuc>(sql).ToList();

          
            //    var a = this.mydb.DanhMuc
            //                         .Where(s => s.TenDanhMuc == "Gói Thương Gia 2")
            //                         .FirstOrDefault<DanhMuc>();

            //// loads StudentAddress
            //List<DanhMuc> b =  this.mydb.Entry(a).Reference(s => s.TenDanhMuc).Load();

            //    // loads Courses collection 
            //   this.mydb.Entry(a).Reference(s => s.NoiDung).Load();

            return list2;
        
        }



    }
}