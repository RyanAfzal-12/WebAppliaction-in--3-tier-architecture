using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Props
{
    public class SignupProps
    {
        private string UserId;
        private string UserName;
        private string UserPassword;
        private int UserAccessLevel;
        private int UserStatus;

        public string UserId1 { get => UserId; set => UserId = value; }
        public string UserName1 { get => UserName; set => UserName = value; }
        public string UserPassword1 { get => UserPassword; set => UserPassword = value; }
        public int UserAccessLevel1 { get => UserAccessLevel; set => UserAccessLevel = value; }
        public int UserStatus1 { get => UserStatus; set => UserStatus = value; }
    }
}
