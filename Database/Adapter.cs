using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Database
{
    public class Adapter
    {
        public SqlConnection SqlConn;

        public void OpenConnection()
        {
            string connectionString = @"Data source=localhost; Integrated Security=SSPI; Initial Catalog=Servigari;";
           
            SqlConn = new SqlConnection(connectionString);
            SqlConn.Open();            
        }

        public void CloseConnection()
        {
            SqlConn.Close();
            SqlConn = null;
        }
    }
}
