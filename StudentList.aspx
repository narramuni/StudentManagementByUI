<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="School_Database_by_UI.StudentList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Student List</h2>
            <asp:GridView ID="GridViewStudents" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="StudentID" EmptyDataText="No students found">
                <Columns>
                    <asp:BoundField DataField="StudentID" HeaderText="Student ID" SortExpression="StudentID" />
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" />
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "EditStudent.aspx?StudentID=" + Eval("StudentID") %>' Text="Edit"></asp:HyperLink>
                            <asp:LinkButton ID="lnkDelete" runat="server" OnClientClick="return confirm('Are you sure you want to delete this student?');" CommandName="Delete" CommandArgument='<%# Eval("StudentID") %>'>Delete</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
