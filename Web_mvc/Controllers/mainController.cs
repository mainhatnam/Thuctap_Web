using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_mvc.DB;
using Web_mvc.DAO;
using System.Dynamic;
namespace Web_mvc.Controllers
{
    public class mainController : Controller
    {
        // GET: main
        public ActionResult Index()
        {          
            return View();
        }
        public ActionResult Details(int id)
        {            
            GetData_Detail_Product product = new GetData_Detail_Product();
            dynamic expando = new ExpandoObject();

            expando.TenDanhMuc = product.GetData_OneProduct(id);

            int Ma = product.MaLoaiDanhMuc(id);

            expando.MaLoaiDanhMuc = product.List_DanhMuc(Ma);
            
            return View(expando);
        }

        
      
    }
}