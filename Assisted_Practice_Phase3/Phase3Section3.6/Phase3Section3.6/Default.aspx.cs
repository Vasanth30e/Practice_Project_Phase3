using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase3Section3._6
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://maps.google.com");
        }

        protected void FileUpload1_Load(object sender, EventArgs e)
        {
        }

        private void upload()
        {

        }

    }
}