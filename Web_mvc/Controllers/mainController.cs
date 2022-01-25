using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_mvc.DAO;
using Web_mvc.DB;
using Web_mvc.Models;

namespace Web_mvc.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            Result_dbDM db = new Result_dbDM();
            Custom_index index = new Custom_index();
            index.Loaidanhmuc = db.Getall_data_loaidanhmuc();
            index.DanhMucHoTro = db.Getall_data_danhmuchotro();
            index.Hinh_GT_MAIN = db.Getall_data_Hinhanh();
            index.Hinh_GT_extra = db.Getall_data_Hinhanh_ex();
            List<List<DanhMuc>> dm_pl = new List<List<DanhMuc>>();

            foreach (var item in index.Loaidanhmuc)
            {
                dm_pl.Add(db.Getall_data_danhmuc_theoloai(item.MaLoaiDanhMuc));

            }

            ViewBag.danhmuc = dm_pl;
            return View(index);
        }
        public ActionResult Details()
        {
            return View();
        }

        //[ChildActionOnly]
        //public ActionResult Menu_Danhmuc()
        //{
        //    Result_dbDM db = new Result_dbDM();
        //    List<GiamGia> tb1 = db.Getall_dataGG();
        //    return PartialView(tb1);
        //}


        }
    }