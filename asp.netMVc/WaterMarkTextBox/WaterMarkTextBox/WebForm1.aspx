<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WaterMarkTextBox.WebForm1" %>

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
            width: 184px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table cellpadding="4" cellspacing="4" class="auto-style1">
                <tr>
                    <td class="auto-style2">FirstName:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Height="22px" OnTextChanged="TextBox1_TextChanged" Width="186px"></asp:TextBox>
                        <ajaxToolkit:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" runat="server" BehaviorID="TextBox1_TextBoxWatermarkExtender" TargetControlID="TextBox1" WatermarkText="Enter Your First Name">
                        </ajaxToolkit:TextBoxWatermarkExtender>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">LastName:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="186px"></asp:TextBox>
                        <ajaxToolkit:TextBoxWatermarkExtender ID="TextBox2_TextBoxWatermarkExtender" runat="server" BehaviorID="TextBox2_TextBoxWatermarkExtender" TargetControlID="TextBox2" WatermarkText="Enter Your Last Name">
                        </ajaxToolkit:TextBoxWatermarkExtender>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
