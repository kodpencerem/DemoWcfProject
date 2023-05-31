<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetMessageForm.aspx.cs" Inherits="DemoWcfClient.GetMessageForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial">
            <asp:TextBox ID="tbxGetMessage" runat="server"></asp:TextBox>
            <asp:Button ID="btnGetMessage" runat="server" Text="Get Message" OnClick="btnGetMessage_Click" />
            <br />
            <asp:Label ID="lblGetMessage" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
