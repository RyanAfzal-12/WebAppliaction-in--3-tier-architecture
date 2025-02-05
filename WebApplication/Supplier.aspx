<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Supplier.aspx.cs" Inherits="WebApplication.Supplier" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #CDD5D1;
            margin: 0;
            padding: 0;
        }

        .container {
            width: 80%;
            margin: 40px auto; 
            padding: 20px;
            background-color: #fff;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
            margin-top: 90px; 
            border-radius: 8px;
        }

        h2 {
            text-align: center;
            color: #333333;
            font-size: 24px;
            font-weight: bold;
            margin-bottom: 20px;
        }

        .form-group {
            margin-bottom: 20px;
            display: flex;
            align-items: center;
        }

        .form-group label {
            font-size: 16px;
            font-weight: 500;
            color:#333333 ; 
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

        .btn {
            padding: 10px 20px;
            background-color: #CDD5D1;
            color: white;
            font-size: 14px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            margin: 5px;
            transition: background-color 0.3s;
        }

        .btn:hover {
            background-color: #2b6cb0;
        }

        .btn-container {
            margin-top: 20px;
            text-align: center;
        }

        .btn-inline {
            display: inline-block;
            margin-left: 10px;
        }

        .error-message {
            color: #e53e3e;
            font-size: 14px;
            text-align: center;
        }

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
            background-color: #CDD5D1;
            color: white;
            font-size: 16px;
        }

        .grid-container .table tr:nth-child(even) {
            background-color: #f9f9f9;
        }

        .grid-container .table tr:hover {
            background-color: #f1f1f1;
        }

        #btn_logout {
            position: absolute;
            top: 20px;
            right: 20px;
            background-color: #e53e3e;
            color: white;
            border-radius: 5px;
            padding: 10px 15px;
            font-size: 14px;
            cursor: pointer;
            border: none;
        }

        #btn_logout:hover {
            background-color: #c53030;
        }
    </style>

    <div class="container">
        <h2>Supplier Management</h2>

        <div class="form-group">
            <label for="supplierid_textbox">Supplier ID</label>
            <asp:TextBox ID="supplierid_textbox" runat="server" CssClass="form-control" />
            <asp:Button ID="btn_getdata" runat="server" Text="Get Data" CssClass="btn btn-inline" Visible="true" OnClick="btn_getdata_Click" />
            <asp:Button ID="btn_updatenow" runat="server" Text="Update Now" CssClass="btn btn-inline" Visible="true" OnClick="btn_updatenow_Click" />
        </div>

        <div class="form-group">
            <label for="name_textbox">Name</label>
            <asp:TextBox ID="name_textbox" runat="server" CssClass="form-control" />
        </div>

        <div class="form-group">
            <label for="txtCellNo">Cell Number</label>
            <asp:TextBox ID="txtCellNo" runat="server" CssClass="form-control" />
        </div>

        <div class="form-group">
            <label for="txtAddress">Address</label>
            <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" />
        </div>

        <div class="btn-container">
            <asp:Button ID="btn_save" runat="server" Text="Save" CssClass="btn" OnClick="btnSave_Click" />
            <asp:Button ID="btn_delete" runat="server" Text="Delete" CssClass="btn" OnClick="btn_delete_Click" />
            <asp:Button ID="btn_update" runat="server" Text="Edit" CssClass="btn" OnClick="btn_edit_Click" />
            <asp:Button ID="btn_search" runat="server" Text="Search" CssClass="btn" OnClick="btn_search_Click" />
            <asp:Button ID="btn_viewall" runat="server" Text="View All" CssClass="btn" OnClick="btn_viewall_Click" />
            <asp:Button ID="btn_clear" runat="server" Text="Clear" CssClass="btn" OnClick="btn_clear_Click" />
            <asp:Button ID="btn_logout" runat="server" Text="Logout" CssClass="btn" OnClick="btn_logout_Click" />
        </div>

        <div class="error-message">
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>

        <div class="grid-container">
            <asp:GridView ID="supplierDataGridView" runat="server" AutoGenerateColumns="True" CssClass="table" Visible="false">
            </asp:GridView>
        </div>
    </div>
</asp:Content>
