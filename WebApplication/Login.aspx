<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background: linear-gradient(to right, #0f2027, #203a43, #2c5364); 
            display: flex;
            justify-content: center;
            align-items: center;
            font-family: Arial, sans-serif;
            height: 100vh; 
            margin: 0;
        }

        .login-container {
            background-color: #ffffff; 
            border-radius: 10px;
            padding: 40px;
            width: 100%;
            max-width: 400px; 
            box-shadow: 0px 8px 20px rgba(0, 0, 0, 0.2); 
            margin-top: 50px; 
        }

        .login-header {
            text-align: center;
            margin-bottom: 20px;
            color: #2c5364;
        }

        .form-control {
            border-radius: 5px;
            border: 1px solid #ccc;
            padding: 10px;
            font-size: 1rem;
        }

        .btn-login {
            background-color: #2c5364;
            color: white;
            border: none;
            border-radius: 5px;
            padding: 10px;
            width: 100%;
            font-size: 1rem;
        }

        .btn-login:hover {
            background-color: #1d2f3c;
        }

        .forgot-password {
            display: block;
            text-align: right;
            margin-top: 10px;
            font-size: 0.9rem;
            color: #2c5364;
        }

        .forgot-password:hover {
            text-decoration: underline;
            color: #1d2f3c;
        }

       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="login-container">
            <h3 class="login-header">Login to Your Account</h3>
            
            <div class="mb-3">
                <label for="txtUsername" class="form-label">Username</label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter your username" Required="true"></asp:TextBox>
            </div>
            
            <div class="mb-3">
                <label for="txtPassword" class="form-label">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter your password" Required="true"></asp:TextBox>
            </div>
            
            <div class="mb-3 form-check">
                <asp:CheckBox ID="chkRememberMe" runat="server" CssClass="form-check-input" />
                <label class="form-check-label" for="chkRememberMe">Remember Me</label>
            </div>
            
            <asp:Button ID="btnLogin" runat="server" CssClass="btn-login" Text="Login" OnClick="btnLogin_Click" />
            
            <a href="#" class="forgot-password">Forgot Password?</a>
        </div>
    </form>


</body>
</html>
