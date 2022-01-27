using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_mvc.DAO;
using Web_mvc.DB;
using System.Dynamic;
using Web_mvc.Models;
using System.Globalization;

namespace Web_mvc.Controllers
{
    public class HomeController : Controller
    {      
        public ActionResult Index()
        {
            Result_dbDM db = new Result_dbDM();
            Custom_index index =  new Custom_index();
            //test.danhmuc = db.Getall_data_danhmuc();
            //test.loaidanhmuc = db.Getall_data_loaidanhmuc();
            index.Loaidanhmuc = db.Getall_data_loaidanhmuc();
            index.DanhMucHoTro = db.Getall_data_danhmuchotro();
            return View(index);
        }
        [ChildActionOnly]
        public ActionResult test(int id)
        {           
                Result_dbDM db = new Result_dbDM();
                Custom_index index = new Custom_index();
                index.DanhMuc = db.Getall_data_danhmuc_theoloai(id);
             
                return PartialView(index);
                 
        }
        public ActionResult About()
        {
            Result_dbDM db = new Result_dbDM();
          //  List<DanhMuc> tb1 = db.Getall_data_danhmuc();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}