using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class tryCatch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string x=txtNum.Text;
            try
            {
                if (double.Parse(x) < 0)
                    Response.Write(x + "是负数");
                else
                    Response.Write(x + "不是负数");
            }
            catch
            {
                Response.Write(x + "不是负数");
            }
        }
    }
}