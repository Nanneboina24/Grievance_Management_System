using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace WebApplication2
{
    public partial class response : System.Web.UI.Page
    {
        int qn1 = 1, qn2 = 2, qn3 = 3;
        string q1 = "", q2 = "", q3 = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("central.aspx");
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            
            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
         
            try
            {
                con.Open();
                
                string str1 = @"INSERT INTO [dbo].[responsetable]
           ([qno]          
           ,[response])
            VALUES
           ("+qn1+", '"+q1+"')";

                string str2 = @"INSERT INTO [dbo].[responsetable]
           ([qno]          
           ,[response])
            VALUES
           (" + qn2 + ", '" + q2 + "')";

                string str3 = @"INSERT INTO [dbo].[responsetable]
           ([qno]          
           ,[response])
            VALUES
           (" + qn3 + ", '" + q3 + "')";

                SqlCommand cmd1 = new SqlCommand(str1, con);                       
                
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(str2, con);

                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand(str3, con);

                cmd3.ExecuteNonQuery();
                Response.Redirect("ressub.aspx");
                
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            q1 = "yes";
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            q1 = "no";
        }

        protected void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            q2 = "yes";
        }

        protected void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            q2 = "no";
        }

        protected void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            q3 = "yes";
        }

        protected void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            q3 = "no";
        }








        





        
        
    }
}