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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBCalss.connectionstring);
            //Open database connection to connect to SQL Server
            con.Open();
            //Data table is used to bind the resultant data
            DataTable dtusers = new DataTable();
            // string query = "select * from products where userid='" + userId + "'";
            string query = "select * from products ";
            // Create a new data adapter based on the specified query.
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            //SQl command builder is used to get data from database based on query
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            //Fill data table
            da.Fill(dtusers);

            DataList1.DataSource = dtusers;
            DataList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string category = TxtSearch.Text;
            SqlConnection con = new SqlConnection(DBCalss.connectionstring);
            //Open database connection to connect to SQL Server
            con.Open();
            //Data table is used to bind the resultant data
            DataTable dtusers = new DataTable();
            // string query = "select * from products where userid='" + userId + "'";
            string query = "select * from products where category ='" + category + "' ";
            // Create a new data adapter based on the specified query.
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            //SQl command builder is used to get data from database based on query
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            //Fill data table
            da.Fill(dtusers);

            DataList1.DataSource = dtusers;
            DataList1.DataBind();
        }
    }
}