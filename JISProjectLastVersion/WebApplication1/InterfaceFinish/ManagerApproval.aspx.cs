using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.App_code;


namespace WebApplication1.InterfaceFinish
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        string constr = WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public static SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

        public string getsession()
        {
            return Session["userid"].ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["type"] == null || Session["type"].ToString() != "Manager")
            {
                Response.Redirect("Index.aspx");
            }
            if (!Page.IsPostBack)
            {
                ReloadData();
            }
            
            WebForm6 GS = new WebForm6();
            var SSS = GS.getsession();
            TBtest1.Text = SSS.ToString();
        }
        protected void ReloadData()
        {  //ดึงรายชื่อ Timesheets
            TSApproveList.DataSource = getTSHistory();
            TSApproveList.DataBind();
            
        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {  
          
            TSApproveList.DataSource = getTSHistory();
            TSApproveList.DataBind();
            //CheckBox AAp = (CheckBox)TSApproveList.Items[0].Controls[6];
            //TextBox1.Text = AAp.Checked.ToString();
        }
        public static List<ModelTS> getTSHistory()
        {
            WebForm6 GS = new WebForm6();
            var SSS = GS.getsession();
            DateTime DateToday = DateTime.Today;
            List<ModelTS> ListAPP = new List<ModelTS>();

            ModelTS ListinTS;

            //ดึง list log
            string queryString = @"SELECT [timesheets].[id] as ID,[project].projectname, [userprofile].firstname+' '+[userprofile].lastname as Name  ,[timesheets].datework as DateWork, [work_hr] as 'WorkHours', [project].end_date as Enddate ,status,[timesheets].desciption  
                                     FROM [timesheets] 
                                        Inner Join [project] ON [project].[id] =  [timesheets].[project_id]
                                        Inner Join [userprofile] ON [userprofile].[id] =  [timesheets].[employee_id]
                                        where [timesheets].[status]='pending'and [timesheets].project_id IN  (select Assign.project_id from Assign where Assign.employee_id = '"+ SSS +"')";
            con.Open(); /*+เดี่ยวกลับมาแก้ใส่session +*/
            SqlCommand command = new SqlCommand(queryString, con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListinTS = new ModelTS();
                ListinTS.id = (int)reader["ID"];
                ListinTS.Projectname = (string)reader["Projectname"];
                ListinTS.FristnameLastname = (string)reader["Name"];
                ListinTS.Worktime = Convert.ToString(reader["WorkHours"]);
                ListinTS.DateTS = Convert.ToString(((DateTime)reader["DateWork"]).ToString("dd/MM/yyyy"));
                ListinTS.Description = Convert.ToString(reader["Desciption"]);
                ListinTS.Checkstatus = (DateTime)reader["Enddate"];
                ListinTS.status = Convert.ToString(reader["status"]); ;







                ListAPP.Add(ListinTS);

            }
            con.Close();
            return ListAPP;
        }
        protected void rptLogList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            WebForm6 GS = new WebForm6();
            var SSS = GS.getsession();

            if (e.CommandName==("ApproveCommand"))
            {
                TBtest1.Text = e.CommandArgument.ToString() ;
                SqlConnection con = new SqlConnection(constr);

                con.Open();
                string QueryString = "update timesheets set  timesheets.status='Approve' where timesheets.id='" + e.CommandArgument.ToString() + "' ";
                SqlCommand cmd = new SqlCommand(QueryString, con);
                cmd = new SqlCommand(QueryString, con);
                cmd.ExecuteNonQuery();
                con.Close();
               

                con.Open();
                string QueryString3 = "insert into [AppCommit] (TSid,status,WorkerID) values('" + e.CommandArgument.ToString() + "','Aprove', '" + SSS + "' )";
                SqlCommand cmd3 = new SqlCommand(QueryString3, con);
                cmd3 = new SqlCommand(QueryString3, con);
                cmd3.ExecuteNonQuery();
                con.Close();



            }


            if (e.CommandName == ("RejectCommand"))
            {
                SqlConnection con = new SqlConnection(constr);

                con.Open();
                string QueryString = "update timesheets set  timesheets.status='Reject' where timesheets.id= '" + e.CommandArgument.ToString() + "' ";
                SqlCommand cmd = new SqlCommand(QueryString, con);
                cmd = new SqlCommand(QueryString, con);
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                string QueryString2 = "insert into timesheetdetail (timesheetID,datework,work_start,work_end,desciption,work_hr,status) select timesheets.id ,timesheets.datework,timesheets.start_time,timesheets.end_time,timesheets.desciption,timesheets.work_hr,timesheets.status from timesheets where timesheets.id = '" + e.CommandArgument.ToString() + "' ";
                SqlCommand cmd2 = new SqlCommand(QueryString2, con);
                cmd2 = new SqlCommand(QueryString2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
                con.Open();

                con.Open();
                string QueryString4 = "insert into [AppCommit] (TSid,status,WorkerID) values('" + e.CommandArgument.ToString() + "','Reject', '" + SSS + "' )";
                SqlCommand cmd4 = new SqlCommand(QueryString4, con);
                cmd4 = new SqlCommand(QueryString4, con);
                cmd4.ExecuteNonQuery();
                con.Close();
            }

        }



    }
}