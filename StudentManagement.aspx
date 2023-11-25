<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StudentManagement.aspx.cs" Inherits="School_Database_by_UI.StudentManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="content">
        <h2>Student Management</h2>
        <!-- Add content for student management as needed -->
    </div>

    <asp:Button ID="btnViewStudents" runat="server" Text="View Students" OnClick="btnViewStudents_Click" />


</asp:Content>
