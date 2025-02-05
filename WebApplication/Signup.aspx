<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WebApplication.Signup" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Signup Page</title>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background: linear-gradient(to right, #0f2027, #203a43, #2c5364); 
            font-family: 'Arial', sans-serif;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }

        .signup-container {
            background-color: #ffffff; 
            padding: 40px;
            border-radius: 10px;
            box-shadow: 0px 8px 20px rgba(0, 0, 0, 0.2);
            width: 100%;
            max-width: 400px;
        }

        h2 {
            color: #001f4d; 
            margin-bottom: 30px;
            text-align: center;
        }

        label {
            font-weight: bold;
            color: #001f4d;
            display: block; 
            margin-bottom: 5px;
        }

        .form-control, .form-select {
            border: 1px solid #001f4d; 
            border-radius: 5px;
            padding: 10px;
            margin-bottom: 20px;
            transition: border-color 0.3s, box-shadow 0.3s;
            width: 100%;
        }

        .form-control:focus, .form-select:focus {
            border-color: #007bff; 
            box-shadow: 0 0 5px rgba(0, 123, 255, 0.5);
        }

        .btn {
            width: 45%;
            margin: 0; 
            border-radius: 5px;
            padding: 12px;
            font-weight: bold;
            transition: background-color 0.3s, border-color 0.3s;
        }

        .btn-primary {
            background-color: #007bff; 
            border: none;
            color: white;
        }

        .btn-primary:hover {
            background-color: #0056b3; 
        }

        .btn-secondary {
            background-color: #6c757d;
            border: none;
            color: white;
        }

        .btn-secondary:hover {
            background-color: #5a6268; 
        }

        .button-container {
            display: flex;
            justify-content: center;
            gap: 10px; 
        }

        #lblMessage {
            text-align: center;
            margin-top: 15px;
            font-weight: bold;
            color: red; 
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="signup-container">
            <h2>User Signup</h2>
            

            <div class="form-group">
                <label for="txtUsername">User Name:</label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter User Name"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtPassword">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Enter Password"></asp:TextBox>
            </div>

            

          <div class="form-group">
                <label for="ddlAccessLevel">Access Level:</label>
                <asp:DropDownList ID="ddlAccessLevel" runat="server" CssClass="form-select">
                    <asp:ListItem Value="0">Select Access Level</asp:ListItem>
                    <asp:ListItem Value="1">Manager</asp:ListItem>
                    <asp:ListItem Value="2">Supplier</asp:ListItem>
                    <asp:ListItem Value="3">Employee</asp:ListItem>
                    <asp:ListItem Value="4">Product</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label for="ddlStatus">Status:</label>
                <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-select">
                    <asp:ListItem Value="0">Inactive</asp:ListItem>
                    <asp:ListItem Value="1">Active</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="button-container">
                <asp:Button ID="btnSignup" runat="server" Text="Sign Up" OnClick="btn_insert" CssClass="btn btn-primary" />
                <asp:Button ID="Buttonlogin" runat="server" Text="Login" OnClick="btn_login" CssClass="btn btn-secondary" />
            </div>

            <div class="text-center">
                <asp:Label ID="lblMessage" runat="server" Text="" CssClass="message" Visible="false" />
            </div>
        </div>
    </form>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/4.5.2/js/bootstrap.bundle.min.js"></script>
</body>
</html>
