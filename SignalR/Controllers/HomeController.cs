using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignalR.DBContext;
using System.Data.SqlClient;
using SignalR.SignalR;
using System.Dynamic;
using SignalR.Lib;
using System.Reflection;
using SignalR.Model;
namespace SignalR.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Get()
        {
            Table tab = new Table();
            var count = tab.GetRows();
            MajorHub.Show();
            return Json(count,JsonRequestBehavior.AllowGet);
        }

        public ActionResult List()
        {
            List<Major> list = new List<Major>();
            var maj = QueryDB().Sql("select * from Major").QueryMany<dynamic>();
            foreach (var item in maj)
            {
                var model = new Major();
                model.MajorID = item.MajorID;
                model.Name = item.Name;
                list.Add(model);
            }

            return View();
        }

        public static void DispProperty(Type t)
        {
            Console.WriteLine("ClassName '{0}'", t.Name);
            foreach (PropertyInfo pInfo in t.GetProperties())
            {
                Console.WriteLine("{0}", pInfo.ToString());
            }
        }

    }

}