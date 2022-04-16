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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            if (txtuser.Text == "admin" && txtpass.Text == "123")
            {
                Response.Redirect("adminpage.aspx");
            }
            else
            {
            try
            {
                
                con.Open();
                string str = "select Count(*) from loginstable where username='" + txtuser.Text + "' and password='" + txtpass.Text + "' ";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();
                if (dt.Rows[0][0].ToString() == "1")
                {
                    datastore.useradd(txtuser.Text);
                    datastore.passadd(txtpass.Text);
                    //Response.Write("<script>alert('"+datastore.getname()+"')</script>");
                    //Response.Write("<script>alert(" + datastore.getid() + ")</script>");
                    Response.Redirect("central.aspx");
                    clear();

                }
                else
                {
                    Response.Redirect("loginfalse.aspx");
                    clear();

                }

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
        }
        public void clear()
        {
            txtuser.Text = "";
            txtpass.Text = "";
        }
    }
}