using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Web_mvc.DAO
{
    public class Connect
    {
        public string strCon;
        public Connect()
        {
            this.strCon = ConfigurationManager.ConnectionStrings["QLBH"].ConnectionString;

        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(this.strCon);
        }
    }
}