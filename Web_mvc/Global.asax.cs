using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Web_mvc.DAO;

namespace Web_mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //if (Session["test"] == null)
            //{
            //    Result_dbDM db = new Result_dbDM();
            //    string DomainName = ConfigurationManager.AppSettings["domain-or-ip"];
            //    var dv_tamp = db.GET_ds_dv(DomainName);
            //    Session.Add("test", dv_tamp[0]);
            //}
        }
    }
}
