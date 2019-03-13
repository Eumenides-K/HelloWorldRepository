using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class _10_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int multiple = 1;

            for (int i = 10; i >= 1; i = i - 1)

            {

                multiple = multiple * i;

            }

            Response.Write(multiple.ToString());

        }
    }
}