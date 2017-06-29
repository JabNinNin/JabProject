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

            ReloadData();

        }
        protected void ReloadData()
        {  //ดึงรายชื่อ Timesheets
            TSApproveList.DataSource = TSAPP.getAllStatus();
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
            string queryString = @"SELECT [timesheets].[id],[project].projectname, [userprofile].firstname+' '+[userprofile].lastname as Name  ,[timesheets].datework as DateWork, [work_hr] as 'WorkHours', [project].end_date as Enddate ,status,[timesheets].description  
 FROM [timesheets] Inner Join [project] ON [project].[id] =  [timesheets].[project_id]Inner Join [userprofile] ON [userprofile].[id] =  [timesheets].[employee_id]where [timesheets].[status]='pending'and [timesheets].[employee_id]='" + SSS + "'";
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
                ListinTS.DateTS = Convert.ToString(((DateTime)reader["DateWork"]).ToString("d"));
                ListinTS.Description = Convert.ToString(reader["Description"]);
                ListinTS.Checkstatus = (DateTime)reader["Enddate"];

                ListinTS.status = Convert.ToString(reader["status"]); ;







                ListAPP.Add(ListinTS);

            }
            con.Close();
            return ListAPP;
        }
        
       
    }
}