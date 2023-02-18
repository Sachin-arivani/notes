<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AlwaysVisibalControll.WebForm1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:Panel ID="Panel1" runat="server"></asp:Panel>
            <asp:Image ID="Image1" ImageUrl="~/images/heart.png" height="200" Width="200" runat="server" />
            <ajaxToolkit:AlwaysVisibleControlExtender ID="Image1_AlwaysVisibleControlExtender" runat="server" BehaviorID="Image1_AlwaysVisibleControlExtender" TargetControlID="Image1">
            </ajaxToolkit:AlwaysVisibleControlExtender>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
            <p>This is dummy paragraph</p>
        </div>
    </form>
</body>
</html>
