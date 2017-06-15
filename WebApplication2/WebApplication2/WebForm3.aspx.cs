using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        
       
        protected void Page_Load(object sender, EventArgs e)
        {   // the two paramters are declared globally
            
        
    }

        private int numOfRows = 0;
        private int numOfColumns = 0;

        private void GenerateTable(int colsCount, int rowsCount)
        {

            //Creat the Table and Add it to the Page
            Table table = new Table();
            table.ID = "Table1";
            Page.Form.Controls.Add(table);

            // Now iterate through the table and add your controls 
            for (int i = 0; i < rowsCount; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < colsCount; j++)
                {
                    TableCell cell = new TableCell();
                    TextBox tb = new TextBox();
                    DropDownList ddl = new DropDownList();
                    // Set a unique ID for each TextBox added
                    //tb.ID = "TextBoxRow_" + i + "Col_" + j;
                    
                    // Add the control to the TableCell
                    
                    cell.Controls.Add(ddl);
                    cell.Controls.Add(tb);
                    cell.Controls.Add(tb);
                    // Add the TableCell to the TableRow
                    row.Cells.Add(cell);
                }

                // Add the TableRow to the Table
                table.Rows.Add(row);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Check if the inputs are numbers
            if (int.TryParse(TextBox1.Text.Trim(), out numOfColumns) && int.TryParse(TextBox2.Text.Trim(), out numOfRows))
            {
                //Generate the Table based from the inputs
                GenerateTable(numOfColumns, numOfRows);

                //Store the current Rows and Columns In ViewState as a reference value when it post backs
                ViewState["cols"] = numOfColumns;
                ViewState["rows"] = numOfRows;
            }
            else
            {
                Response.Write("Values are not numeric!");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //Check if ViewState values are null
            if (ViewState["cols"] != null && ViewState["rows"] != null)
            {
                //Find the Table in the page
                Table table = (Table)Page.FindControl("Table1");
                if (table != null)
                {
                    //Re create the Table with the current rows and columns
                    GenerateTable(int.Parse(ViewState["cols"].ToString()), int.Parse(ViewState["rows"].ToString()));

                    // Now we can loop through the rows and columns of the Table and get the values from the TextBoxes
                    for (int i = 0; i < int.Parse(ViewState["rows"].ToString()); i++)
                    {
                        for (int j = 0; j < int.Parse(ViewState["cols"].ToString()); j++)
                        {
                            //Print the values entered
                            if (Request.Form["TextBoxRow_" + i + "Col_" + j] != string.Empty)
                            {
                                Response.Write(Request.Form["TextBoxRow_" + i + "Col_" + j] + "<BR/>");
                            }
                        }
                    }
                }
            }
        }
    }
}