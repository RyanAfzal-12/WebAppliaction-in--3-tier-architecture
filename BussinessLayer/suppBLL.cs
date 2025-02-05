using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Props;
using DAL;

namespace BusinessLayer
{
    public class supBLL
    {
        suppDAL suppDAL = new suppDAL();


        public bool SuppInsertBLL(supp supplier)
        {
            return suppDAL.SuppInsertDAL(supplier);
        }

        public bool SuppDeleteBLL(string Supplier_Id)
        {
            return suppDAL.SuppDeleteDAL(Supplier_Id);
        }


        public bool SuppUpdateBLL(string Supplier_Id, string Name, string Cell_No, string Address)
        {
            return suppDAL.SuppUpdateDAL(Supplier_Id, Name, Cell_No, Address);
        }

        public DataTable SuppSearchBLL(string Supplier_Id)
        {
            return suppDAL.SuppSearchDAL(Supplier_Id);
        }

        public DataTable SuppViewAllBLL(string supplierId, string name, string cellNo, string address)
        {
            return suppDAL.SuppViewAllDAL(supplierId, name, cellNo, address);
        }
    }
}
