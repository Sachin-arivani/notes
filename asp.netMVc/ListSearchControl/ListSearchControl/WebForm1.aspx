<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ListSearchControl.WebForm1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 550px;
        }
        .auto-style2 {
            width: 195px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table cellpadding="4" cellspacing="4" class="auto-style1">
                <tr>
                    <td class="auto-style2">Search Here</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                
                <tr>
                    <td class="auto-style2">
                        <asp:ListBox ID="ListBox1" runat="server" Height="182px" Width="181px">
                            <asp:ListItem>Orange</asp:ListItem>
                            <asp:ListItem>Banana</asp:ListItem>
                            <asp:ListItem>PineApple</asp:ListItem>
                            <asp:ListItem>Pereu</asp:ListItem>
                            <asp:ListItem>WaterMelon</asp:ListItem>
                            <asp:ListItem>Apple</asp:ListItem>
                            <asp:ListItem>Govava</asp:ListItem>
                            <asp:ListItem>Pear</asp:ListItem>
                            <asp:ListItem>Chilli</asp:ListItem>
                            <asp:ListItem>Coconut</asp:ListItem>
                            <asp:ListItem>Liberyt</asp:ListItem>
                            <asp:ListItem>Khadim</asp:ListItem>
                            <asp:ListItem>Bata</asp:ListItem>
                            <asp:ListItem>Pee</asp:ListItem>
                            <asp:ListItem>Potato</asp:ListItem>
                            <asp:ListItem>garlik</asp:ListItem>
                            <asp:ListItem>Chukandar</asp:ListItem>
                        </asp:ListBox>
                        <ajaxToolkit:ListSearchExtender ID="ListBox1_ListSearchExtender" runat="server" BehaviorID="ListBox1_ListSearchExtender" TargetControlID="ListBox1">
                        </ajaxToolkit:ListSearchExtender>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Height="26px" Text="Submit" Width="56px" />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
