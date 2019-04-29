using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAlgorithm
{
    public partial class Evaluation_e : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double x, y;
            double p;
            double n=0;
            double Evaluation_e;
            int nums = 999999;
            Random rd = new Random();
            for (int i=0;i<=nums;i++)
            {
                x = rd.NextDouble() * 1 + 1;
                y = rd.NextDouble() * 1 + 0;
                if(1/x>y)
                {
                    n++;
                }
            }
            p = n / nums;
            Evaluation_e = Math.Pow(2, 1/p);
            Response.Write("自然对数e约为：" + Evaluation_e);
        }
    }
}