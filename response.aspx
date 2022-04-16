<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="response.aspx.cs" Inherits="WebApplication2.response" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            height: 107px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <asp:Label ID="Label1" runat="server" Text="COMMENT FORM" style="font-weight: 700; font-size: x-large"></asp:Label>
        <br />
        <br />
        <br />
        </div>
        <div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2"><strong>1.Any Issues with C# subject ?</strong></td>
            </tr>
            <tr>
                <td>
                    
                    <asp:RadioButton GroupName="que1" ID="RadioButton3" runat="server" Text="YES" OnCheckedChanged="RadioButton3_CheckedChanged"/><br />
                    <asp:RadioButton GroupNmae="que1" ID="RadioButton4" runat="server" Text="NO" OnCheckedChanged="RadioButton4_CheckedChanged"/>

                    <br />

                    <br />

                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>2.Any Issues with Java subject ?</strong></td>
            </tr>
            <tr>
                <td class="auto-style3">
                   
                    <asp:RadioButton GroupName="que2" ID="RadioButton7" runat="server" Text="YES" OnCheckedChanged="RadioButton7_CheckedChanged"/><br />
                    <asp:RadioButton GroupNmae="que2" ID="RadioButton8" runat="server" Text="NO" OnCheckedChanged="RadioButton8_CheckedChanged"/>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>3.Any Issues with Python subject ?</strong></td>
            </tr>
            <tr>
                <td><asp:RadioButton GroupName="que3" ID="RadioButton9" runat="server" Text="YES" OnCheckedChanged="RadioButton9_CheckedChanged" /><br />
                    <asp:RadioButton GroupName="que3" ID="RadioButton10" runat="server" Text="NO" OnCheckedChanged="RadioButton10_CheckedChanged" /><br />
                    
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
       
        </table>
            <div><asp:Button ID="btnback" runat="server" Text="Back" OnClick="btnback_Click" style="font-weight: 700; font-size: medium" />
                <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" style="margin-left: 180px; font-weight: 700; font-size: medium;" />
            </div>
            
    </div>
    </form>
</body>
</html>
