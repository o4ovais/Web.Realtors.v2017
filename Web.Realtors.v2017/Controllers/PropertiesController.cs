using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace Web.Realtors.Controllers
{
    public class PropertiesController : Controller
    {
        //Default
        public ActionResult Index()
        {
            
            return View();
            
        }

		public ActionResult Update()
		{
            TestCreate();
			return View();

		}

		public ActionResult Search()
		{

			return View();

		}

        private void TestCreate()
        {
            string strCS = System.Configuration.ConfigurationManager.ConnectionStrings["CS_Web"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCS);
            SqlCommand sqlCom = new SqlCommand("INSERT INTO [Table_Test] ([Id],[Name])   VALUES (1,'Ovais')", sqlCon);

            sqlCom.CommandType = System.Data.CommandType.Text;

            sqlCon.Open();

            int iRowsAffeted = sqlCom.ExecuteNonQuery();

            sqlCon.Close();

        }
	}
}