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
    public class MainController : Controller
    {
        // GET: Main
        private readonly int DV;
        public ActionResult Index()
        {
            Result_dbDM db = new Result_dbDM();
            Custom_index index = new Custom_index();
            index.Hinh_GT_MAIN = db.Getall_data_Hinhanh();
            index.Hinh_GT_extra = db.Getall_data_Hinhanh_ex();
            index.LoaiDanhMuc_index = db.Getall_loaidanhmuc_index();
            //ViewBag.danhmuc = index;

           
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
        public void master_layout()
        {
            Result_dbDM db = new Result_dbDM();
            string DomainName = ConfigurationManager.AppSettings["domain-or-ip"];
            var dv_tamp = db.GET_ds_dv(DomainName);
            Session.Add("test", dv_tamp[0]);
        }
         [ChildActionOnly]
        public ActionResult Menu()
        {
            Result_dbDM db = new Result_dbDM();
            Custom_index index = new Custom_index();
            index.Loaidanhmuc = db.Getall_data_loaidanhmuc();
            index.DanhMucHoTro = db.Getall_data_danhmuchotro();
            return PartialView(index);
        }
        public ActionResult Details(int id = 2)
        {
            GetData_Detail_Product product = new GetData_Detail_Product();
            dynamic expando = new ExpandoObject();

            expando.DanhMuc = product.GetData_OneProduct(id);

            int Ma = product.MaLoaiDanhMuc(id);

            expando.MaLoaiDanhMuc = product.List_DanhMuc(Ma);           
            return View(expando);
        }

       


        }
    }