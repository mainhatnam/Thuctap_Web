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
        public List<LoaiDanhMuc> Getall_data_loaidanhmuc()
        {
            List<LoaiDanhMuc> LoaiDanhMuc = this.mydb.LoaiDanhMuc.ToList(); ;
            return LoaiDanhMuc;
        }
        public List<LoaiDanhMuc> Getall_loaidanhmuc_index()
        {
            List<LoaiDanhMuc> LoaiDanhMuc = this.mydb.LoaiDanhMuc
                .Include("DanhMucHoTro")
                .Include("DanhMuc")
                .Include("DanhMuc.GiamGia")
                .Where(b => b.Trangthai_ldm == true)
                .ToList(); 
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
            List<DanhMuc> DanhMuc = this.mydb.DanhMuc
                           .Include("GiamGia")
                           .Where(p => p.MaLoaiDanhMuc == id)
                          .OrderByDescending(p=>p.Id_DanhMuc).Take(4).ToList();
            return DanhMuc;
        }
        public List<GiamGia> Getall_dataGG()
        {
            string sql = "Select * from GiamGia";
            return this.mydb.Database.SqlQuery<GiamGia>(sql).ToList();
        }
        public List<DanhMuc> Getall_data_danhmuc()
        {
            var list2 = this.mydb.DanhMuc
                .Include("loaiDanhMuc")
                .Include("loaiDanhMuc.DanhMucHoTro")
                .ToList();
            //// loads StudentAddress
            //List<DanhMuc> b =  this.mydb.Entry(a).Reference(s => s.TenDanhMuc).Load();

            //    // loads Courses collection 
            //   this.mydb.Entry(a).Reference(s => s.NoiDung).Load();

            return list2;
        
        }

        public int GET_id_dv(string name)
        { 
            var sql = this.mydb.DonVi
                         .Where(q=>q.IP.Equals(name)).FirstOrDefault();
          

            return sql.ID;
        }
        public List<DonVi> GET_ds_dv(string name)
        {
            var sql2 = this.mydb.DonVi
                       .Where(q => q.IP.Equals(name))
                       .Take(1).ToList();
            return sql2;
        }
        public List<DanhMuc> Getall_data_danhmuc_dv(int id,int id_dv)
        {
            List<DanhMuc> DanhMuc = this.mydb.DanhMuc
                           .Include("GiamGia")
                           .Where(p =>p.MaLoaiDanhMuc == id)
                           .Where(p=>p.ID_DonVi == id_dv)
                          .OrderByDescending(p => p.Id_DanhMuc).Take(4).ToList();
            return DanhMuc;
        }


    }
}