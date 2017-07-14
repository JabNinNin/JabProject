using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ModelUser
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
    }
    public class ModelTS
    {
        public int id { get; set; }
        public string Projectname { get; set; }
        public string FristnameLastname { get; set; }
        public string DateTS { get; set; }
        public string Worktime { get; set; }
        public string Description { get; set; }
        public DateTime Checkstatus { get; set; }
        public string status { get; set; }
        public string[] UpdatestatusID { get; set; }
        public int isSpprove { get; set; }
    }
    public class Modelproject
    {
        public int id { get; set; }
        public string ProjectName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string StartDate_sw { get; set; }
        public string EndDate_sw { get; set; }
        public string Description { get; set; }
        public string Information { get; set; }
        public DateTime startD { get; set; }
        public DateTime endD { get; set; }
    }
    public class ModelAssign
    {
        public int id  { get; set; }
        public string ProjectName_sw { get; set; }
        public string Employee_sw { get; set; }
        public string Description_sw { get; set; }        
    
       
        public int ProjectNameInsert { get; set; }
        public int EmployeeInsert { get; set; }
        public string DescriptionInsert { get; set; }
    }
    public class ModelViewTS {

        public int id { get; set; }
        public string Projectname { get; set; }
        public string FristnameLastname { get; set; }
        public string DateTS { get; set; }
        public string Worktime { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Description { get; set; }
        public string status { get; set; }
       
    }

}