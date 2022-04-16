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
    public partial class register : System.Web.UI.Page
    {
        string gender,year;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                //registartion adding
                string strreg = @"INSERT INTO [dbo].[registertable]
           ([name]
           ,[dept]
           ,[year]
           ,[gender]
           ,[username]
           ,[password])
           VALUES
           ('"+txtname.Text+"','"+txtdept.Text+"' ,'"+year+"', '"+gender+"','"+txtuser.Text+"' ,'"+txtpass.Text+"' )";
                SqlCommand cmd = new SqlCommand(strreg, con);

                cmd.ExecuteNonQuery();

                //login adding
                string strlogin = @"INSERT INTO [dbo].[loginstable]
           ([username]
           ,[password])
           VALUES
           ('"+txtuser.Text+"', '"+txtpass.Text+"')";

                SqlCommand cmd2 = new SqlCommand(strlogin, con);

                cmd2.ExecuteNonQuery();

                clear();
                //Response.Write("<script>alert('Successfully Registered')</script>");
                Response.Redirect("registerstatus.aspx");
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

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            year = "1";
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            year = "2";
        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            year = "3";

        }

        protected void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            year = "4";

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            clear();
            Response.Redirect("login.aspx");
        }

        public void clear()
        {
            txtname.Text = "";
            txtdept.Text = "";
            txtuser.Text = "";
            txtpass.Text = "";
            if (RadioButton1.Checked)
                RadioButton1.Checked = false;
            if (RadioButton2.Checked)
                RadioButton2.Checked = false;
            if (RadioButton3.Checked)
                RadioButton3.Checked = false;
            if (RadioButton4.Checked)
                RadioButton4.Checked = false;
            if (RadioButton5.Checked)
                RadioButton5.Checked = false;
            if (RadioButton6.Checked)
                RadioButton6.Checked = false;
        }
    }
}