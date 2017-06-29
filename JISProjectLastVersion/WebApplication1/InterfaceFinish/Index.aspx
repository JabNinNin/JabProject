<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="../Content/LoginStylesheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="modal-dialog">
    <div class="modal-content">
        <div class="modal-header">
          <h1 class="text-center">Welcome</h1>
        </div>
         <div class="modal-body">
             <div class="form-group">
                 <input id="username" runat="server" type="text" class="form-control input-lg" placeholder="Username"/>
             </div>

             <div class="form-group">
                 <input id="password" runat="server" type="password" class="form-control input-lg" placeholder="Password"/>
             </div>

             <div class="form-group">
                 <%--<input type="submit"  value="Login"/>--%>
                 <asp:Button ID="login" runat="server" Text="Login" CssClass="btn btn-block btn-lg btn-primary" OnClick="login_Click"   />
                 <span class="pull-right"><a href="#">Register</a></span><span><a href="#">Forgot Password</a></span>
             </div>
         </div>
    </div>
 </div>

    </form>
</body>
</html>
