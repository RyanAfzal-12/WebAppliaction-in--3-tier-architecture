<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Product.aspx.cs" Inherits="WebApplication.Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        .container {
            width: 60%;  /* Adjust the width to your preference */
            margin: 30px auto; /* Center the container */
            background-color: white;
            padding: 30px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }

        /* Header Styling */
        .header {
            background-color: #2b6cb0; /* Change the color as per your preference */
            color: white;
            padding: 20px;
            text-align: center;
            font-size: 26px;
            font-weight: bold;
            border-radius: 8px 8px 0 0;
        }

        /* Footer Styling */
        .footer {
            background-color: #333333;
            color: white;
            text-align: center;
            padding: 10px;
            position: fixed;
            bottom: 0;
            width: 100%;
            font-size: 14px;
            z-index: 1;
        }

        /* Styling the buttons */
        .btn {
            padding: 10px 20px;
            background-color: #2b6cb0;
            color: white;
            font-size: 14px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            margin: 5px;
            transition: background-color 0.3s;
        }

        .btn:hover {
            background-color: #1d4e89;
        }

        .btn-container {
            margin-top: 20px;
            text-align: center;
        }

        .btn-inline {
            display: inline-block;
            margin-left: 10px;
        }

        /* Styling for the error message */
        .error-message {
            color: #e53e3e;
            font-size: 14px;
            text-align: center;
        }

        /* Grid Styling */
        .grid-container {
            margin-top: 20px;
            overflow-x: auto;
        }

        .grid-container .table {
            width: 100%;
            border-collapse: collapse;
            margin: 20px 0;
        }

        .grid-container .table th,
        .grid-container .table td {
            text-align: left;
            padding: 10px;
            border: 1px solid #dddddd;
        }

        .grid-container .table th {
            background-color: #2b6cb0;
            color: white;
            font-size: 16px;
        }

        .grid-container .table tr:nth-child(even) {
            background-color: #f9f9f9;
        }

        .grid-container .table tr:hover {
            background-color: #f1f1f1;
        }

        /* Positioning the logout button */
        #btn_logout {
            position: absolute;
            top: 20px;
            left: 20px;
            background-color: #e53e3e; /* Red color */
        }

        /* Form and Input Styling */
        .form-group {
            margin-bottom: 20px;
            display: flex;
            align-items: center;
        }

        .form-group label {
            font-size: 16px;
            font-weight: 500;
            color: #333333;
            width: 150px;
        }

        .form-group input {
            flex: 1;
            padding: 10px;
            font-size: 14px;
            border: 1px solid #cccccc;
            border-radius: 5px;
        }

        .form-group input:focus {
            border-color: #2b6cb0;
            box-shadow: 0 0 5px rgba(43, 108, 176, 0.5);
        }

    </style>

    <div class="container">
        <div class="header">
            Product Management
        </div>

        <div class="form-group">
            <label for="productid_textbox">Product ID</label>
            <asp:TextBox ID="productid_textbox" runat="server" CssClass="form-control" />
            <asp:Button ID="btn_getdata" runat="server" Text="Get Data" CssClass="btn btn-inline" Visible="true" OnClick="btn_getdata_Click" />
            <asp:Button ID="btn_updatenow" runat="server" Text="Update Now" CssClass="btn btn-inline" Visible="true" OnClick="btn_updatenow_Click" />
        </div>

        <div class="form-group">
            <label for="name_textbox">Name</label>
            <asp:TextBox ID="name_textbox" runat="server" CssClass="form-control" />
        </div>

        <div class="form-group">
            <label for="txtPrice">Price</label>
            <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" />
        </div>

        <div class="form-group">
            <label for="txtStock">Stock</label>
            <asp:TextBox ID="txtStock" runat="server" CssClass="form-control" />
        </div>

        <div class="btn-container">
            <asp:Button ID="btn_save" runat="server" Text="Save" CssClass="btn" OnClick="btnSave_Click" />
            <asp:Button ID="btn_delete" runat="server" Text="Delete" CssClass="btn" OnClick="btn_delete_Click" />
            <asp:Button ID="btn_update" runat="server" Text="Edit" CssClass="btn" OnClick="btn_edit_Click" />
            <asp:Button ID="btn_search" runat="server" Text="Search" CssClass="btn" OnClick="btn_search_Click" />
            <asp:Button ID="btn_viewall" runat="server" Text="View All" CssClass="btn" OnClick="btn_viewall_Click" />
            <asp:Button ID="btn_clear" runat="server" Text="Clear" CssClass="btn" OnClick="btn_clear_Click" />
        </div>

        <div class="error-message">
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>

        <div class="grid-container">
            <asp:GridView ID="productDataGridView" runat="server" AutoGenerateColumns="True" CssClass="table" Visible="false">
            </asp:GridView>
        </div>
    </div>
</asp:Content>
