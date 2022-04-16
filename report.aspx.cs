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
    public partial class report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            
            try
            {
                con.Open();

                string str1 = "select Count(*) from responsetable where qno= "+1+" ";                                                  //"++" //int
                SqlCommand cmd1 = new SqlCommand(str1, con);                         //'"++"' //string
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                cmd1.ExecuteNonQuery();
                total1.Text = dt1.Rows[0][0].ToString();

                Console.Write(dt1.Rows[0][0].ToString());

              

                string str2 = "select Count(*) from responsetable where qno= " + 2 + " ";                                                  //"++" //int
                SqlCommand cmd2 = new SqlCommand(str2, con);                         //'"++"' //string
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                cmd2.ExecuteNonQuery();
                total2.Text = dt2.Rows[0][0].ToString();

                string str3 = "select Count(*) from responsetable where qno= " + 3 + " ";                                                  //"++" //int
                SqlCommand cmd3 = new SqlCommand(str3, con);                         //'"++"' //string
                SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                cmd3.ExecuteNonQuery();
                total3.Text = dt3.Rows[0][0].ToString();


                string str4 = "select Count(response) from responsetable where response='yes' and qno="+1+" group by qno ; ";                                                  //"++" //int
                SqlCommand cmd4 = new SqlCommand(str4, con);                         //'"++"' //string
                SqlDataAdapter sda4 = new SqlDataAdapter(cmd4);
                DataTable dt4 = new DataTable();
                sda4.Fill(dt4);
                cmd4.ExecuteNonQuery();
                yes1.Text = dt4.Rows[0][0].ToString();

                string str5 = "select Count(response) from responsetable where response='yes' and qno=" + 2 + " group by qno ; ";                                                  //"++" //int
                SqlCommand cmd5 = new SqlCommand(str5, con);                         //'"++"' //string
                SqlDataAdapter sda5 = new SqlDataAdapter(cmd5);
                DataTable dt5 = new DataTable();
                sda5.Fill(dt5);
                cmd5.ExecuteNonQuery();
                yes2.Text = dt5.Rows[0][0].ToString();

                string str6 = "select Count(response) from responsetable where response='yes' and qno=" + 3 + " group by qno ; ";                                                  //"++" //int
                SqlCommand cmd6 = new SqlCommand(str6, con);                         //'"++"' //string
                SqlDataAdapter sda6 = new SqlDataAdapter(cmd6);
                DataTable dt6 = new DataTable();
                sda6.Fill(dt6);
                cmd6.ExecuteNonQuery();
                yes3.Text = dt6.Rows[0][0].ToString();

                no1.Text = (int.Parse(total1.Text) - int.Parse(yes1.Text)).ToString();
                no2.Text = (int.Parse(total2.Text) - int.Parse(yes2.Text)).ToString();
                no3.Text = (int.Parse(total3.Text) - int.Parse(yes3.Text)).ToString();

               
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        
    }
}