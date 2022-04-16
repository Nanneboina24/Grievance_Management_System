<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication2.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {}
        .auto-style2 {
            height: 50px;
            text-align: left;
        }
        .auto-style3 {
            height: 50px;
            font-size: large;
            width: 131px;
        }
        .auto-style4 {
            height: 57px;
            font-size: large;
            text-align: left;
            width: 131px;
        }
        .auto-style6 {
            height: 57px;
            text-align: left;
        }
        .auto-style7 {
            text-align: left;
        }
        .auto-style8 {
            font-size: large;
        }
    </style>
</head>
<body style="font-weight: 700; font-size: x-large; text-align: center">
    <form id="form1" runat="server">
        <div align="center">
            <asp:Label ID="Label1" runat="server" Text="LOGIN PAGE"></asp:Label>
        </div>
        <table  align="center">
            <tr>
                <td class="auto-style3" style="text-align: left">USERNAME</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtuser" runat="server" placeholder="Enter Your Username"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">PASSWORD</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtpass" runat="server" Type="password" placeholder="***************"></asp:TextBox>
                </td>
            </tr>

            <tr>
                
                <td class="auto-style8"><a href ="register.aspx" runar="server">Don't Have Account?</a></td>
                <td align: left">
                    <asp:Button ID="Button1" runat="server" Text="Login" Width="77px" OnClick="Button1_Click" style="font-weight: 700" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
