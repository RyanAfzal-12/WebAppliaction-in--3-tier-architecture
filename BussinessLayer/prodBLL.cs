
using System.Data;
using Props;
using DAL;
namespace BusinessLayer
{
    public class ProdBLL
    {
        prodDAL product = new prodDAL();

        public bool ProductInsertBLL(prod prod)
        {
            return product.ProductInsertDAL(prod);
        }

        public bool ProductDeleteBLL(string Product_Id)
        {
            return product.ProductDeleteDAL(Product_Id);
        }

        public bool ProductUpdateBLL(string Product_Id, string Name1, string Price1, string Stock1)
        {
            return product.ProductUpdateDAL(Product_Id, Name1, Price1, Stock1);
        }
        public DataTable ProductSearchBLL(string Product_Id)
        {
            return product.ProductsearchDAL(Product_Id);
        }
        public DataTable ProductViewAllBLL(string Product_Id, string Name1, string Price1, string Stock1)
        {
            return product.ProductViewAllDAL(Product_Id, Name1, Price1, Stock1);
        }
    }

}
