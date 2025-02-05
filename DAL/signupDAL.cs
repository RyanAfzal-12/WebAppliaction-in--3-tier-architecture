using Props;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class signupDAL
    {
        Dbcon dbcon = new Dbcon();
        public bool InsertDAL(SignupProps props)
        {
            string queryInsert = "INSERT INTO userss VALUES('" + props.UserName1 + "','" + props.UserPassword1 + "' , '"+ props.UserAccessLevel1 + "', '" + props.UserStatus1 + "')";
            return dbcon.Udi(queryInsert);
        }
    }
}
 