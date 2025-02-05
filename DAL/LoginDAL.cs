using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        
            Dbcon dbcon = new Dbcon();

            public int getAccessLevel(string username, string password)
            {
                string query = $"SELECT usr_access_level FROM userss WHERE usr_name = '{username}' AND usr_password = '{password}'";

                DataTable dt = dbcon.FetchData(query);

                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0]["usr_access_level"]);
                }

                return -1; 
            }
        }

    }

