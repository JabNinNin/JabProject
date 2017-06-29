using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace WebApplication1.App_code
{
    public class TSAPP
    {

        public static SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);


        public static List<ModelTS> getAllStatus()
        {
            DateTime DateToday = DateTime.Today;
            List<ModelTS> ListAPP = new List<ModelTS>();

            ModelTS ListinTS;

            //ดึง list log
            string queryString = @"SELECT [timesheets].[id],[project].projectname, [userprofile].firstname+' '+[userprofile].lastname as Name  ,[timesheets].datework as DateWork, [work_hr] as 'WorkHours', [project].end_date as Enddate ,status,[timesheets].description  
 FROM [timesheets] Inner Join [project] ON [project].[id] =  [timesheets].[project_id]Inner Join [userprofile] ON [userprofile].[id] =  [timesheets].[employee_id]where [timesheets].[status]='pending'" ;
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
                ListinTS.DateTS = Convert.ToString(((DateTime)reader["DateWork"]).ToString("dd/MM"));
                ListinTS.Description = Convert.ToString(reader["Description"]);
                ListinTS.Checkstatus =(DateTime)reader["Enddate"];
                if(DateToday<ListinTS.Checkstatus|| DateToday == ListinTS.Checkstatus)
                {   ListinTS.status = "In Time";

                } else
                    ListinTS.status = "Over Time";
              
                ListAPP.Add(ListinTS);

            }
            con.Close();
            return ListAPP;
        }

        public static List<ModelTS> getuserprofile()
        {
            DateTime DateToday = DateTime.Today;
            List<ModelTS> ListAPP = new List<ModelTS>();

            ModelTS ListinTS;

            //ดึง list log
            string queryString = @"SELECT [timesheets].[id],[project].projectname, [userprofile].firstname+' '+[userprofile].lastname as Name  ,[timesheets].datework as DateWork, [work_hr] as 'WorkHours', [project].end_date as Enddate ,status,[timesheets].description  
 FROM [timesheets] Inner Join [project] ON [project].[id] =  [timesheets].[project_id]Inner Join [userprofile] ON [userprofile].[id] =  [timesheets].[employee_id]where [timesheets].[status]='pending'";
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
                ListinTS.DateTS = Convert.ToString(reader["DateWork"]);
                ListinTS.Description = Convert.ToString(reader["Description"]);
                ListinTS.Checkstatus = (DateTime)reader["Enddate"];
                
                if (DateToday < ListinTS.Checkstatus || DateToday == ListinTS.Checkstatus)
                {
                    ListinTS.status = "In Time";

                }
                else
                    ListinTS.status = "Exceed the deadline";
               




                ListAPP.Add(ListinTS);

            }
            con.Close();
            return ListAPP;
        }
    }
}