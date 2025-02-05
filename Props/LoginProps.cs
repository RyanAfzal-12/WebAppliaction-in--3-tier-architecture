using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Props
{
    public class LoginProps
    {
        private string userName;
        private string userPassword;

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
    }
}
