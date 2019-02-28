using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class getMax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getMaxbtn_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double num3 = double.Parse(txtNum3.Text);
            if (num1 >= num2 && num1 >= num3)
            { Response.Write("最大值是" + num1); }
            else if (num2 >= num3)//此处不用再写“num2 >= num1 &&”，因为已经建立在num1不是最大值的情况下了
            { Response.Write("最大值是" + num2); }
            else
            { Response.Write("最大值是" + num3); }
        }
    }
}