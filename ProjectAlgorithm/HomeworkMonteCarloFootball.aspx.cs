using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAlgorithm
{
    public partial class HomeworkMonteCarloFootball : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Pn;
            string Pi;
            string Pa;
            int nums = 100000;
            Random rd = new Random();
            double Nn = 0;
            double Ni = 0;
            double Na = 0;
            double x,y;
            for (int i=0;i<=nums;i++)
            {
                x = rd.NextDouble() * 3 + 0;
                y = rd.NextDouble() * 3 + 0;
                if(y>1)
                {
                    Nn++;
                }
                if(y<1&&x>1)
                {
                    Na++;
                }
                if(y<1&&x<1)
                {
                    Na = Na + 0.5;
                    Ni = Ni + 0.5;
                }
            }
            Pn = (Nn / nums * 100).ToString() + "%";
            Pi = (Ni / nums * 100).ToString() + "%";
            Pa = (Na / nums * 100).ToString() + "%";
            Response.Write("尼日尼亚出线概率为：" + Pn + "</br>冰岛出线概率为：" + Pi + "</br>阿根廷出线概率为：" + Pa);
        }
    }
}