<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="CodeBehindDemo.aspx.cs" 
    Inherits="Module04.CodeBehindDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Literal Text="" runat="server"
            ID="simpleContent" />
        <div>
        </div>

        <p>

            <button id="sampleButton" >Client Side Button</button>
            <span id="placeholder"></span>
        </p>

        <p>
            <!-- HTML Controls will have a onserver.. events for server side events -->
           <button id="htmlButton" runat="server" onclick="" onserverclick="htmlButton_ServerClick" >Server Side HTML Button</button>
            <span id="placeholder2" runat="server"></span>
        </p>

        <p>
            <!-- Web Server Control -->
            <asp:Button ID="serverControlButton" runat="server" Text="Server side Web server control" OnClientClick="" OnClick="serverControlButton_Click" />
            <asp:Literal ID="placeholder3" runat="server" />
        </p>

    </form>



    <script>


        var btn = document.getElementById("sampleButton");
        btn.addEventListener("click", clientSide)

        function clientSide(evt) {

            evt.preventDefault(); //stop the page from being submit to the server and starting over

            var d = new Date();
            var placeholder = document.getElementById("placeholder");
            placeholder.textContent = "(client side) Today is " + d;
         

        }


    </script>
</body>
</html>
