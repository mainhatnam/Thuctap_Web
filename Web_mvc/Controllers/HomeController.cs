using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_mvc.DAO;
using Web_mvc.DB;
using System.Dynamic;
using Web_mvc.Models;

namespace Web_mvc.Controllers
{
    public class HomeController : Controller
    {      
        public ActionResult Index()
        {
            Result_dbDM db = new Result_dbDM();
            dynamic test =  new ExpandoObject();
            test.danhmuc = db.Getall_data_danhmuc();
            test.loaidanhmuc = db.Getall_data_loaidanhmuc();

            //index.Loaidanhmuc = db.Getall_data_loaidanhmuc();
            //index.DanhMucHoTro= db.Getall_data_danhmuchotro();
            return View(test);
        }
        [ChildActionOnly]
        public ActionResult test()
        {           
                Result_dbDM db = new Result_dbDM();
                List<GiamGia> tb1 = db.Getall_dataGG();
                return PartialView(tb1);
                 
        }
        public ActionResult About()
        {
            Result_dbDM db = new Result_dbDM();
            List<DanhMuc> tb1 = db.Getall_data_danhmuc();
            return View(tb1);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}