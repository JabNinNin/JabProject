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

    }
}