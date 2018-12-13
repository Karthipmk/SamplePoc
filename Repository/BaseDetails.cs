//using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Repository
{
    public class BaseDetails
    {





     //   private readonly IConfiguration _config;
        protected IDbConnection con;
        public BaseDetails()
        {
            //string connectionString = new SqlConnection
            string connectionString = "Data Source=SSG-INDIA-WS2;User ID=sa;Password=ssg@123;Persist Security Info=True;Initial Catalog=EmployeeInfo;";
            //_config.GetConnectionString("MyConnectionString");
            con = new SqlConnection(connectionString);
        }
        public void Dispose()
        {
            //throw new NotImplementedException();  
        }

    }
}
