<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Module01.Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>

    <style>

        .underlined-button{
            text-decoration: underline;
            background-color: limegreen;
            color:antiquewhite;
        }

    </style>


</head>
<body>
    <form id="form1" runat="server">
       <h1>Hello Web forms</h1>
        
        <p class="underlined-button" id="firstParagraph" runat="server" >This is the first content that we have added to the page.</p>
        <p id="secondParagraph" runat="server">This is the second.</p>
        <hr />

        <asp:DropDownList ID="stateDropdown" EnableViewState="true"  runat="server">
            <asp:ListItem Value="fl" Text="Florida" />
            <asp:ListItem Value="oh" Text="Ohio" />
            <asp:ListItem Value="mi" Text="Michigan" />
            <asp:ListItem Value="ny" Text="New York" />
            <asp:ListItem Value="tx" Text="Texas" />
        </asp:DropDownList>

        <asp:Literal ID="Literal1" runat="server" Text="Zip" ></asp:Literal>
        
    </form>
</body>
</html>
<asp:Button ID="Button1" runat="server" Text="Refresh" CssClass="underlined-button"/>