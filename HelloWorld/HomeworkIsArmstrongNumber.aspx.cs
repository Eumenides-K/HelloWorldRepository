using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class HomeworkIsArmstrongNumber : System.Web.UI.Page
    {
            public bool IsArmstrongNumber(int num)
            {
                int i, j, k, l, m,n,x;
                i = num / 100000;
                j = num % 100000 / 10000;
                k = num % 10000 / 1000;
                l = num % 1000 / 100;
                m = num % 100 / 10;
                n = num % 10;
                x = num.ToString().Length;
            if (Math.Pow(i,x)+ Math.Pow(j, x) + Math.Pow(k, x) + Math.Pow(l, x) + Math.Pow(m, x) + Math.Pow(n, x) == num)
                { return true; }
                else
                { return false; }
            }
            protected void Page_Load(object sender, EventArgs e)
            {
            int a = 100;
            while(a<=1000000)
            {
                a++;
                if (IsArmstrongNumber(a))
                    Response.Write(a + "&nbsp;&nbsp;");
            }
            }
        }
    }
