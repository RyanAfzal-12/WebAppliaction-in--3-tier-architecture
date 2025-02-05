using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Dbcon
    {
        private readonly string connectionString;
        public Dbcon()
        {
            connectionString = @"Data Source=DESKTOP-ESORQ5C\SQLEXPRESS;Initial Catalog=NewDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        }
        public bool Udi(string query)
        {
            bool check;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    check = cmd.ExecuteNonQuery() > 0;
                }
            }
            return check;

        }
        public DataTable FetchData(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader); 
                        return dataTable;
                    }
                }
            }
        }

    }
}
