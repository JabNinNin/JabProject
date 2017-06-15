<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<head>
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
    
.wrapper {	
	margin-top: 80px;
  margin-bottom: 80px;
}

.form-signin {
  max-width: 380px;
  padding: 15px 35px 45px;
  margin: 0 auto;
  background-color: #fff;
  border: 1px solid rgba(0,0,0,0.1);  

  .form-signin-heading,
	.checkbox {
	  margin-bottom: 30px;
	}

	.checkbox {
	  font-weight: normal;
	}

	.form-control {
	  position: relative;
	  font-size: 16px;
	  height: auto;
	  padding: 10px;
		@include box-sizing(border-box);

		&:focus {
		  z-index: 2;
		}
	}

	input[type="text"] {
	  margin-bottom: -1px;
	  border-bottom-left-radius: 0;
	  border-bottom-right-radius: 0;
	}

	input[type="password"] {
	  margin-bottom: 20px;
	  border-top-left-radius: 0;
	  border-top-right-radius: 0;
	}
}
      
      
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
        <li><a href="#">New timesheet</a></li>
          <li><a href="#">View oldtimesheet</a></li>
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