<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditStudent.aspx.cs" Inherits="School_Database_by_UI.EditStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Edit Student</title>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content">
        <h2>Edit Student</h2>
      <asp:DropDownList ID="ddlStudentList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStudentList_SelectedIndexChanged" CssClass="form-control">
</asp:DropDownList>



        <br />
        <asp:TextBox ID="txtFirstName" runat="server" placeholder="First Name" CssClass="form-control" /><br />
        <asp:TextBox ID="txtLastName" runat="server" placeholder="Last Name" CssClass="form-control" /><br />
        <asp:Button ID="btnUpdateStudent" runat="server" Text="Update Student" OnClick="btnUpdateStudent_Click" CssClass="btn btn-primary" />


    </div>
</asp:Content>
