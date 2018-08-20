<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
       You fingerprint is: <asp:Label ID="lblFingerprint" runat="server"></asp:Label>
    </div>
    <p></p>
    <form id="form1" runat="server">
        
        <asp:Image ID="imgQRcode" runat="server" />
        <div>
           Current token: <asp:Label ID="lblSecretCode" runat="server"></asp:Label>
        </div>
        <div>
            Please enter your token:
            <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
        </div>
    </form>
    
    <div>
        The result of comparison is: <asp:Label ID="lblCheck" runat="server"></asp:Label>
    </div>
    <script type ="text/javascript" src="Scripts/fingerprint2.js"></script>
    <script type ="text/javascript">
        var fp = new Fingerprint2();
        fp.get(function (result, components) {
            document.querySelector("#lblFingerprint").textContent = result;
        });
    </script>
</body>
</html>
