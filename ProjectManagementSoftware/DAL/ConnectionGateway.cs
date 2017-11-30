using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ProjectManagementSoftware.DAL
{
    public class ConnectionGateway
    {
        private string connectionString =
           WebConfigurationManager.ConnectionStrings["ProjectManagementDatabase"].ConnectionString;

        public SqlConnection Connection { set; get; }
        public SqlCommand Command { get; set; }
        public ConnectionGateway()
        {
            Connection = new SqlConnection(connectionString);
            Command = new SqlCommand();
            Command.Connection = Connection;
        }
    }
}