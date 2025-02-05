using BussinessLayer;
using Props;
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_login(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void btn_insert(object sender, EventArgs e)
        {
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();
            string AccessLevel = ddlAccessLevel.SelectedValue.Trim();  
            string Status = ddlStatus.SelectedValue.Trim();  

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(AccessLevel) || string.IsNullOrEmpty(Status))
            {
                lblMessage.Text = "Please fill all the fields before saving.";
                lblMessage.ForeColor = System.Drawing.Color.Red;  
                lblMessage.Visible = true; 
            }
            else
            {
                SignupProps newUser = new SignupProps
                {
                    UserName1 = Username,
                    UserPassword1 = Password,
                    UserAccessLevel1 = Convert.ToInt32(AccessLevel),  
                    UserStatus1 = Convert.ToInt32(Status) 
                };

                signupBLL signupBLL = new signupBLL();
                bool isInserted = signupBLL.InsertBLL(newUser);

                if (isInserted)
                {
                    lblMessage.Text = "User registered successfully!";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMessage.Text = "Error occurred during registration. Please try again.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }

                lblMessage.Visible = true;  
            }
        }
    }
}
