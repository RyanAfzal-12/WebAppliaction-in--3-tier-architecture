using BusinessLayer;
using Props;
using System;
using System.Data;

namespace WebApplication
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_getdata.Visible = false;
            btn_updatenow.Visible = false;
            productDataGridView.Visible = false;
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string productId = productid_textbox.Text.Trim();
            string name = name_textbox.Text.Trim();
            string price = txtPrice.Text.Trim();
            string stock = txtStock.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(stock))
            {
                lblMessage.Text = "Please fill all the fields before saving.";
                lblMessage.Style["color"] = "#dc3545";
            }
            else
            {
                Props.prod newProduct = new Props.prod
                {
                    Product_Id1 = productId,
                    Name1 = name,
                    Price1 = price,
                    Stock1 = stock
                };

                ProdBLL productBLL = new ProdBLL();
                bool isInserted = productBLL.ProductInsertBLL(newProduct);

                if (isInserted)
                {
                    lblMessage.Text = "Product data saved successfully!";
                    lblMessage.Style["color"] = "#28a745";
                }
                else
                {
                    lblMessage.Text = "Error saving product data.";
                    lblMessage.Style["color"] = "#dc3545";
                }
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            string productId = productid_textbox.Text.Trim();

            ProdBLL productBLL = new ProdBLL();
            bool isDeleted = productBLL.ProductDeleteBLL(productId);

            if (isDeleted)
            {
                lblMessage.Text = "Product data deleted successfully!";
                lblMessage.Style["color"] = "#28a745";
            }
            else
            {
                lblMessage.Text = "Error deleting product data.";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            string productId = productid_textbox.Text.Trim();

            btn_getdata.Visible = true;
            name_textbox.Enabled = false;
            txtPrice.Enabled = false;
            txtStock.Enabled = false;

            lblMessage.Text = "Please click 'Get Data' to fetch the product details for updating.";
            lblMessage.Style["color"] = "#28a745";
        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            string productId = productid_textbox.Text.Trim();

            ProdBLL productBLL = new ProdBLL();

            DataTable dt = productBLL.ProductSearchBLL(productId);
            if (dt != null && dt.Rows.Count > 0)
            {
                name_textbox.Text = dt.Rows[0]["Name"].ToString();
                txtPrice.Text = dt.Rows[0]["Price"].ToString();
                txtStock.Text = dt.Rows[0]["Stock"].ToString();
            }
            else
            {
                lblMessage.Text = "Error searching data or no data found!";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_viewall_Click(object sender, EventArgs e)
        {
            string productId = "";
            string name = "";
            string price = "";
            string stock = "";

            ProdBLL productBLL = new ProdBLL();

            DataTable dt = productBLL.ProductViewAllBLL(productId, name, price, stock);

            if (dt != null && dt.Rows.Count > 0)
            {
                productDataGridView.Visible = true;
                productDataGridView.DataSource = dt;
                productDataGridView.DataBind();
            }
            else
            {
                lblMessage.Text = "No data found!";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_getdata_Click(object sender, EventArgs e)
        {
            string productId = productid_textbox.Text.Trim();

            ProdBLL productBLL = new ProdBLL();

            DataTable dt = productBLL.ProductSearchBLL(productId);
            if (dt != null && dt.Rows.Count > 0)
            {
                name_textbox.Text = dt.Rows[0]["Name"].ToString();
                txtPrice.Text = dt.Rows[0]["Price"].ToString();
                txtStock.Text = dt.Rows[0]["Stock"].ToString();

                btn_updatenow.Visible = true;
                name_textbox.Enabled = true;
                txtPrice.Enabled = true;
                txtStock.Enabled = true;
            }
            else
            {
                lblMessage.Text = "Product not found!";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_updatenow_Click(object sender, EventArgs e)
        {
            string productId = productid_textbox.Text.Trim();
            string name = name_textbox.Text.Trim();
            string price = txtPrice.Text.Trim();
            string stock = txtStock.Text.Trim();

            ProdBLL productBLL = new ProdBLL();
            bool isUpdated = productBLL.ProductUpdateBLL(productId, name, price, stock);

            if (isUpdated)
            {
                lblMessage.Text = "Product data updated successfully!";
                lblMessage.Style["color"] = "#28a745";
            }
            else
            {
                lblMessage.Text = "Error updating product data.";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            productid_textbox.Text = string.Empty;
            name_textbox.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStock.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }
        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            Response.Redirect("~/Login.aspx");
        }
    }
}
