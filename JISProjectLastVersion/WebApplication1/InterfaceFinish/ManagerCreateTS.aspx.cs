
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.IO;
using WebApplication1.Models;
using WebApplication1.App_code;
using System.Web.Mvc;
using System.Globalization;
namespace WebApplication1.InterfaceFinish
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        int gogo ;
        TimeSpan span;
        CultureInfo culture = new CultureInfo("EN-US");
        string constr = WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public static SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        public string getsession()
        {
            return Session["userid"].ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null)
            {
                Response.Redirect("Index.aspx");
            }
          
     



        }
        private void CreateTS()
        {
            WebForm6 GS = new WebForm6();
            var SSS = GS.getsession();
            int gogo=0 ;

            //int checkedpass=1;
            CheckTS();
            GetTotalTime();
            if (gogo == 1)
            {

                SqlConnection con = new SqlConnection(constr);

                string queryString =
                "insert into timesheets(project_id,employee_id,status,datework,start_time,end_time,work_hr,desciption)values ('"+DropDownList1.SelectedValue+"','"+ SSS+"','pending','"+DateTS.Value+"','"+starttime.Value+"','"+endtime.Value+"','"+span +"','"+ Desciption.Value +"')";

                con.Open();

                SqlCommand cmd = new SqlCommand(queryString, con);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('no success gogo no pass')", true);
        }
        public int CheckTS()
        {
            DateTime Todaydate = DateTime.Today;
            //string heha = DateTS.Value.ToString();
            SqlConnection con = new SqlConnection(constr);
            string queryStringID = "select * from Setperiod where  Firstcommit <='"+Todaydate.ToString("yyyy-MM-dd")+ "' and Lastcommit >='"+Todaydate.ToString("yyyy-MM-dd")+"' and ProjectID='" + DropDownList1.SelectedValue+"' ";
            //DateTime getdatetime = Convert.ToDateTime(DateTS.Value,culture);
            con.Open();
            
            SqlCommand cmdID = new SqlCommand(queryStringID, con);
            SqlDataReader readerID = cmdID.ExecuteReader();
            readerID.Read();
           
            
            DateTime FirstCommit = (DateTime)readerID["Firstcommit"];
            FirstCommit = FirstCommit.AddYears(-543);
            DateTime gg = Convert.ToDateTime(DateTS2.Text);
            DateTime LastComit = (DateTime)readerID["Lastcommit"];
            LastComit = LastComit.AddYears(-543);
            int idf = (int)readerID["id"];
           if (FirstCommit <= gg &&
                LastComit >=gg )
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ok')" , true);
                gogo = 1;

            }
         

            else
            {  /* string show = getdatetime.ToString();*/ /*ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ss')", true);*/
                Label2.Text = FirstCommit.ToString();
                Label3.Text = LastComit.ToString();

            }
            readerID.Close();


            cmdID.ExecuteNonQuery();


            con.Close();
            return (gogo);
        } 
        protected TimeSpan GetTotalTime()
        {
            DateTime starttimeD = DateTime.Parse(starttime.Value);
            DateTime endtimeD = DateTime.Parse(endtime.Value);
            span = endtimeD.Subtract(starttimeD);
            return span;
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTS.Value;
            CreateTS();
        }
    }
}