<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerstatus.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Successfully Registered your account" style="font-weight: 700; font-size: x-large"></asp:Label>
    
        <br />
    
        <br />
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="GoTo Loginpage" style="font-weight: 700; font-size: medium" PostBackUrl="~/login.aspx" />
    </form>
</body>
</html>
