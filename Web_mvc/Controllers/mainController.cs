using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_mvc.DB;
using Web_mvc.DAO;

namespace Web_mvc.Controllers
{
    public class mainController : Controller
    {
        // GET: main
        public ActionResult Index()
        {          
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
      
    }
}