using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Web.Configuration;



namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string constr = WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            //Convert.ToString(username.Value);
            SqlConnection con = new SqlConnection(constr);

            string queryString =
             "select * from userprofile where username = '" + Convert.ToString(username.Value) + "' and password = '" + Convert.ToString(password.Value) + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(queryString, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader["position"].ToString() == "Manager")
                {
                    
                    Session["userid"] = reader["id"].ToString();
                    Session["type"] = "Manager";
                    Response.Redirect("ManagerApproval.aspx");
                }
                if (reader["position"].ToString() == "Consult")
                {
                    Session["userid"] = reader["id"].ToString();
                    Session["type"] = "Consult";
                    Response.Redirect("ConsultViewTS.aspx");
                }
                if (reader["position"].ToString() == "Admin")
                {
                    Session["userid"] = reader["id"].ToString();
                    Session["type"] = "Addmin";
                    Response.Redirect("AdminViewTS.aspx");
                }


                //ถ้าไม่เจอข้อมูลไรเลย pop เตือน

            }
            con.Close();


            string display2 = Convert.ToString(username.Value);
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display2 + "');", true);



        }
    }
}