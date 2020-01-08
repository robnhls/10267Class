<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CourseManagement.aspx.cs" Inherits="Module04.CourseManagement" %>

<%@ Register Src="~/ManagementPanels/AddCoursePanel.ascx" TagPrefix="uc1" TagName="AddCoursePanel" %>



<asp:Content ID="courseManagementMainContent" runat="server" ContentPlaceHolderID="mainContent">

    <h3>Course Management</h3>

    <p>Select a mode, view or add</p>
    <asp:RadioButton ID="ViewRadioButton" Checked="true" runat="server" Text="View" GroupName="mode" OnCheckedChanged="ModeChanged" AutoPostBack="true" />
    <asp:RadioButton ID="AddRadioButton" runat="server" Text="Add" GroupName="mode" OnCheckedChanged="ModeChanged" AutoPostBack="true" />

    <asp:Panel ID="ViewPanel" runat="server">
        <h4>View Mode</h4>

        <asp:Label runat="server" Text="Select a Course" AssociatedControlID="CourseSelectionDropDown"></asp:Label>
        <asp:DropDownList ID="CourseSelectionDropDown" runat="server"></asp:DropDownList>
        <asp:Button ID="lookupCourseButton" runat="server" Text="Lookup" OnClick="lookupCourseButton_Click" />

        <div>
            <asp:Literal ID="selectedCourseDisplay" runat="server" Text="No Course Selected" />
        </div>

    </asp:Panel>

    <asp:Panel ID="AddPanel" runat="server" Visible="false">
        <uc1:AddCoursePanel runat="server" ID="AddCoursePanel" />
    </asp:Panel>

</asp:Content>
