using BusinessLayer;
using Props;
using System;
using System.Data;

namespace WebApplication
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_getdata.Visible = false;
            btn_updatenow.Visible = false;
            employeDataGridView.Visible = false;
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string empId = empid_textbox.Text.Trim();
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
                Props.Employee newEmployee = new Props.Employee
                {
                    Emp_Id = empId,
                    Name = name,
                    Cell_No = cellNo,
                    Address = address
                };

                EmpBLL empBLL = new EmpBLL();
                bool isInserted = empBLL.EmpInsertBLL(newEmployee);

                if (isInserted)
                {
                    lblMessage.Text = "Employee data saved successfully!";
                    lblMessage.Style["color"] = "#28a745";

                }
                else
                {
                    lblMessage.Text = "Error saving employee data.";
                    lblMessage.Style["color"] = "#dc3545";

                }
            }


        }
        protected void btn_delete_Click(object sender, EventArgs e)
        {
            string empId = empid_textbox.Text.Trim();

            EmpBLL empBLL = new EmpBLL();
            bool isDeleted = empBLL.EmpDeleteBLL(empId);

            if (isDeleted)
            {
                lblMessage.Text = "Employee data deleted successfully!";
                lblMessage.Style["color"] = "#28a745";

            }
            else
            {
                lblMessage.Text = "Error deleting employee data.";
                lblMessage.Style["color"] = "#dc3545";
            }

        }
        protected void btn_edit_Click(object sender, EventArgs e)
        {
            string empId = empid_textbox.Text.Trim();

            btn_getdata.Visible = true;
            name_textbox.Enabled = false;
            txtCellNo.Enabled = false;
            txtAddress.Enabled = false;

            lblMessage.Text = "Please click 'Get Data' to fetch the employee details for updating.";
            lblMessage.Style["color"] = "#28a745";

        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            string empId = empid_textbox.Text.Trim();

            EmpBLL empBLL = new EmpBLL();

            DataTable dt = empBLL.EmpSearchBLL(empId);
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
            string empId = "";
            string name = "";
            string cellNo = "";
            string address = "";

            EmpBLL empBLL = new EmpBLL();

            DataTable dt = empBLL.EmpViewAllBLL(empId, name, cellNo, address);

            if (dt != null && dt.Rows.Count > 0)
            {
                employeDataGridView.Visible = true;
                employeDataGridView.DataSource = dt;
                employeDataGridView.DataBind();
            }
            else
            {
                lblMessage.Text = "No data found!";
                lblMessage.Style["color"] = "#dc3545";

            }
        }



        protected void btn_getdata_Click(object sender, EventArgs e)
        {
            string emp_Id = empid_textbox.Text.Trim();

            EmpBLL empBLL = new EmpBLL();

            DataTable dt = empBLL.EmpSearchBLL(emp_Id);
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
                lblMessage.Text = "Employee not found!";
                lblMessage.Style["color"] = "#dc3545";

            }
        }

        protected void btn_updatenow_Click(object sender, EventArgs e)
        {
            string empId = empid_textbox.Text.Trim();
            string name = name_textbox.Text.Trim();
            string cellNo = txtCellNo.Text.Trim();
            string address = txtAddress.Text.Trim();

            EmpBLL empBLL = new EmpBLL();
            bool isUpdated = empBLL.EmpUpdateBLL(empId, name, cellNo, address);

            if (isUpdated)
            {
                lblMessage.Text = "Employee data updated successfully!";
                lblMessage.Style["color"] = "#28a745";

            }
            else
            {
                lblMessage.Text = "Error updating employee data.";
                lblMessage.Style["color"] = "#dc3545";

            }
        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            empid_textbox.Text = string.Empty;
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