using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Model;
using SignalR.DBContext;
using System.Data.SqlClient;
using SignalR.SignalR;

namespace SignalR.DBContext
{
    public class Table
    {
        public IEnumerable<Major> GetData()
        {
            var list = DB.QueryDB().Sql("select * from Major").QueryMany<Major>();
            return list;
        }

        public int GetRows()
        {
            SqlDependency dependcy = new SqlDependency();
            dependcy.OnChange += new OnChangeEventHandler(dependency_OnChange);
            var count = DB.QueryDB().Sql("select count(1) from Users").QuerySingle<int>();
            return Convert.ToInt32(count);
            //using (var sqlConnection=new SqlConnection(DB.ConnectionString))
            //{
            //    sqlConnection.Open();
            //    using (SqlCommand sqlCommond=new SqlCommand("select count(1) from Major",sqlConnection))
            //    {
            //        sqlCommond.Notification = null;
            //        SqlDependency dependcy = new SqlDependency(sqlCommond);
            //        dependcy.OnChange += new OnChangeEventHandler(dependency_OnChange);

            //        if (sqlConnection.State == System.Data.ConnectionState.Closed)
            //            sqlConnection.Open();
            //        var count = sqlCommond.ExecuteScalar();
            //        return Convert.ToInt32(count);

            //    }
            //}
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            MajorHub.Show();
        }

    }
}