using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class homeworkPrintChar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double maxLineno = double.Parse(TextBox1.Text);
            int lineno, i = 0;
            string var="IGNB";
            if (maxLineno > 26|| maxLineno<1)
            {
                Response.Write("输入的行数不合法");
            }
            else
            { for (lineno = 1; lineno <= maxLineno; lineno++)
                {
                    for (i = 0; i < maxLineno - lineno; i++)
                    {
                        Response.Write("&nbsp;&nbsp;");
                    }
                    for (i = 0; i < 2 * lineno - 1; i++)
                    {
                        int a = lineno + 64;
                        var = ((char)a).ToString();
                        Response.Write(var);
                    }
                    Response.Write("</br>");
                }
                }
        }
    }
}