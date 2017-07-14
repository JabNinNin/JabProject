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

namespace WebApplication1.InterfaceFinish
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        string constr = WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public static SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"]==null ||Session["type"].ToString() != "Admin" )
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
            TSConList.DataSource = getAsign();
            TSConList.DataBind();

        }
        public static List<ModelAssign> getAsign()
                {

           
                    List<ModelAssign> ListAPP = new List<ModelAssign>();

                    ModelAssign ListinAss;

                    //ดึง list log
                    string queryString = @"SELECT [Assign].[id] as ID,[project].[projectname] as ProjectName,[userprofile].[firstname]+'  '+[userprofile].[lastname] as Name,[Assign].[description] as Desciption
         FROM [Assign] 
         Inner Join [project] ON [project].[id] =  [Assign].[project_id]
         Inner Join [userprofile] ON [userprofile].[id] =  [Assign].[employee_id]";
                    con.Open();
                    SqlCommand command = new SqlCommand(queryString, con);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        ListinAss = new ModelAssign();

                        ListinAss.id = (int)reader["ID"];
                        ListinAss.ProjectName_sw = (string)reader["ProjectName"];
                        ListinAss.Employee_sw = (string)reader["Name"];
                        ListinAss.Description_sw = (string)reader["Desciption"];
                        ListAPP.Add(ListinAss);

                    }
                    con.Close();

                    return ListAPP;

                }
        protected void InsertProject(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);

            string queryString =
            "Insert into Assign (project_id,employee_id,description) values ('" + ProjectNameDD.SelectedValue + "','" + EmployeeDD.SelectedValue + "','" + descip.Text + "')";

            con.Open();

            SqlCommand cmd = new SqlCommand(queryString, con);

            cmd.ExecuteNonQuery();


            con.Close();
            ReloadData();
        }
        protected void rptLogList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {


            if (e.CommandName.ToString() == ("EditCommand"))
            {
                string UserId = e.CommandArgument.ToString();

                ModelAssign asign =  Editasign(UserId);
                ProjectNameDD.SelectedItem.Text = asign.ProjectName_sw;
                EmployeeDD.SelectedItem.Text = asign.Employee_sw;
                descip.Text = asign.Description_sw;

                jio.Text = Convert.ToString(asign.id);

            }


            if (e.CommandName.ToString() == ("DeleteComand"))
            {
                SqlConnection con = new SqlConnection(constr);

                con.Open();
                string QueryString = "delete from Assign where id = '" + e.CommandArgument.ToString() + "' ";
                SqlCommand cmd = new SqlCommand(QueryString, con);
                cmd = new SqlCommand(QueryString, con);
                cmd.ExecuteNonQuery();
                con.Close();
                ReloadData();

            }

        }
        protected void btnwqwqe_Click(object sender, EventArgs e)
        {

            ModelAssign ggez = new ModelAssign();
            ggez.id = Convert.ToInt16(  jio.Text);
            ggez.ProjectNameInsert = Convert.ToInt16( ProjectNameDD.SelectedValue);
            ggez.EmployeeInsert = Convert.ToInt16(EmployeeDD.SelectedValue);
            ggez.DescriptionInsert = descip.Text;
           


            editUserAs(ggez);
            
            ReloadData();
        }
        public static ModelAssign Editasign(string id)
        {      //เมื่อตอนกด EDIT จะ get เข้า textbox
            ModelAssign asign = new ModelAssign();
            string queryString = "SELECT [Assign].[id] as ID,[project].[projectname] as ProjectName,[userprofile].[firstname]+'  '+[userprofile].[lastname] as Name,[Assign].[description] as Desciption FROM[Assign] Inner Join[project] ON[project].[id] =  [Assign].[project_id] Inner Join[userprofile] ON[userprofile].[id] =  [Assign].[employee_id] where [Assign].[id]=@id";
            con.Open();
            SqlCommand command = new SqlCommand(queryString, con);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                asign.id = (int)reader["ID"];
                asign.ProjectName_sw =(string)reader["ProjectName"];
                asign.Employee_sw =(string)reader["Name"];
                asign.Description_sw = (string)reader["Desciption"];
            }
            con.Close();
            return asign;
        }
        public static void editUserAs(ModelAssign ggez)
        {
            string queryString =
         "update Assign set project_id=@ProjectName,employee_id=@Employee,description=@Desciption where id=@id ";
            con.Open();
            SqlCommand command = new SqlCommand(queryString, con);
            command.Parameters.AddWithValue("@id",ggez.id);
            command.Parameters.AddWithValue("@ProjectName", ggez.ProjectNameInsert);
            command.Parameters.AddWithValue("@Employee", ggez.EmployeeInsert);
            command.Parameters.AddWithValue("@Desciption", ggez.DescriptionInsert);
            command.ExecuteNonQuery();
            con.Close();



        }
    }
}