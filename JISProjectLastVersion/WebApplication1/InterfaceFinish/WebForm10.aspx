<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="WebApplication1.InterfaceFinish.WebForm10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:FileUpload id="FileUploadControl" runat="server" OnTextchange="" />
      
                      <asp:Label runat="server" id="StatusLabel" text="Upload status: "  />
            

        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
