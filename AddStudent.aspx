<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs"
    Inherits="School_Database_by_UI.AddStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Add New Student</h2>
    <div>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" EnableViewState="false"></asp:Label>
    </div>
    <div>
        <label for="txtFirstName">First Name:</label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First Name is required." ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div>
        <label for="txtLastName">Last Name:</label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last Name is required." ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Button ID="btnAddStudent" runat="server" Text="Add Student" OnClick="btnAddStudent_Click" />
    </div>

    <%--<h2>Add New Student</h2>
    <div>
        <label for="txtFirstName">First Name:</label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="txtLastName">Last Name:</label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnAddStudent" runat="server" Text="Add Student" OnClick="btnAddStudent_Click" />
    </div>--%>
</asp:Content>