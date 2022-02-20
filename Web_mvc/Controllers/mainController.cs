using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_mvc.DAO;
using Web_mvc.DB;
using Web_mvc.Models;
using System.Globalization;
using System.Dynamic;
using System.Net;
using System.Configuration;

namespace Web_mvc.Controllers
{
    public class MainController : BaseController
    {
        //[HandleError]
        // GET: Main
        private readonly int DV;
        public ActionResult Index()
        {
            Result_dbDM db = new Result_dbDM();
            Custom_index index = new Custom_index();
            index.Hinh_GT_MAIN = db.Getall_data_Hinhanh();
            index.Hinh_GT_extra = db.Getall_data_Hinhanh_ex();
            index.LoaiDanhMuc_index = db.Getall_loaidanhmuc_index();
            List<LoaiDanhMuc> index_loaidm = db.Getall_data_loaidanhmuc();
            ViewBag.loaidanhmuc_index = index_loaidm;          
            return View(index);
        }
        [ChildActionOnly]
        public ActionResult Show_danhmuc(int id)
        {
            Result_dbDM db = new Result_dbDM();
            Custom_index index_dm = new Custom_index();
            var madv = (DonVi)Session["test"];
            index_dm.DanhMuc = db.Getall_data_danhmuc_dv(id, madv.ID);
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            ViewBag.CultureInfo = cul;
            return PartialView(index_dm);
        }

        [ChildActionOnly]
        public ActionResult Menu()
        {
            Result_dbDM db = new Result_dbDM();
            List<LoaiDanhMuc> index = db.Getall_data_loaidanhmuc();
            /* Test linq so sánh where 2 list 
            var lever1 = index.Where(x => x.id_cha == null).ToList();
            var lever2 = index.Where(x2 => lever1.Any(x1 => x1.MaLoaiDanhMuc == x2.id_cha)).ToList();
            var lever3 = index.Where(x2 => lever2.Any(x1 => x1.MaLoaiDanhMuc == x2.id_cha)).ToList();
             */
            ViewBag.Loaidanhmuc = index;
            return PartialView();
        }
        public ActionResult Category_sp()
        {
            return View();
        }

        //public ActionResult Details()
        //{
        //    return View();
        //}
        public ActionResult Details(string id)
        {
            //if (id == null)
            //    return new ContentResult { Content = "Không có tham số" };
            //else{
            try
            {
                int check = Convert.ToInt32(id); //Chuyển Id sang số
                GetData_Detail_Product product = new GetData_Detail_Product();
                dynamic expando = new ExpandoObject();
                expando.DanhMuc = product.GetData_OneProduct(id);
                int Ma = product.MaLoaiDanhMuc(id);
                if (Ma == 0) //id chưa có
                {
                    return HttpNotFound();
                }
                expando.MaLoaiDanhMuc = product.List_DanhMuc(Ma);
                return View(expando);
            }
            catch
            {
                return  HttpNotFound();
            }
                
            //}
        }
        public ActionResult PageNotFound()
        {
            return View();
        }





    }
}