using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular_10__SQl__Asp.net_Framework.Controllers
{
    public class DepartmentController : ApiController
    {

        public HttpResponseMessage Get()
        {
            string query = @"Select DeoartmentId, DepartmentName from dbo.Department";

            //Creates a DataTable variable to store Data comming from table
            DataTable table = new DataTable();

            //Using Sql Connection to connect our new connection string
            using (var Con = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString))

            using (var cmd = new SqlCommand(query, Con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }
    }
}
