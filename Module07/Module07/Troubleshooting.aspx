<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Troubleshooting.aspx.cs" Inherits="Module07.Troubleshooting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter a number: <asp:TextBox ID="txtNumber" runat="server" />
        </div>

        <asp:Button runat="server" ID="btnInvoke" OnClick="btnInvoke_Click" />

        <asp:Literal ID="litMessage" runat="server" />
    </form>
</body>
</html>
