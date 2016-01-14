<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="NameDayClient._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>Mata in namn:
                    <asp:TextBox ID="TextBox_Name" runat="server"></asp:TextBox>
                    <asp:Button ID="Button_GetDate" runat="server" OnClick="Button_GetDate_Click" Text="Räkna ut datum för namnsdag!" />
                </td>
            </tr>
            <tr>
                <td>Datum för namnsdag:
                    <asp:Label ID="Label_Date" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
