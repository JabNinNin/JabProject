using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.InterfaceFinish
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        int Countperiod;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Setinform(object sender, EventArgs e)
        {
            //Console.WriteLine("Hello");
            Countday.Text = DropDownList1.Text;
            if (DropDownList1.SelectedItem.Text == "Daily") { Countday.Text = "1"; }
            if (DropDownList1.SelectedItem.Text == "Weekly") { Countday.Text = "7"; }
            if (DropDownList1.SelectedItem.Text == "Mountly") { Countday.Text = "m"; }
            if (DropDownList1.SelectedItem.Text == "Manual") { Countday.Text = "0"; }
        }
    }
}