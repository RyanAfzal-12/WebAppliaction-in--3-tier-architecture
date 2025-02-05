using Business_Layer;
using BusinessLayer;
using Props;
using System;
using System.Data;

namespace WebApplication
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_getdata.Visible = false;
            btn_updatenow.Visible = false;
            customerDataGridView.Visible = false;
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string managerId = customerid_textbox.Text.Trim();
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
               Manager newCustomer = new Manager
                {
                    managerId1 = managerId,
                    Customer_Name1 = name,
                    Cell_No1 = cellNo,
                    Address1 = address
                };

                managerBLL customerBLL = new managerBLL();
                bool isInserted = customerBLL.CustInsertBLL(newCustomer);

                if (isInserted)
                {
                    lblMessage.Text = "Customer data saved successfully!";
                    lblMessage.Style["color"] = "#28a745";

                }
                else
                {
                    lblMessage.Text = "Error saving customer data.";
                    lblMessage.Style["color"] = "#dc3545";
                }
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            string customerId = customerid_textbox.Text.Trim();

            managerBLL customerBLL = new managerBLL();
            bool isDeleted = customerBLL.CustDeleteBLL(customerId);

            if (isDeleted)
            {
                lblMessage.Text = "Customer data deleted successfully!";
                lblMessage.Style["color"] = "#28a745";

            }
            else
            {
                lblMessage.Text = "Error deleting customer data.";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            string customerId = customerid_textbox.Text.Trim();

            btn_getdata.Visible = true;
            name_textbox.Enabled = false;
            txtCellNo.Enabled = false;
            txtAddress.Enabled = false;

            lblMessage.Text = "Please click 'Get Data' to fetch the customer details for updating.";
            lblMessage.Style["color"] = "#28a745";
        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            string customerId = customerid_textbox.Text.Trim();

            managerBLL customerBLL = new managerBLL();

            DataTable dt = customerBLL.CustSearchBLL(customerId);
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
            string customerId = "";
            string name = "";
            string cellNo = "";
            string address = "";

            managerBLL customerBLL = new managerBLL();

            DataTable dt = customerBLL.CustViewAllBLL(customerId, name, cellNo, address);

            if (dt != null && dt.Rows.Count > 0)
            {
                customerDataGridView.Visible = true;
                customerDataGridView.DataSource = dt;
                customerDataGridView.DataBind();
            }
            else
            {
                lblMessage.Text = "No data found!";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_getdata_Click(object sender, EventArgs e)
        {
            string customerId = customerid_textbox.Text.Trim();

            managerBLL customerBLL = new managerBLL();

            DataTable dt = customerBLL.CustSearchBLL(customerId);
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
                lblMessage.Text = "Customer not found!";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_updatenow_Click(object sender, EventArgs e)
        {
            string customerId = customerid_textbox.Text.Trim();
            string name = name_textbox.Text.Trim();
            string cellNo = txtCellNo.Text.Trim();
            string address = txtAddress.Text.Trim();

            managerBLL customerBLL = new managerBLL();
            bool isUpdated = customerBLL.CustUpdateBLL(customerId, name, cellNo, address);

            if (isUpdated)
            {
                lblMessage.Text = "Customer data updated successfully!";
                lblMessage.Style["color"] = "#28a745";
            }
            else
            {
                lblMessage.Text = "Error updating customer data.";
                lblMessage.Style["color"] = "#dc3545";
            }
        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            customerid_textbox.Text = string.Empty;
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