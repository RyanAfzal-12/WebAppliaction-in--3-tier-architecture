using Props;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class prodDAL
    {
        Dbcon dbcon = new Dbcon();
        public bool ProductInsertDAL(prod prod)
        {
            string queryInsert = "INSERT INTO Product VALUES('" + prod.Name1 + "','" + prod.Price1 + "','" + prod.Stock1 + "')";
            return dbcon.Udi(queryInsert);
        }

        public bool ProductDeleteDAL(string Product_Id)
        {

            string querydelete = " DELETE FROM Product WHERE Product_Id = '" + Product_Id + "'";
            return dbcon.Udi(querydelete);
        }
        public bool ProductUpdateDAL(string Product_Id, string Name1, string Price1, string Stock1)
        {

            string queryupdate = " UPDATE  Product SET Name = '" + Name1 + "', Price ='" + Price1 + "',Stock = '" + Stock1 + "' WHERE Product_Id = '" + Product_Id + "'";
            return dbcon.Udi(queryupdate);
        }

        public DataTable ProductsearchDAL(string Product_Id)
        {
            string queryselect = "SELECT * FROM Product WHERE Product_Id = '" + Product_Id + "'";
            return dbcon.FetchData(queryselect);
        }
        public DataTable ProductViewAllDAL(string Product_Id, string Name1, string Price1, string Stock1)
        {
            string queryviewall = "SELECT * FROM Product";
            return dbcon.FetchData(queryviewall);
        }
    }
}
