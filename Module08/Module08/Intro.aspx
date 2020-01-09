<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Intro.aspx.cs" Inherits="Module08.Intro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnConnect" runat="server" Text="connect" OnClick="btnConnect_Click" />
            <asp:Button ID="btnShowCategories" runat="server" Text="Categories" OnClick="btnShowCategories_Click" />
        </div>


        <asp:Literal ID="litMessage" runat="server" />
        <hr />
        Manual DDL
        <asp:DropDownList ID="ddlCategoriesManual" runat="server" />
        <br />
<%--        Data Bound
        <asp:DropDownList ID="ddlCategoriesDataBind" runat="server" />--%>


        <hr />

        <h2>Add a new Category</h2>
        <div>
            <asp:Label ID="lblName" runat="server" AssociatedControlID="txtName" Text="Name: " />
            <asp:TextBox ID="txtName" runat="server" />
            <asp:RequiredFieldValidator ID="rfvName" runat="server"
                ControlToValidate="txtName" ErrorMessage="Name is required" ValidationGroup="add_category" />
        </div>
        <div>
            <asp:Label ID="lblDescription" runat="server" AssociatedControlID="txtDescription" Text="Desc: " />
            <asp:TextBox ID="txtDescription" runat="server" />
            <asp:RequiredFieldValidator ID="rfvDescription" runat="server"
                ControlToValidate="txtDescription" ErrorMessage="Description is required" ValidationGroup="add_category" />
        </div>
        <asp:Button ID="btnAddCategory" runat="server" Text="Add Category" ValidationGroup="add_category" OnClick="btnAddCategory_Click" />

    </form>
</body>
</html>
