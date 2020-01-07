<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseManagement.aspx.cs" Inherits="Module04.CourseManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Course Management</h1>

            <p>Select a mode, view or add</p>
            <asp:RadioButton ID="ViewRadioButton" Checked="true" runat="server" Text="View" GroupName="mode" OnCheckedChanged="ModeChanged" AutoPostBack="true" />
            <asp:RadioButton ID="AddRadioButton" runat="server" Text="Add" GroupName="mode" OnCheckedChanged="ModeChanged" AutoPostBack="true" />

            <asp:Panel ID="ViewPanel" runat="server">
                <h2>View Mode</h2>

                <asp:Label runat="server" Text="Select a Course" AssociatedControlID="CourseSelectionDropDown"></asp:Label>
                <asp:DropDownList ID="CourseSelectionDropDown" runat="server"></asp:DropDownList>
                <asp:Button ID="lookupCourseButton" runat="server" Text="Lookup" OnClick="lookupCourseButton_Click" />

                <div>
                    <asp:Literal ID="selectedCourseDisplay" runat="server" Text="No Course Selected" />
                </div>

            </asp:Panel>

            <asp:Panel ID="AddPanel" runat="server" Visible="false">
                <h2>Add Mode</h2>
                <asp:Label ID="lblTitle" runat="server" Text="Title"></asp:Label><asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>                        <br/>
                <asp:Label ID="lblDays" runat="server" Text="Days"></asp:Label><asp:TextBox ID="txtDays" runat="server"></asp:TextBox>                           <br/>
                <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label> <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>     <br/>

                <asp:Button ID="btnAdd" Text="Add" runat="server" OnClick="btnAdd_Click" />

            </asp:Panel>
        </div>
    </form>
</body>
</html>
