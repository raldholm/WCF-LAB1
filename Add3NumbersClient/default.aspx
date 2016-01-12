<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Add3NumbersClient._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 46%;
        }
        .auto-style2 {
            width: 186px;
        }
    .auto-style3 {
        width: 186px;
        height: 27px;
    }
    .auto-style4 {
        height: 27px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
        </table>
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Calculate" runat="server" OnClick="Calculate_Click" Text="Calculate!" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox_Number1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2_Number2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3_Number3" runat="server"></asp:TextBox>
                </td>
                <td>Result:
                    <asp:Label ID="Label_Result" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
