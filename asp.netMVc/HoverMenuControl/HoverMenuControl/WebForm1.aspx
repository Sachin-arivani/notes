<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HoverMenuControl.WebForm1" %>

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
            <asp:Label ID="Label1" runat="server" Text="Mouse Hover Show The pannel"></asp:Label>
            <ajaxToolkit:HoverMenuExtender ID="Label1_HoverMenuExtender" runat="server" BehaviorID="Label1_HoverMenuExtender" DynamicServicePath="" PopupControlID="Panel1" PopupPosition="Bottom" TargetControlID="Label1">
            </ajaxToolkit:HoverMenuExtender>
            <br />
            <asp:Panel ID="Panel1" runat="server" BackColor="#FFFFCC" BorderColor="Black" BorderStyle="Ridge" BorderWidth="5px" Height="69px" Width="196px">
                <asp:Label ID="Label2" runat="server" Text="Pannel Message Show There"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
