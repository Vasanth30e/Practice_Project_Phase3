using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase3Section3._5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string log = "";
        protected void Page_PreInit(object sender, EventArgs e)
        {
            log += "page_preinit()<br>";
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            log += "page_init()<br>";
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            log += "page_initComplete()<br>";

        }
        protected override void OnPreLoad(EventArgs e)
        {
            log += "OnPreload()<br>";

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            log += "page_load()<br>";

            LblName.Text = log;
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            log += "page_laodComplete()<br>";
            LblName.Text = log;

        }
        protected override void OnPreRender(EventArgs e)
        {
            log += "page_prerender()<br>";
            LblName.Text = log;

        }
        protected override void OnSaveStateComplete(EventArgs e)
        {
            log += "OnSaveStateComplete()<br>";
            LblName.Text = log;


        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            // nothing will be displayed once page unloads
        }

    }
}