<%@ Page Language="C#" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script runat="server" Language="c#">

        public void Page_Load()
        {

            var dt = DateTime.Today;
            var message = $"Today is {dt:d}.";
            simpleContent.Text = message;
        }

    </script>


</head>
<body>
    <form id="form1" runat="server">
        <asp:Literal ID="simpleContent" runat="server" />
    </form>
</body>
</html>
