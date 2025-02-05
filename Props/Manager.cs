using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Props
{
    public class Manager
    {
        private string Manager_Id;
        private string Name;
        private string Cell_No;
        private string Address;
        public string managerId1 { get => Manager_Id; set => Manager_Id = value; }
        public string Customer_Name1 { get => Name; set => Name = value; }
        public string Cell_No1 { get => Cell_No; set => Cell_No = value; }
        public string Address1 { get => Address; set => Address = value; }
    }
}
