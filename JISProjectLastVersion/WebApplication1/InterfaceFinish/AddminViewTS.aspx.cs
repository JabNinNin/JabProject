﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.App_code;
using WebApplication1.Models;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace WebApplication1.InterfaceFinish
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null)
            {
                Response.Redirect("Index.aspx");
            }
        }

    }
}