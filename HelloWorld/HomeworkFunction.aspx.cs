using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class HomeworkFunction : System.Web.UI.Page
    {
        private bool isLeapYear(int y)
        {
            if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
            { return true; }
            else
            { return false; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = 1949;
            while(a<=2018)
            {
                a++;
                if (isLeapYear(a) == true)
                {
                    Response.Write(a+"&nbsp;");
                }
            }

        }
        }
    }
