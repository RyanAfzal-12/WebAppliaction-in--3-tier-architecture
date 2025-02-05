using BusinessLayer;
using Props;
using System;
using System.Data;

namespace WebApplication
{
    public partial class Supplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_getdata.Visible = false;
            btn_updatenow.Visible = false;
            supplierDataGridView.Visible = false;
            

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string supplierId = supplierid_textbox.Text.Trim();
            string name = name_textbox.Text.Trim();
            string cellNo = txtCellNo.Text.Trim();
            string address = txtAddress.Text.Trim();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(cellNo) || string.IsNullOrEmpty(address))
            {
                lblMessage.Text = "Please fill all the fields before saving.";
                lblMessage.Style["color"] = "#dc3545";
            }
            else
            {
               Props.supp newSupplier = new Props.supp
                {
                    Supplier_Id1 = supplierId,
                    Name1 = name,
                    Cell_No1 = cellNo,
                    Address1 = address
                };

                supBLL supplierBLL = new supBLL();
                bool isInserted = supplierBLL.SuppInsertBLL(newSupplier);

                if (isInserted)
                {
                    lblMessage.Text = "Supplier data saved successfully!";
                    lblMessage.Style["color"] = "#28a745";
                }
                else
                {
                    lblMessage.Text = "Error saving supplier data.";
                    lblMessage.Style["color"] = "#dc3545";
                }
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            string supplierId = supplierid_textbox.Text.Trim();

            supBLL supplierBLL = new supBLL();
            bool isDeleted = supplierBLL.SuppDeleteBLL(supplierId);

            if (isDeleted)
            {
                lblMessage.Text = "Supplier data deleted successfully!";
                lblMessage.Style["color"] = "#28a745";
            }
            else
            {
                lblMessage.Text = "Error deleting supplier data.";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            string supplierId = supplierid_textbox.Text.Trim();

            btn_getdata.Visible = true;
            name_textbox.Enabled = false;
            txtCellNo.Enabled = false;
            txtAddress.Enabled = false;

            lblMessage.Text = "Please click 'Get Data' to fetch the supplier details for updating.";
            lblMessage.Style["color"] = "#28a745";
        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            string supplierId = supplierid_textbox.Text.Trim();
            supBLL supplierBLL = new supBLL();

            DataTable dt = supplierBLL.SuppSearchBLL(supplierId);
            if (dt != null && dt.Rows.Count > 0)
            {
                name_textbox.Text = dt.Rows[0]["Name"].ToString();
                txtCellNo.Text = dt.Rows[0]["Cell_No"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
            }
            else
            {
                lblMessage.Text = "Error searching data or no data found!";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_viewall_Click(object sender, EventArgs e)
        {
            string supplierId = "";
            string name = "";
            string cellNo = "";
            string address = "";
            supBLL supplierBLL = new supBLL();

            DataTable dt = supplierBLL.SuppViewAllBLL(supplierId, name, cellNo, address);

            if (dt != null && dt.Rows.Count > 0)
            {
                supplierDataGridView.Visible = true;
                supplierDataGridView.DataSource = dt;
                supplierDataGridView.DataBind();
            }
            else
            {
                lblMessage.Text = "No data found!";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_getdata_Click(object sender, EventArgs e)
        {
            string supplierId = supplierid_textbox.Text.Trim();
            supBLL supplierBLL = new supBLL();

            DataTable dt = supplierBLL.SuppSearchBLL(supplierId);
            if (dt != null && dt.Rows.Count > 0)
            {
                name_textbox.Text = dt.Rows[0]["Name"].ToString();
                txtCellNo.Text = dt.Rows[0]["Cell_No"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();

                btn_updatenow.Visible = true;
                name_textbox.Enabled = true;
                txtCellNo.Enabled = true;
                txtAddress.Enabled = true;
            }
            else
            {
                lblMessage.Text = "Supplier not found!";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_updatenow_Click(object sender, EventArgs e)
        {
            string supplierId = supplierid_textbox.Text.Trim();
            string name = name_textbox.Text.Trim();
            string cellNo = txtCellNo.Text.Trim();
            string address = txtAddress.Text.Trim();

            supBLL supplierBLL = new supBLL();
            bool isUpdated = supplierBLL.SuppUpdateBLL(supplierId, name, cellNo, address);

            if (isUpdated)
            {
                lblMessage.Text = "Supplier data updated successfully!";
                lblMessage.Style["color"] = "#28a745";
            }
            else
            {
                lblMessage.Text = "Error updating supplier data.";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            supplierid_textbox.Text = string.Empty;
            name_textbox.Text = string.Empty;
            txtCellNo.Text = string.Empty;
            txtAddress.Text = string.Empty;
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
