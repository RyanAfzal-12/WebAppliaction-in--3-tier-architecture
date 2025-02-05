using DAL;
using Props;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class LoginBLL
    {
        Dbcon dbcon = new Dbcon();
        public bool SelectBLL(string username, string password)
        {
            LoginDAL loginDAL = new LoginDAL();
            int accessLevel = loginDAL.getAccessLevel(username, password);
            return accessLevel > 0; 
        }
    }
}
