<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="report.aspx.cs" Inherits="WebApplication2.report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <asp:Label ID="Label4" runat="server" Text="REPORT FORM" style="font-weight: 700; font-size: x-large"></asp:Label>
    
        <br />
        <br />
    
        <table align="center" style="height: 164px; width: 459px">
            <tr align="center">
                <td class="auto-style2"><strong>QNO</strong></td>
                <td class="auto-style2"><strong>TOTAL RESPONSE</strong></td>
                <td class="auto-style2"><strong>YES RESPONSE</strong></td>
                <td class="auto-style2"><strong>NO RESPONSE</strong></td>
            </tr>
            <tr align="center">
                <td>
                    <asp:Label ID="qno" runat="server" Text="1"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="total1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="yes1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="no1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>

            <tr align="center">
                <td>
                    <asp:Label ID="Label1" runat="server" Text="2"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="total2" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="yes2" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="no2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>

            <tr align="center">
                <td>
                    <asp:Label ID="Label6" runat="server" Text="3"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="total3" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="yes3" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="no3" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Logout" PostBackUrl="~/login.aspx" Width="112px"  style="margin-left: 146px; font-weight: 700; font-size: medium;" OnClick="Button1_Click"/>
    
    </div>
    </form>
</body>
</html>
