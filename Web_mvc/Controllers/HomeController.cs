using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_mvc.DAO;
using Web_mvc.DB;

namespace Web_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id)
        {
            ViewBag.abc = id;
            Result_dbDM db = new Result_dbDM();
            List<LoaiDanhMuc> tb = db.Getall_data();
            return View(tb);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}