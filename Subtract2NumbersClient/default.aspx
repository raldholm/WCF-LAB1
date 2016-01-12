<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Subtract2NumbersClient._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 46%;
        }
        .auto-style4 {
            height: 30px;
            width: 84px;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style5 {
            height: 23px;
            width: 84px;
        }
        .auto-style3 {
            height: 23px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button_Calculate" runat="server" OnClick="Button_Calculate_Click" Text="Calculate!" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <asp:Button ID="Button1" runat="server" Text="Button" />
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_Number1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:TextBox ID="txt_Number2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="LabelResult" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
