using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Props;

namespace BussinessLayer
{
    public class signupBLL
    {
        Dbcon dbcon = new Dbcon();
        public bool InsertBLL(SignupProps props)
        {
            signupDAL signupDAL = new signupDAL();
            return signupDAL.InsertDAL(props);
        }
    }
}
