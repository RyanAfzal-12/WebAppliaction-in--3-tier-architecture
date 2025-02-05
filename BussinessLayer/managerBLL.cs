using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Props;
using DAL;

namespace Business_Layer
{
    public class managerBLL
    {
        managerDAL manDAL = new managerDAL();

        public bool CustInsertBLL(Manager man)
        {
            return manDAL.CustInsertDAL(man);
        }

        public bool CustDeleteBLL(string Customer_Id)
        {
            return manDAL.CustDeleteDAL(Customer_Id);
        }

        public bool CustUpdateBLL(string Customer_Id, string Customer_Name1, string Cell_No1, string Address1)
        {
            return manDAL.CustUpdateDAL(Customer_Id, Customer_Name1, Cell_No1, Address1);
        }
        public DataTable CustSearchBLL(string Customer_Id)
        {
            return manDAL.CustSearchDAL(Customer_Id);
        }
        public DataTable CustViewAllBLL(string Customer_Id, string Customer_Name1, string Cell_No1, string Address1)
        {
            return manDAL.CustViewAllDAL(Customer_Id, Customer_Name1, Cell_No1, Address1);
        }
    }
}
