using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class central : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnout_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void btnscore_Click(object sender, EventArgs e)
        {
                Response.Redirect("response.aspx");
            }
        }
    }
