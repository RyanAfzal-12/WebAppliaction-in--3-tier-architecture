using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLayer;
using DAL;
using Props;


namespace WebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Response.Write("<script>alert('Username and Password cannot be empty');</script>");
            }
            else
            {
                LoginBLL loginBLL = new LoginBLL();
                bool isAuthenticated = loginBLL.SelectBLL(username, password);

                if (isAuthenticated)
                {
                    Session["Username"] = username;
                    LoginDAL loginDAL = new LoginDAL();
                    int accesslevel = loginDAL.getAccessLevel(username, password);
                    Session["accesslevel"] = accesslevel;

                    switch (accesslevel)
                    {
                        case 1:
                            Response.Redirect("~/Manager.aspx");
                            break;
                        case 2:
                            Response.Redirect("~/Supplier.aspx");
                            break;
                        case 3:
                            Response.Redirect("~/Employee.aspx");
                            break;
                        case 4:
                            Response.Redirect("~/Product.aspx");
                            break;
                    }
                }
                else
                {
                    Response.Write("<script>alert('Invalid username or password');</script>");
                }
            }
        }
    }
    }