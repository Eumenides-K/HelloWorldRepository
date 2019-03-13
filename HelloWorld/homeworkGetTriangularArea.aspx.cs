using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class homeworkGetTriangularArea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double num3 = double.Parse(txtNum3.Text);
            string a = "mm";
            string b = "gg";
            double p = (num1 + num2 + num3) / 2;
            double s = Math.Sqrt(p * (p - num1) * (p - num2) * (p - num3));
            if (num1 + num2 <= num3 || num1 + num3 <= num2 || num2 + num3 <= num1)
            { Response.Write("你输入的三条边不能构成一个三角形"); }
            else
            {
                if (num1 == num2 && num2 == num3)
                { a = "等边"; }
                else if (num1 == num2 || num1 == num3 || num2 == num3)
                { a = "等腰"; }
                else
                { a = "一般"; }
                if (num1 * num1 + num2 * num2 == num3 * num3 || num3 * num3 + num2 * num2 == num1 * num1 || num1 * num1 + num3 * num3 == num2 * num2)
                { b = "直角"; }
                else if (num1 * num1 + num2 * num2 > num3 * num3 || num3 * num3 + num2 * num2 > num1 * num1 || num1 * num1 + num3 * num3 > num2 * num2)
                { b = "锐角"; }
                else
                { b = "钝角"; }
                Response.Write("你输入的三条边组成了一个" + a + b + "三角形，它的面积是" + s);
            }




        }
    }
}