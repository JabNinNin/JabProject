<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            
        </div>

           <asp:Table id="MyTable" runat="server" cellspacing="0" cellpadding="5" border="1" Height="16px" Width="492px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">firstname <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>                   
                </asp:TableCell>
                <asp:TableCell runat="server">lastname <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>                   
                </asp:TableCell>
               
            </asp:TableRow>
           </asp:Table>
        <asp:Button ID="Button1" runat="server" Text="เพิ่ม" onclick="Button1_Click"/> 

        <asp:Button ID="Button3" runat="server" Text="ลด" />
        <asp:Button ID="Button4" runat="server" />

    </form>

</body>

</html>