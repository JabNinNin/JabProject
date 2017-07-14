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
    public partial class WebForm1 : System.Web.UI.Page
    {   
        string constr = WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public static SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        Modelproject user = new Modelproject();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null ||Session["type"].ToString() != "Admin" )
            {
                Response.Redirect("Index.aspx");
            }

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
            
            con.Close();
            if(    DropDownList1.SelectedItem.Text == "Weekly"
                || DropDownList1.SelectedItem.Text == "Manual" )
            {   int round = Convert.ToInt16(Countday.Text);
                Insertperiod(round);
            }
            if (DropDownList1.SelectedItem.Text == "Mountly")
            {
                CreateMonth();
            }

            ReloadData();
        }
        private void Insertperiod(int round)
        { 
            CultureInfo culture = new CultureInfo("EN-US");
            DateTime FirstDate, LastDate = new DateTime(2000,12,30),EndDate;
            EndDate = Convert.ToDateTime(enddate.Value.ToString(), culture);
            FirstDate = Convert.ToDateTime(startdate.Value.ToString(), culture);
            int thailandnosaurus ;
            round -= 1;

            SqlConnection con = new SqlConnection(constr);
            string queryStringID = "select  IDENT_CURRENT('project') AS ID ";

            con.Open();

            SqlCommand cmdID = new SqlCommand(queryStringID, con);
            SqlDataReader readerID = cmdID.ExecuteReader();
             readerID.Read();
                thailandnosaurus = Convert.ToInt16( readerID["ID"]);
                readerID.Close();
            
            
            cmdID.ExecuteNonQuery();


            con.Close();
            while (LastDate <= EndDate)
            {
                int Stegosaurus=0;

            ////check firstDate
            while (Stegosaurus == 0)
            {
                string queryString = @"select * from Holiday where Holydate = '" + FirstDate.ToString("yyyy-MM-dd", culture) + "' ";
                con.Open();
                SqlCommand command = new SqlCommand(queryString, con);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FirstDate = FirstDate.AddDays(+1);
                }
                else
                {   
                    Label1.Text = FirstDate.ToShortDateString();
                    Stegosaurus = 1;
                }
                

               

                con.Close();
             
            }
            LastDate = FirstDate.AddDays(+round);
            //check lastDate
            while (Stegosaurus == 0)
            {
                string queryString = @"select * from Holiday where Holydate = '" + LastDate.ToString("yyyy-MM-dd", culture) + "' ";
                con.Open();
                SqlCommand command = new SqlCommand(queryString, con);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                   
                    LastDate = LastDate.AddDays(+1);
                }
                else
                {
                    Label2.Text = LastDate.ToShortDateString();
                    Stegosaurus = 1;
                }




                con.Close();

            }


                string queryStringIS = "insert into Setperiod(Firstcommit,Lastcommit,ProjectID) values('" + FirstDate.ToString("yyyy-MM-dd") + "','" + LastDate.ToString("yyyy-MM-dd") + "','"+ thailandnosaurus+"')";

                con.Open();

                SqlCommand cmdIS = new SqlCommand(queryStringIS, con);

                cmdIS.ExecuteNonQuery();


                con.Close();
                FirstDate = LastDate.AddDays(+1);

            }


        }
        protected void CreateMonth()
                {
            //        CultureInfo culture = new CultureInfo("EN-US");
            //        DateTime today = DateTime.Today;
            //        DateTime endOfMonth = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
            //        DateTime FirstDay = Convert.ToDateTime(startdate.Value.ToString(), culture);
            //        DateTime endOfMonth2 = new DateTime(FirstDay.Year ,FirstDay.Month, DateTime.DaysInMonth(FirstDay.Year, FirstDay.Month));
            //Label1.Text = endOfMonth.ToShortDateString();
            //Label2.Text = endOfMonth2.ToShortDateString();
            CultureInfo culture = new CultureInfo("EN-US");
            DateTime FirstDate, LastDate = new DateTime(2000, 12, 30), EndDate;
            EndDate = Convert.ToDateTime(enddate.Value.ToString(), culture);
            FirstDate = Convert.ToDateTime(startdate.Value.ToString(), culture);
            int thailandnosaurus;


            SqlConnection con = new SqlConnection(constr);
            string queryStringID = "select  IDENT_CURRENT('project') AS ID ";

            con.Open();

            SqlCommand cmdID = new SqlCommand(queryStringID, con);
            SqlDataReader readerID = cmdID.ExecuteReader();
            readerID.Read();
            thailandnosaurus = Convert.ToInt16(readerID["ID"]);
            readerID.Close();


            cmdID.ExecuteNonQuery();


            con.Close();
            while (LastDate <= EndDate)
            {
                int Stegosaurus = 0;

                ////check firstDate
                while (Stegosaurus == 0)
                {
                    string queryString = @"select * from Holiday where Holydate = '" + FirstDate.ToString("yyyy-MM-dd", culture) + "' ";
                    con.Open();
                    SqlCommand command = new SqlCommand(queryString, con);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        FirstDate = FirstDate.AddDays(+1);
                    }
                    else
                    {
                        
                        Stegosaurus = 1;
                    }




                    con.Close();

                }
                LastDate = new DateTime( FirstDate.Year, FirstDate.Month, DateTime.DaysInMonth(FirstDate.Year, FirstDate.Month));
                //check lastDate
                while (Stegosaurus == 0)
                {
                    string queryString = @"select * from Holiday where Holydate = '" + LastDate.ToString("yyyy-MM-dd", culture) + "' ";
                    con.Open();
                    SqlCommand command = new SqlCommand(queryString, con);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {

                        LastDate = LastDate.AddDays(-1);
                    }
                    else
                    {
                        
                        Stegosaurus = 1;
                    }




                    con.Close();

                }


                string queryStringIS = "insert into Setperiod(Firstcommit,Lastcommit,ProjectID) values('" + FirstDate.ToString("yyyy-MM-dd") + "','" + LastDate.ToString("yyyy-MM-dd") + "','" + thailandnosaurus + "')";

                con.Open();

                SqlCommand cmdIS = new SqlCommand(queryStringIS, con);

                cmdIS.ExecuteNonQuery();


                con.Close();
                FirstDate = LastDate.AddDays(+1);

            }


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
            if (DropDownList1.SelectedItem.Text == "Weekly") { Countday.Text = "5"; }
            if (DropDownList1.SelectedItem.Text == "Mountly") { Countday.Text = "MM"; }
            if (DropDownList1.SelectedItem.Text == "Manual") { Countday.Text = "0"; }
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

                jio.Text= Convert.ToString( user.id);
                IOP.Text = user.Information;
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

            //Modelproject user = new Modelproject();
            user.id = Convert.ToInt32(jio.Text);
            user.ProjectName = Projectname.Value;
            user.StartDate =   startdate.Value;
            user.EndDate = enddate.Value;
            user.Information = Countday.Text;
            user.Description = Textarea1.Value;
            //Projectname.Value = user.ProjectName;
            //startdate.Value = user.StartDate;
            //enddate.Value = user.EndDate;
            //Countday.Text = user.Information;
            //Textarea1.Value = user.Description;
            //if (user.Information != IOP.Text)
            //{
            //    Deletesetperoid(Convert.ToInt16(jio.Text));
            //    Insertperiod(Convert.ToInt16(Countday.Text));
            //}

            
            editUserPJ(user);





            ReloadData();
        }       
        public static void editUserPJ(Modelproject user)
        {
            string queryString =
         "update project set projectname=@ProjectName ,start_date=@StartDate,end_date=@EndDate,desciption=@Description,Information=@Information where id=@id ";
            con.Open();
            SqlCommand command = new SqlCommand(queryString, con);
            command.Parameters.AddWithValue("@id", user.id);
            command.Parameters.AddWithValue("@ProjectName", user.ProjectName);
            command.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(user.StartDate));
            command.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(user.EndDate));
            command.Parameters.AddWithValue("@Description", user.Description);
            command.Parameters.AddWithValue("@Information", user.Information);
            command.ExecuteNonQuery();
            con.Close();



        }
        public  void Deletesetperoid(int IOP)
        {   
            con.Open();

            string QueryDelete = @"DELETE from Setperiod where Setperiod.ProjectID='"+IOP+"'";
            SqlCommand cmdDelete = new SqlCommand(QueryDelete, con);
            cmdDelete.ExecuteNonQuery();
            con.Close();
        }
    }
}