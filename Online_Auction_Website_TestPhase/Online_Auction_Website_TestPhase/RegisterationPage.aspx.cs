using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Online_Auction_Website_TestPhase
{
    public partial class RegisterationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {


            try {
                SqlConnection conn = new SqlConnection(DBCalss.connectionstring);                                                                            ///userid,password,name,fathername,email,mobileNo,address

                string query = "INSERT INTO users(userid,password,name,fathername,email,mobileNo,address) values('" +txtUserID.Text +"','" +txtPw.Text +"','" + txtName.Text+"','" + txtFName.Text+"','" +txtEmail.Text +"','" +txtMobileNo.Text +"','" + txtAddress.Text+"')";

                SqlCommand sqlCmd = new SqlCommand(query, conn);
                conn.Open();
                sqlCmd.ExecuteNonQuery();
                conn.Close();

                Label1.Text = "You are registered";

            }
            catch(Exception ex)
            {
                Label1.Text = "Error : "+ex.Message;
            
            }




        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterationPage.aspx");
        }
    }
}