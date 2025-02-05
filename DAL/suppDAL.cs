using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Props;

namespace DAL
{
    public class suppDAL
    {
        Dbcon dbcon = new Dbcon();

        public bool SuppInsertDAL(supp supplier)
        {
            string queryInsert = "INSERT INTO Supplier (Name, Cell_No, Address) VALUES('" + supplier.Name1 + "','" + supplier.Cell_No1 + "','" + supplier.Address1 + "')";
            return dbcon.Udi(queryInsert);
        }

        public bool SuppDeleteDAL(string Supplier_Id)
        {
            string queryDelete = "DELETE FROM Supplier WHERE Supplier_Id = '" + Supplier_Id + "'";
            return dbcon.Udi(queryDelete);
        }

        public bool SuppUpdateDAL(string Supplier_Id, string Name1, string Cell_No1, string Address1)
        {
            string queryUpdate = "UPDATE Supplier SET Name = '" + Name1 + "', Cell_No ='" + Cell_No1 + "', Address = '" + Address1 + "' WHERE Supplier_Id = '" + Supplier_Id + "'";
            return dbcon.Udi(queryUpdate);
        }

        public DataTable SuppSearchDAL(string Supplier_Id)
        {
            string querySearch = "SELECT * FROM Supplier WHERE Supplier_Id = '" + Supplier_Id + "'";
            return dbcon.FetchData(querySearch);
        }

        public DataTable SuppViewAllDAL(string supplierId, string name, string cellNo, string address)
        {
            string queryViewAll = "SELECT * FROM Supplier";
            return dbcon.FetchData(queryViewAll);
        }
    }
}
