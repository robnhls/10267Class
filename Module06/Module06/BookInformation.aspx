<%@ Page Language="C#" Trace="true" AutoEventWireup="true" CodeBehind="BookInformation.aspx.cs" Inherits="Module06.BookInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Enter Book Information</h1>

            <div>
                <asp:Label ID="lblTitle" runat="server" AssociatedControlID="txtTitle" Text="Title" />
                <asp:TextBox ID="txtTitle" runat="server" />
                <asp:RequiredFieldValidator ID="rfvTitle" runat="server"
                    ControlToValidate="txtTitle" ErrorMessage="Title is required" Text="*" />
            </div>
            <div>
                <asp:Label ID="lblAuthor" runat="server" AssociatedControlID="txtAuthor" Text="Author" />
                <asp:TextBox ID="txtAuthor" runat="server" />
                <asp:RequiredFieldValidator ID="rfvAuthor" runat="server"
                    ControlToValidate="txtAuthor" ErrorMessage="Author is required" Text="*" />
            </div>
            <div>
                <asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtEmail" Text="Email" />
                <asp:TextBox ID="txtEmail" runat="server" />

                <asp:RegularExpressionValidator ID="revEmail" runat="server"
                    ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ErrorMessage="Incorrectly formatted email address" Text="*"/>
            </div>
            <div>
                <asp:Label ID="lblPageCount" runat="server" AssociatedControlID="txtPageCount" Text="Page Count" />
                <asp:TextBox ID="txtPageCount" runat="server" />
                <asp:RequiredFieldValidator ID="rfvPageCount" runat="server" 
                    ControlToValidate="txtPageCount" ErrorMessage="Page Count is required" Display="Dynamic"  />


               <asp:CompareValidator ID="cvPageCountPositive" runat="server"
                    ControlToValidate="txtPageCount" ErrorMessage="Page count should be a positive number"
                     Operator="GreaterThan" Type="Integer" ValueToCompare="0" Display="Dynamic" />

                <asp:CustomValidator ID="custVPageCount" runat="server" 
                    ControlToValidate="txtPageCount" 
                    ClientValidationFunction="evenNumberOfPages" OnServerValidate="custVPageCount_ServerValidate"
                    ErrorMessage="Pages must be even"  Display="Dynamic" />
            </div>
            <div>
                <asp:Label ID="lblCategory" runat="server" AssociatedControlID="ddlCategory" Text="Category" />
                <asp:DropDownList ID="ddlCategory" runat="server">
                    <asp:ListItem Value="0" Text="" />
                    <asp:ListItem Value="1" Text="History" />
                    <asp:ListItem Value="2" Text="YA" />
                    <asp:ListItem Value="3" Text="Biography" />
                    <asp:ListItem Value="4" Text="Fantasy" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvCategory" runat="server" 
                    ControlToValidate="ddlCategory" ErrorMessage="Select a category" InitialValue="0"  Text="*"/>
            </div>
            <asp:Button ID="btnAdd" runat="server" Text="Add Book" OnClick="btnAdd_Click" />
            <asp:ValidationSummary ID="valSummary" runat="server" HeaderText="Errors on form"  />
        </div>
        <asp:Literal ID="litMessage" runat="server" />
    </form>


    <script>
        function evenNumberOfPages(ctrl, args) {
            var pages = args.Value;  //this is weird in JS to start with a cap, but it is what it is
            if (pages % 2 == 0) {
                //even
                args.IsValid = true; //Cap I is weird in JS
            }
            else {
                args.IsValid = false;
                //odd
            }
        }
    </script>
</body>
</html>
