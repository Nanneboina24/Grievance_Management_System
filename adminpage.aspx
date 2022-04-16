<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminpage.aspx.cs" Inherits="WebApplication2.adminpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="CENTRAL FORM" style="font-weight: 700; font-size: x-large"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <div>

        </div>
        

    
    <table class="auto-style1">
        <tr align="center">
            
            <td><asp:Button ID="btnscore" runat="server" Text="View Report" style="font-weight: 700; font-size: medium" OnClick="btnscore_Click" /></td>
            <td><asp:Button ID="btnout" runat="server" Text="Logout" style="font-weight: 700; font-size: medium" OnClick="btnout_Click" /></td>
        </tr>
    </table>
        </form>
</body>
</html>
