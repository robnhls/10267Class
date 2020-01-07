<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseDemo.aspx.cs" Inherits="Module04.CourseDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button Text="Do Work" ID="demoButton" runat="server"
            OnClick="demoButton_Click" /><br />

        <asp:Literal ID="samplePlaceholder" runat="server" />
    </form>
</body>
</html>
