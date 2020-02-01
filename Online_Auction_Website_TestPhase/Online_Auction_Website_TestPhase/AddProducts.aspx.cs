using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace Online_Auction_Website_TestPhase
{
    public partial class AddProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileUpload1.SaveAs(Server.MapPath("~/images/") + Path.GetFileName(FileUpload1.FileName));
                string link = "images/" + Path.GetFileName(FileUpload1.FileName);



                string query = "insert into Products(category,item,price,image,Description) VALUES (@category,@item,@price,@image,@Description)";
                SqlConnection connection = new SqlConnection(DBCalss.connectionstring);
                //Connection String  

                //Open The Connection  
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@category", SqlDbType.NVarChar, 100).Value = txtUserID.Text;
                cmd.Parameters.Add("@item", SqlDbType.NVarChar, 100).Value = txtName.Text;

                cmd.Parameters.Add("@price", SqlDbType.NVarChar, 100).Value = txtFName.Text;
                cmd.Parameters.Add("@image", SqlDbType.NVarChar, 100).Value = link;

                cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 100).Value = link;



                int count = cmd.ExecuteNonQuery();
                //Close The Connection  
                connection.Close();
                if (count == 1)
                {
                    //BindGridData();  

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertmessage", "javascript:alert('Record added successfully')", true);
                    //call the method to bind the grid  




                }

                Label1.Text = "Data is saved !";

            }
            catch (Exception ex)
            {
                Label1.Text = "Error : " + ex.Message;

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProducts.aspx");
        }
    }
}