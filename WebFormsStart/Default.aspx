<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Image ID="imgQRcode" runat="server" />

    <p></p>
    <div>
        <asp:Label ID="lblSecretCode" runat="server"></asp:Label>
    </div>
    <form id="form1" runat="server">
        <div>
            Name:
            <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
            <br />
            <asp:Label ID="OutputLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
