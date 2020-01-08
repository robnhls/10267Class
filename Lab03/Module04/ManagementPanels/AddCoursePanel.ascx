<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddCoursePanel.ascx.cs" Inherits="Module04.ManagementPanels.AddCoursePanel" %>
<h2>Add Mode</h2>
<asp:Label ID="lblTitle" runat="server" Text="Title"></asp:Label><asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblDays" runat="server" Text="Days"></asp:Label><asp:TextBox ID="txtDays" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
<asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
<br />

<asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
