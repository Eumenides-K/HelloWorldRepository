using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class homeworkSqrt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double c = double.Parse(txtNum1.Text);
            double h = double.Parse(txtNum2.Text);
            double g = 1;
            if (c<1)
            {
                Response.Write("输入的数据不合法");
            }
            else
            {
                while(g*g<c)
                {
                    g = g + h;
                }
                double f = g - h;
                double a = g * g - c;
                double b = c - f * f;
                if (a > b)
                {
                    Response.Write("算术平方根为" + f + "精确值为" + Math.Sqrt(c));
                }
                else
                {
                    Response.Write("算术平方根为" + g + "精确值为" + Math.Sqrt(c));
                }
            }
        }
    }
}