
namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;

    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Data.SqlClient;
    using System.Web.Configuration;
    using System.Data;


    // TODO: Create methods containing your application logic.
    [EnableClientAccess()]
    public class datastore : DomainService
    {
        static String susername, spassword;

        public static void useradd(String a)
        {
            susername = a;
        }
        public static void passadd(String a)
        {
            spassword = a;
        }

        public static int getid()
        {
            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            int id = -1;
            try
            {
                con.Open();
                string str = "select id from loginstable where username='" + susername + "' and password='" + spassword + "' ";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();
                id = (int)dt.Rows[0][0];
                Console.WriteLine(id);


            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return id;
        }
        public static string getname()
        {
            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            string strname = "";
            try
            {
                con.Open();
                string str = "select name from registertable where username='" + susername + "' and password='" + spassword + "' ";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();
                strname = dt.Rows[0][0].ToString();
                Console.WriteLine(strname);


            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return strname;
        }
        
    }
}




