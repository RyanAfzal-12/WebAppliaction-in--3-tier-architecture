using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Props;

namespace DAL
{
    public class managerDAL
    {
        Dbcon dbcon = new Dbcon();
        public bool CustInsertDAL(Manager man)
        {
            string queryInsert = "INSERT INTO Customer VALUES('" + man.Customer_Name1 + "','" + man.Cell_No1 + "','" + man.Address1 + "')";
            return dbcon.Udi(queryInsert);
        }

        public bool CustDeleteDAL(string Customer_Id)
        {

            string querydelete = " DELETE FROM Customer WHERE Customer_Id = '" + Customer_Id + "'";
            return dbcon.Udi(querydelete);
        }
        public bool CustUpdateDAL(string Customer_Id, string Customer_Name1, string Cell_No1, string Address1)
        {

            string queryupdate = " UPDATE  Customer SET Name = '" + Customer_Name1 + "', Cell_No ='" + Cell_No1 + "',Address = '" + Address1 + "' WHERE Customer_Id = '" + Customer_Id + "'";
            return dbcon.Udi(queryupdate);
        }

        public DataTable CustSearchDAL(string Customer_Id)
        {
            string queryselect = "SELECT * FROM Customer WHERE Customer_Id = '" + Customer_Id + "'";
            return dbcon.FetchData(queryselect);
        }
        public DataTable CustViewAllDAL(string Customer_Id, string Customer_Name1, string Cell_No1, string Address1)
        {
            string queryviewall = "SELECT * FROM Customer";
            return dbcon.FetchData(queryviewall);
        }
    }
}