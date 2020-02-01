using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Online_Auction_Website_TestPhase
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string userId = TextBox1.Text;

            string password = TextBox2.Text;


            SqlConnection con = new SqlConnection(DBCalss.connectionstring);
            //Open database connection to connect to SQL Server
            con.Open();
            //Data table is used to bind the resultant data
            DataTable dtusers = new DataTable();
            string query = "select * from users where userid='"+userId+"'";
            // Create a new data adapter based on the specified query.
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            //SQl command builder is used to get data from database based on query
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            //Fill data table
            da.Fill(dtusers);


            if (dtusers.Rows.Count > 0)
            {
                Response.Redirect("Home.aspx");

            }
            else
            {
                Label1.Text = "Userid or password is wrong";
            }



        }
    }
}