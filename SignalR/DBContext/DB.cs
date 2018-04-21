using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using FluentData;

namespace SignalR.DBContext
{
    public class DB
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DBContext"].ConnectionString;
            }
        }

        public static IDbContext QueryDB()
        {
            return new DbContext().ConnectionStringName("DBContext", new SqlServerProvider());
        }

    }
}