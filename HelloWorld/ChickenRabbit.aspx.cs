using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class ChickenRabbit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool zhaodaodaan = false;
            for (int i = 0; i <= 35; i=i+1)
            {
                for (int j = 0; j <= 23; j=j+1)
                {

                    if (i + j == 35 && 2 * i + 4 * j == 94)

                        Response.Write( i + "只鸡" + j + "只兔子");
                    zhaodaodaan = true;
                    break;
                }
                if (zhaodaodaan)//等价于if(zhaodaodaan==true)
                    break;
            }
            

        }
    }
}