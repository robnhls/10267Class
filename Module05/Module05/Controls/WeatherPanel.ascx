<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WeatherPanel.ascx.cs" Inherits="Module05.Controls.WeatherPanel" %>
<h2>Weather Information for <asp:Literal ID="cityNameLiteral" runat="server" /></h2>
<p>
    Today (<asp:Literal ID="dateLiteral" runat="server" />), the forcast is ...
</p>
<asp:Literal ID="forcast" runat="server">

</asp:Literal>