<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DeleteStudent.aspx.cs" Inherits="School_Database_by_UI.DeleteStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Delete Student</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content">
        <h2>Delete Student</h2>
        <asp:DropDownList ID="ddlStudentList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStudentList_SelectedIndexChanged" CssClass="form-control">
        </asp:DropDownList>

        <br />
        <asp:Label ID="lblStudentDetails" runat="server" Text="" CssClass="student-details"></asp:Label>
        <asp:Button ID="btnDeleteStudent" runat="server" Text="Delete Student" OnClick="btnDeleteStudent_Click" CssClass="btn btn-danger" />
    </div>
</asp:Content>
