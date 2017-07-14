using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.IO;

using System.Security.Cryptography;

using System.Collections.Concurrent;

using System.Text;
using System.Threading.Tasks;


namespace WebApplication1.InterfaceFinish
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string constr = WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        string Jname; string Kname;


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                
            }

            if (Session["type"] == null ||Session["type"].ToString() != "Admin" )
            {
                Response.Redirect("Index.aspx");
            }
        }
        
        protected void UpdateProfile_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);

            if (FileUploadControl.HasFile)
            {

                string fileName = Path.GetFileName(FileUploadControl.PostedFile.FileName);
                try
                {

                    if (FileUploadControl.PostedFile.ContentType == "image/gif" || FileUploadControl.PostedFile.ContentType == "image/jpeg" ||
                        FileUploadControl.PostedFile.ContentType == "image/png")
                    {
                        if (FileUploadControl.PostedFile.ContentLength > 0)
                        {
                            string filename = Path.GetFileName(FileUploadControl.FileName);

                            Jname = Path.GetRandomFileName() + filename;

                            string queryString2 = "select photo from userprofile ";

                            SqlCommand cmd2 = new SqlCommand(queryString2, con);
                            con.Open();
                            SqlDataReader reader = cmd2.ExecuteReader();
                            while (reader.Read())
                            {
                                Kname = Convert.ToString(reader["photo"]);
                            }
                            con.Close();
                            while (Jname == Kname) { Jname = Path.GetRandomFileName() + Jname; }

                            FileUploadControl.SaveAs(Server.MapPath("/img/") + Jname);

                            StatusLabel.Text = ("Upload status: File uploaded!");
                        }
                        else
                            StatusLabel.Text = "Upload status: The file has to be less than 100 kb!";
                    }
                    else
                        StatusLabel.Text = "Upload status: Only JPEG files are accepted!";

                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + Jname + "');", true);

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('"+ FileUploadControl.FileName.ToString() + "');", true);
            }


            string queryString =
            "Insert into userprofile (workerid,firstname,lastname,telnumber,email,username,password,position ,photo) values ('" + (Employee_id.Value )+ "','" + FirstName.Value + "','" + LastName.Value + "','" + TelephoneNumber.Value + "','" + EmailAddress.Value + "','" + Username.Value + "','" + Password.Value + "','" + positiondroupdown.SelectedIndex.ToString() + "','" + Jname + "')";

            con.Open();

            SqlCommand cmd = new SqlCommand(queryString, con);

            cmd.ExecuteNonQuery();
            string display2 = "เพิ่มหนักงานเรียบร้อยร้อย!";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display2 + "');");

            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }

    }

}