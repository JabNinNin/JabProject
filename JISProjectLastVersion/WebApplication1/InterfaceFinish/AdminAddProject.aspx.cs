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
            if (!Page.IsPostBack) {
                ReloadData(); }
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
            "Insert into project (projectname,start_date,end_date,desciption,Information) values ('" + Projectname.Value + "','" + startdate.Value + "','" + enddate.Value + "','" + Textarea1.Value + "','"+ Countday.Text+"')";

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
            string queryString = @"SELECT id,projectname,start_date,end_date,desciption,Information FROM project";
            con.Open();
            SqlCommand command = new SqlCommand(queryString, con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                ListinTS = new Modelproject();
                
                //ListinTS.Projectname = (string)reader["Projectname"];
                //ListinTS.FristnameLastname = (string)reader["Name"];
                //ListinTS.Worktime = Convert.ToString(reader["WorkHours"]);
                //ListinTS.DateTS = Convert.ToString(((DateTime)reader["DateWork"]).ToString("d"));
                //ListinTS.Description = Convert.ToString(reader["Description"]);
                //ListinTS.Checkstatus = (DateTime)reader["Enddate"];
                //ListinTS.status = Convert.ToString(reader["status"]); ;  
                ListinTS.id = (int)reader["id"];
                ListinTS.ProjectName = (string)reader["projectname"];
                ListinTS.StartDate = Convert.ToString(((DateTime)reader["start_date"]).ToString(" dd/MM/yyyy "));
                ListinTS.EndDate = Convert.ToString(((DateTime)reader["end_date"]).ToString(" dd/MM/yyyy "));
                ListinTS.Description = Convert.ToString(reader["desciption"]);
                ListinTS.Information = Convert.ToString(reader["Information"]);
                ListAPP.Add(ListinTS);
            }
            con.Close();

            return ListAPP;

        }
        protected void Setinform(object sender, EventArgs e)
        {
            Countday.Text = DropDownList1.Text;
            if (DropDownList1.SelectedItem.Text == "Daily") { Countday.Text = "1"; }
            if (DropDownList1.SelectedItem.Text == "Weekly") { Countday.Text = "7"; }
            if (DropDownList1.SelectedItem.Text == "Mountly") { Countday.Text = "m"; }
            if (DropDownList1.SelectedItem.Text == "Manual") { Countday.Text = "0"; }
        }
        private void Insertperiod()
        {

        }
        protected void rptLogList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

           
                if (e.CommandName.ToString() == ("EditCommand"))
                {
                string UserId = e.CommandArgument.ToString();
                Modelproject user = TSAPP.Editproject(UserId);

                Projectname.Value = user.ProjectName;
                startdate.Value = user.StartDate;
                enddate.Value = user.EndDate;
                Countday.Text = user.Information;
                Textarea1.Value = user.Description;



            }


                if (e.CommandName.ToString() == ("DeleteComand"))
            {
                SqlConnection con = new SqlConnection(constr);

                con.Open();
                string QueryString = "delete from project where id = '" + e.CommandArgument.ToString()+"' ";
                SqlCommand cmd = new SqlCommand(QueryString, con);
                cmd = new SqlCommand(QueryString, con);
                cmd.ExecuteNonQuery();
                con.Close();
                ReloadData();

            }
          
        }

        protected void btnwqwqe_Click(object sender, EventArgs e)
        {
            
            Modelproject user = new Modelproject();
            user.ProjectName = Convert.ToString(Projectname.Value);
            user.StartDate = Convert.ToString( startdate.Value);
            user.EndDate = Convert.ToString((string)enddate.Value);
            user.Information = Convert.ToString(Countday.Text);
            user.Description = Convert.ToString(Textarea1.Value);
            //Projectname.Value = user.ProjectName;
            //startdate.Value = user.StartDate;
            //enddate.Value = user.EndDate;
            //Countday.Text = user.Information;
            //Textarea1.Value = user.Description;


            TSAPP.editUser(user);
            ReloadData();
        }
    }
}