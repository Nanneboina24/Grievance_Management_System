<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication2.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            width: 92px;
        }
        .auto-style2 {
            width: 92px;
            height: 25px;
        }
        .auto-style3 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <asp:Label ID="Label1" runat="server" Text="Registration Form" style="font-weight: 700; font-size: x-large"></asp:Label></div>
        <div>
        <br /><br /><br />
        <table align="center" style="height: 368px; width: 257px">
            <tr>
                <td class="auto-style1"><strong>Full Name</strong></td>
                <td>
                    <asp:TextBox ID="txtname" runat="server" placeholder="Enter  name"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"><strong>Department</strong></td>
                <td>
                    <asp:TextBox ID="txtdept" runat="server" placeholder="Enter  department"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"><strong>Year</strong></td>
                <td>
                    <asp:RadioButton GroupName="styear" ID="RadioButton3" runat="server" Text="I" OnCheckedChanged="RadioButton3_CheckedChanged"/><br />
                    <asp:RadioButton GroupName="styear" ID="RadioButton4" runat="server" Text="II" OnCheckedChanged="RadioButton4_CheckedChanged"/><br />
                    <asp:RadioButton GroupName="styear" ID="RadioButton5" runat="server" Text="III" OnCheckedChanged="RadioButton5_CheckedChanged" /><br />
                    <asp:RadioButton GroupName="styear" ID="RadioButton6" runat="server" Text="IV" OnCheckedChanged="RadioButton6_CheckedChanged" />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style1"><strong>Gender</strong></td>
                <td>
                    <asp:RadioButton GroupName="stgender" ID="RadioButton1" runat="server" Text="Male" OnCheckedChanged="RadioButton1_CheckedChanged"/><br />
                    <asp:RadioButton GroupName="stgender" ID="RadioButton2" runat="server" Text="Female" OnCheckedChanged="RadioButton2_CheckedChanged" />
                    
                    <br />
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style1"><strong>UserName</strong></td>
                <td>
                    <asp:TextBox ID="txtuser" runat="server" placeholder="Enter Username"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"><strong>Password</strong></td>
                <td>
                    <asp:TextBox ID="txtpass" runat="server" placeholder="***************" Type="password"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnlogin" runat="server" Text="Back" OnClick="btnlogin_Click" Width="67px" style="height: 26px; font-weight: 700" /></td>
                <td align="right" class="auto-style3">
                    <asp:Button ID="btnregister" runat="server" Text="Register" OnClick="btnregister_Click" style="font-weight: 700" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
