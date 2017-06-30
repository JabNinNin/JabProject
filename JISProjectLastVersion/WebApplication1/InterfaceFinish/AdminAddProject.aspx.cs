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


namespace WebApplication1.InterfaceFinish
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string constr = WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public static SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

      
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["type"] == null)
            //{
            //    Response.Redirect("Index.aspx");
            //}

            ReloadData();
        }
        protected void ReloadData()
        {  //ดึงรายชื่อ Timesheets
            TSConList.DataSource = getTSCon();
            TSConList.DataBind();
        }
        protected void InsertProject(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);

            string queryString =
            "Insert into project (projectname,start_date,end_date,desciption) values ('"+ Projectname.Value +"','"+ startdate.Value+"','"+enddate.Value +"','"+description.Value +"')";

            con.Open();

            SqlCommand cmd = new SqlCommand(queryString, con);

            cmd.ExecuteNonQuery();
            string display2 = "เพิ่มโปรเจคเรียบร้อย";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", " + display2 + ");

            con.Close();
            ReloadData();
        }
        public static List<Modelproject> getTSCon()
        {
           
            DateTime DateToday = DateTime.Today;
            List<Modelproject> ListAPP = new List<Modelproject>();

            Modelproject ListinTS;

            //ดึง list log
            string queryString = @"SELECT projectname,start_date,end_date,desciption FROM project";
            con.Open(); 
            SqlCommand command = new SqlCommand(queryString, con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListinTS = new Modelproject();
                //ListinTS.id = (int)reader["ID"];
                //ListinTS.Projectname = (string)reader["Projectname"];
                //ListinTS.FristnameLastname = (string)reader["Name"];
                //ListinTS.Worktime = Convert.ToString(reader["WorkHours"]);
                //ListinTS.DateTS = Convert.ToString(((DateTime)reader["DateWork"]).ToString("d"));
                //ListinTS.Description = Convert.ToString(reader["Description"]);
                //ListinTS.Checkstatus = (DateTime)reader["Enddate"];
                //ListinTS.status = Convert.ToString(reader["status"]); ;   
                ListinTS.ProjectName = (string)reader["projectname"];
                ListinTS.StartDate = Convert.ToString(((DateTime)reader["start_date"]).ToString(" dd/MM/yyyy "));
                ListinTS.EndDate = Convert.ToString(((DateTime)reader["end_date"]).ToString(" dd/MM/yyyy "));
                ListinTS.Description = Convert.ToString(reader["desciption"]);
                ListAPP.Add(ListinTS);
            }
            con.Close();
            
            return ListAPP;
            
        }
    }
}