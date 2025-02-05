using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Props;
using DAL;

namespace BusinessLayer
{
    public class EmpBLL
    {
        EmpDAL empDAL = new EmpDAL();

        public bool EmpInsertBLL(Employee Emp)
        {
            return empDAL.EmpInsertDAL(Emp);
        }

        public bool EmpDeleteBLL(string empId)
        {
            return empDAL.EmpDeleteDAL(empId);
        }

        public bool EmpUpdateBLL(string empId, string Name, string Cell_No, string Address)
        {
            return empDAL.EmpUpdateDAL(empId, Name, Cell_No, Address);
        }
        public DataTable EmpSearchBLL(string empId)
        {
            return empDAL.EmpSearchDAL(empId);
        }
        public DataTable EmpViewAllBLL(string empId, string Name, string Cell_No, string Address)
        {
            return empDAL.EmpViewAllDAL(empId, Name, Cell_No, Address);
        }
    }
}
