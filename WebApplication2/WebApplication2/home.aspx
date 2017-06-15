<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

  <title>JIS Solution</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <style>
    /* Remove the navbar's default margin-bottom and rounded borders */ 
    .navbar {
      margin-bottom: 0;
      border-radius: 0;
    }
    
    /* Set height of the grid so .sidenav can be 100% (adjust as needed) */
    .row.content {height: 450px}
    /*ตั้งสีให้โปร่งแสง*/
      .sidetranpairent {
      background-color:transparent;
       height: 100%;
        
      }
    /* Set gray background color and 100% height */
    .sidenav {
      padding-top: 20px;
      background-color: #fff;
      height: 100%;
      opacity: 0.8;
    filter: alpha(opacity=60);
    }
      .background {
          background-image: url("Huge-Backgrounds-58.jpg");
        background-repeat: no-repeat;
background-position: center center;
background-attachment: fixed;
-o-background-size: 100% 100%, auto;
-moz-background-size: 100% 100%, auto;
-webkit-background-size: 100% 100%, auto;
background-size: 100% 100%, auto;
	
      }
      .sideheadbar {
          background-color: #fff;
      height: 100%;
      }
    /* Set black background color, white text and some padding */
    footer {
      background-color: #555;
      color: white;
      padding: 15px;
    }
    
    /* On small screens, set height to 'auto' for sidenav and grid */
    @media screen and (max-width: 767px) {
      .sideheadbar {
        height: auto;
        padding: 15px;

      }
      .row.content {height:auto;} 
    }
      .bloglogin {
          width: 250px;
    margin: 0 auto;
      }
      .login input[type="text"], .login input[type="password"]
{       
    width: 100%;
    padding: 5px 10px;
    background: 0;
    border-bottom: 1px solid #FFFFFF;
    outline: 0;
    font-style: italic;
    font-size: 12px;
    font-weight: 400;
    letter-spacing: 1px;
    margin-bottom: 5px;
    color: #ffffff;
    outline: 0;
          border-left-style: none;
          border-left-color: inherit;
          border-left-width: 0;
          border-right-style: none;
          border-right-color: inherit;
          border-right-width: 0;
          border-top-style: none;
          border-top-color: inherit;
          border-top-width: 0;
          margin-left: 0;
          margin-right: 0;
          margin-top: 0;
      }
      .login input[type="submit"]
{
    width: 100%;
    font-size: 14px;
    text-transform: uppercase;
    font-weight: 500;
    margin-top: 16px;
    outline: 0;
    cursor: pointer;
    letter-spacing: 1px;
}

.login input[type="submit"]:hover
{
    transition: background-color 0.5s ease;
}

.login .remember-forgot
{
    float: left;
    width: 100%;
    margin: 10px 0 0 0;
}
.login .forgot-pass-content
{
    min-height: 20px;
    margin-top: 10px;
    margin-bottom: 10px;
}
.login label, form.login a
{
    font-size: 12px;
    font-weight: 400;
    color: #FFFFFF;
}

.login a
{
    transition: color 0.5s ease;
}

.login a:hover
{
    color: #2ecc71;
}

.pr-wrap
{
    width: 100%;
    height: 100%;
    min-height: 100%;
    position: absolute;
    top: 0;
    left: 0;
    z-index: 999;
    display: none;
}

.show-pass-reset
{
    display: block !important;
}

.pass-reset
{
    margin: 0 auto;
    width: 250px;
    position: relative;
    margin-top: 22%;
    z-index: 999;
    background: #FFFFFF;
    padding: 20px 15px;
}

.pass-reset label
{
    font-size: 12px;
    font-weight: 400;
    margin-bottom: 15px;
}

.pass-reset input[type="email"]
{
    width: 100%;
    margin: 5px 0 0 0;
    padding: 5px 10px;
    background: 0;
    border: 0;
    border-bottom: 1px solid #000000;
    outline: 0;
    font-style: italic;
    font-size: 12px;
    font-weight: 400;
    letter-spacing: 1px;
    margin-bottom: 5px;
    color: #000000;
    outline: 0;
}

.pass-reset input[type="submit"]
{
    width: 100%;
    border: 0;
    font-size: 14px;
    text-transform: uppercase;
    font-weight: 500;
    margin-top: 10px;
    outline: 0;
    cursor: pointer;
    letter-spacing: 1px;
}

.pass-reset input[type="submit"]:hover
{
    transition: background-color 0.5s ease;
}
.posted-by
{
    position: absolute;
    bottom: 26px;
    margin: 0 auto;
    color: #FFF;
    background-color: rgba(0, 0, 0, 0.66);
    padding: 10px;
    left: 45%;
}
p.blog-title
{
    font-family: 'Open Sans' , sans-serif;
    font-size: 10px;
    font-weight: 600;
    text-align: center;
    color: #FFFFFF;
    margin-top: 5%;
    text-transform: uppercase;
    letter-spacing: 4px;
}

  </style>
</head>
<body class= " background ">
     

    <form id="form1" runat="server">

<nav class="navbar navbar-inverse" >
  <div class="container-fluid sideheadbar">
    <div class="navbar-header">
     <%-- <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
        <span class="icon-bar">AAAAA/span>
        <span class="icon-bar">BBBB</span>
        <span class="icon-bar">VVVV</span>                        
      </button>--%>
      <a class="navbar-brand" href="#"></a>
    </div>
    <div class="collapse navbar-collapse" id="myNavbar">
     
          <img src="logo_jis.png " width="100" height="50" alt="klematis"  />
      
      <ul class="nav navbar-nav navbar-right">
        <li class="active"><a href="#">Home</a></li>
        <li><a href="#">Contact Admin</a></li>
        
        <li><a href="#"><span class="glyphicon glyphicon-log-in"></span> Login</a></li>
      </ul>
    </div>
  </div>
</nav>
  
<div class="container-fluid text-center">    
  <div class="row content">
    <div class="col-sm-2 sidetranpairent">
    
    </div>
      <div class="col-sm-8 text-left sidetranpairent">
      
            <div class="wrap bloglogin">
                <p class="blog-title">
                    Plese login your account</p>
                <div class="login">
                <input type="text" placeholder="Username" />
                <input type="password" placeholder="Password" />
                <input type="submit" value="Sign In" class="btn btn-success btn-sm" />
                <div class="remember-forgot">
                    <div class="row">
                        <div class="col-md-6">
                            <div class="checkbox">
                                <label>
                                    <input value="1" type="checkbox" />
                                    Remember Me
                                </label>&nbsp;&nbsp;&nbsp;&nbsp;
                                <a href="javascription:void(0)" class="forgot-pass">Forgot Password</a>
                            </div>
                            <%--<div class="col-md-6 forgot-pass-content">--%>
                            
                            <%--</div>--%>
                        </div>
                        
                    </div>
                </div>
                </div>
            </div>
      
      </div>
    <div class="col-sm-2 sidetranpairent">
      
      </div>
    </div>
  </div>


<footer class="container-fluid text-center">
  <p>Footer Text</p>
</footer>

    </form>

</body>
</html>