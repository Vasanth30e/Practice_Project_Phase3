using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase3Section3._10
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["submits"] == null)
            {
                Application["submits"] = 0;
            }

            if (Page.IsPostBack)
            {
                string capture = "Name=" + txtname.Text + "<Br>Address=" + txtAddress.Text + "<Br>Class=" + txtClass.Text +
                        "<br>Email=" + txtEmail.Text + "<hr>";
                lblLog.Text += capture;


            }
            else
            {
                if (Request.QueryString["name"] != null)
                {
                    txtname.Text = Request.QueryString["name"];
                    Response.Write("Querystring received");
                }
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int submits = (int)Application["submits"];
            submits++;
            Application["submits"] = submits;
            lblCount.Text = submits.ToString() + " submits done";

        }
    }
}
