<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirm_button.aspx.cs" Inherits="Confirmation_Button.confirm_button" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 121px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table cellpadding="4" cellspacing="4" class="auto-style1">
                <tr>
                    <td class="auto-style2">Search By Id:</td>
                    <td>
                        <asp:TextBox ID="SearchTextBox" runat="server" Height="22px" Width="183px"></asp:TextBox>
                        <br />
                        <asp:Button ID="SearchButton" runat="server" OnClick="SearchButton_Click" Text="Search" />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Name:</td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Height="22px" Width="183px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Designation:</td>
                    <td>
                        <asp:TextBox ID="DesignationTextBox" runat="server" Height="22px" Width="183px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" Text="Update" />
&nbsp;<asp:Button ID="DeleteButton" runat="server" Text="Delete" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
