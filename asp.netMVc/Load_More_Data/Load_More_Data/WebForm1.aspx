<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Load_More_Data.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table
        {
            margin:auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

              

            <table border="1">
                <tr align="center">
                    <td align="center" colspan="6">Employee Details</td>
                </tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <HeaderTemplate>
                        <tr>
                            <td>Id</td>
                            <td>Name</td>
                            <td>Gender</td>
                            <td>Age</td>
                            <td>Designation</td>
                            <td>Salary</td>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("id") %></td>
                            <td><%# Eval("name") %></td>
                            <td><%# Eval("gender") %></td>
                            <td><%# Eval("age") %></td>
                            <td><%# Eval("designation") %></td>
                            <td><%# Eval("salary") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <tr>
                    <td align="center" colspan="6">
                        <asp:Button ID="Button1" runat="server" Text="LoadMore" OnClick="Button1_Click"/>
                    </td>
                </tr>
            </table>
                      </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
