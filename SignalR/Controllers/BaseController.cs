using FluentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalR.Controllers
{
    public class BaseController : Controller
    {
        public static IDbContext QueryDB()
        {
            return new DbContext().ConnectionStringName("DBContext", new SqlServerProvider());
        }
        //public IDbContext Context()
        //{
        //    return new DbContext().ConnectionString(
        //    "Server=MyServerAddress;Database=MyDatabase;Trusted_Connection=True;", new SqlServerProvider());
        //}

	}
}