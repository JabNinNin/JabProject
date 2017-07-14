using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Windows;

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
            string queryString = @"SELECT [timesheets].[id],[project].projectname, [userprofile].firstname+' '+[userprofile].lastname as Name  ,[timesheets].datework as DateWork, [work_hr] as 'WorkHours', [project].end_date as Enddate ,status,[timesheets].desciption  
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
                ListinTS.Description = Convert.ToString(reader["Desciption"]);
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

        public static Modelproject Editproject(string id)
        {      //เมื่อตอนกด EDIT จะ get เข้า textbox
            Modelproject user = new Modelproject();
            string queryString = "select * from project where id=@id";
            con.Open();
            SqlCommand command = new SqlCommand(queryString, con);
            command.Parameters.AddWithValue("@id",id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                user.id = (int)reader["id"];
                user.ProjectName = (string)reader["projectname"];
                user.StartDate = Convert.ToString(((DateTime)reader["start_date"]).ToString(" dd/MM/yyyy "));
                user.EndDate = Convert.ToString(((DateTime)reader["end_date"]).ToString(" dd/MM/yyyy "));
                user.Description = (string)reader["desciption"];
                user.Information = (string)reader["Information"];
            }
            con.Close();
            return user;
        }
        

    }
}