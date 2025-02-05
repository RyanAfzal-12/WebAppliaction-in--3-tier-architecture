using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Props;

namespace DAL
{
    public class EmpDAL
    {
        Dbcon dbcon = new Dbcon();
        public bool EmpInsertDAL(Employee Emp)
        {
            string queryInsert = "INSERT INTO Employee VALUES('" + Emp.Name + "','" + Emp.Cell_No + "','" + Emp.Address + "')";
            return dbcon.Udi(queryInsert);
        }

        public bool EmpDeleteDAL(string empId)
        {

            string querydelete = " DELETE FROM Employee WHERE Emp_Id = '" + empId + "'";
            return dbcon.Udi(querydelete);
        }
        public bool EmpUpdateDAL(string empId, string Name, string Cell_No, string Address)
        {

            string queryupdate = " UPDATE  Employee SET Name = '" + Name + "', Cell_No ='" + Cell_No + "',Address = '" + Address + "' WHERE Emp_Id = '" + empId + "'";
            return dbcon.Udi(queryupdate);
        }

        public DataTable EmpSearchDAL(string empId)
        {
            string queryselect = "SELECT * FROM Employee WHERE Emp_Id = '" + empId + "'";
            return dbcon.FetchData(queryselect);
        }
        public DataTable EmpViewAllDAL(string empId, string Name, string Cell_No, string Address)
        {
            string queryviewall = "SELECT * FROM Employee";
            return dbcon.FetchData(queryviewall);
        }
    }
}