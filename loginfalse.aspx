<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginfalse.aspx.cs" Inherits="WebApplication2.loginfalse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="Label1" runat="server" Text="Error in Logging  Account" style="font-weight: 700; font-size: x-large"></asp:Label>
    
        <br />
    
        <br />
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Go Back" style="font-weight: 700; font-size: medium" PostBackUrl="~/login.aspx" OnClick="Button1_Click" />
    </form>
</body>
</html>
