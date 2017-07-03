<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm11.aspx.cs" Inherits="WebApplication1.InterfaceFinish.WebForm11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="True" CssClass="form-control "  OnSelectedIndexChanged="Setinform">
                                                            <asp:ListItem Text="Daily">Daily</asp:ListItem>
                                                            <asp:ListItem Text="Weekly">Weekly</asp:ListItem>
                                                            <asp:ListItem Text="Mountly">Mountly</asp:ListItem>
                                                            <asp:ListItem Text="Manual" >Manual</asp:ListItem>
                                                        </asp:DropDownList>
            <asp:TextBox ID="Countday" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </form>
</body>
</html>
