using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class Email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = TextBox1.Text;//ToString为什么不行？
            string[] email_arr = email.Split('@');
            if (email_arr.Length != 2)
            {
                Response.Write("电子邮件格式不正确");
            }

            else
            {
                string[] email_ym = email.Split('.');
                int i = email_ym.Length;
                int m = i - 1;
                string ym = email_ym[m];
                Response.Write("电子邮件格式正确，顶级域名为" + ym);
            }

        }
    }
}