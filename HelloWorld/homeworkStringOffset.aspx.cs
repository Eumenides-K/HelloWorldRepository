using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class homeworkStringOffset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string var = TextBox1.Text;
            double n = double.Parse(TextBox2.Text);
            if (n > 26 || n < 1)
            {
                Response.Write("输入的右移位数不合法");
            }
            else
            {
                foreach (char c in var)
                {
                    char d = c;
                    if (Convert.ToInt32(c) >= 65 && Convert.ToInt32(c) <= 90)
                    {
                        double x = Convert.ToInt32(c) + n;
                        double z = 0;
                        if (x <= 90)
                        {
                            z = x;
                        }
                        if (x > 90)
                        {
                            z = x - 26;
                        }
                        d = (char)z;
                        Response.Write(d);
                    }
                    if (Convert.ToInt32(c) >= 97 && Convert.ToInt32(c) <= 122)
                    {
                        double x = Convert.ToInt32(c) + n;
                        double z = 0;
                        if (x <= 122)
                        {
                            z = x;
                        }
                        if (x > 122)
                        {
                            z = x - 26;
                        }
                        d = (char)z;
                        Response.Write(d);
                    }
                    if (Convert.ToInt32(c) >= 48 && Convert.ToInt32(c) <= 57)
                    {
                        d = c;
                        Response.Write(d);
                    }
                }
            }
        }
    }
}
        
  
