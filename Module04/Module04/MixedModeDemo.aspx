<%@ Page Language="C#"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <%
            //Not recommended.
            DateTime dt = DateTime.Now;
        %>

        <p>
            Today is <%= dt.ToString("d") %>.
        </p>
        <div>
        </div>
    </form>
</body>
</html>
