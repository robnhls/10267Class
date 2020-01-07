<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Page3.aspx.cs" Inherits="Module05.Page3" %>

<%@ Register Src="~/Controls/WeatherPanel.ascx"
    TagPrefix="uc1" TagName="WeatherPanel" %>


<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">


    <h2>Page 3</h2>

    <p>
        <uc1:WeatherPanel runat="server" ID="WeatherPanel" City="Detroit" />

    </p>

    <p>
        <uc1:WeatherPanel runat="server" ID="WeatherPanel1" City="Orlando" />

    </p>

</asp:Content>



