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
        string Jname;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["type"] == null)
            //{
            //    Response.Redirect("Index.aspx");
            //}
        }
        
        protected void UpdateProfile_Click(object sender, EventArgs e)
        {

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
                            string fff = Path.GetFileName(FileUploadControl.FileName);
                           Jname = Path.GetRandomFileName() + fff;

                            FileUploadControl.SaveAs(Server.MapPath("/img/") + filename);

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

            }


            SqlConnection con = new SqlConnection(constr); 
                string queryString =
                "Insert into userprofile (workerid,firstname,lastname,telnumber,email,username,password,position ,photo) values ('" + Employee_id.Value + "','" + FirstName.Value + "','" + LastName.Value + "','" + TelephoneNumber.Value + "','" + EmailAddress.Value + "','" + Username.Value + "','" + Password.Value + "','" + positiondroupdown.SelectedIndex.ToString() + "','" +Jname+ "' )";

                con.Open();

                SqlCommand cmd = new SqlCommand(queryString, con);

                cmd.ExecuteNonQuery();
                string display2 = "เพิ่มหนักงานเรียบร้อยร้อย!";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display2 + "');");

                con.Close();
            
        }

      
    }

}