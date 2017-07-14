using System;
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
       
        string constr = WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public static SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( Session["type"] == null ||Session["type"].ToString() != "Admin" )
            {
                Response.Redirect("Index.aspx");
            }

            if (!Page.IsPostBack)
            {
                ReloadData();
            }
        }
        protected void ReloadData()
        {  //ดึงรายชื่อ Timesheets
            TSConList.DataSource = getTSCon();
            TSConList.DataBind();

        }
        public static List<ModelViewTS> getTSCon()
        {
            WebForm6 GS = new WebForm6();
            var SSS = GS.getsession();
            DateTime DateToday = DateTime.Today;
            List<ModelViewTS> ListAPP = new List<ModelViewTS>();

            ModelViewTS ListinTS;

            //ดึง list log
            string queryString = @"select timesheets.id as ID ,project.projectname as PJname,[userprofile].firstname+' '+[userprofile].lastname as Name,timesheets.datework as DateW ,work_hr as Hr ,status as ss,start_time as start,end_time as finish  ,[timesheets].desciption as descip from timesheets
inner join [project]on [project].[id] =[timesheets].[project_id]
inner join [userprofile] on [userprofile].id= [timesheets].employee_id
union
select timesheets.id,[project].projectname,[userprofile].firstname+' '+[userprofile].lastname , timesheetdetail.datework,timesheetdetail.work_hr,timesheetdetail.status ,timesheetdetail.work_start,work_end,timesheetdetail.desciption from timesheetdetail 
inner join [timesheets] on [timesheets].[id] = [timesheetdetail].timesheetID
inner join [project]on [project].[id] =[timesheets].[project_id]
inner join [userprofile] on [userprofile].id= [timesheets].employee_id";
            con.Open(); /*+เดี่ยวกลับมาแก้ใส่session +*/
            SqlCommand command = new SqlCommand(queryString, con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListinTS = new ModelViewTS();
                ListinTS.id = (int)reader["ID"];
                ListinTS.Projectname = (string)reader["PJname"];
                ListinTS.FristnameLastname = (string)reader["Name"];
                ListinTS.DateTS = Convert.ToString(reader["DateW"]);
                ListinTS.Worktime = Convert.ToString(reader["Hr"]);
                ListinTS.StartTime = Convert.ToString(reader["start"]);
                ListinTS.EndTime = Convert.ToString(reader["finish"]);
                ListinTS.Description = Convert.ToString(reader["descip"]);
                ListinTS.status = Convert.ToString(reader["ss"]);

                ListAPP.Add(ListinTS);

            }
            con.Close();
            return ListAPP;
        }
        protected void rptLogList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {


            //if (e.CommandName.ToString() == ("EditCommand"))
            //{
            //    string UserId = e.CommandArgument.ToString();

            //    Modelproject user = TSAPP.Editproject(UserId);

            //    Projectname.Value = user.ProjectName;
            //    startdate.Value = user.StartDate;
            //    enddate.Value = user.EndDate;
            //    Countday.Text = user.Information;
            //    Textarea1.Value = user.Description;

            //    jio.Text = Convert.ToString(user.id);

            //}


            //if (e.CommandName.ToString() == ("DeleteComand"))
            //{
            //    SqlConnection con = new SqlConnection(constr);

            //    con.Open();
            //    string QueryString = "delete from project where id = '" + e.CommandArgument.ToString() + "' ";
            //    SqlCommand cmd = new SqlCommand(QueryString, con);
            //    cmd = new SqlCommand(QueryString, con);
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    ReloadData();

            //}

        }
        protected void btnwqwqe_Click(object sender, EventArgs e)
        {

            ////Modelproject user = new Modelproject();
            //user.id = Convert.ToInt32(jio.Text);
            //user.ProjectName = Projectname.Value;
            //user.StartDate = startdate.Value;
            //user.EndDate = enddate.Value;
            //user.Information = Countday.Text;
            //user.Description = Textarea1.Value;
            ////Projectname.Value = user.ProjectName;
            ////startdate.Value = user.StartDate;
            ////enddate.Value = user.EndDate;
            ////Countday.Text = user.Information;
            ////Textarea1.Value = user.Description;


            //TSAPP.editUserPJ(user);





            //ReloadData();
        }



    }
}