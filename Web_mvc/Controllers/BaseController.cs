using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_mvc.DAO;

namespace Web_mvc.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (Session["test"] == null)
            {
                Result_dbDM db = new Result_dbDM();
                string DomainName = ConfigurationManager.AppSettings["domain-or-ip"];
                var dv_tamp = db.GET_ds_dv(DomainName);
                Session.Add("test", dv_tamp[0]);
            }
            base.OnActionExecuted(filterContext);
        }
    }
}