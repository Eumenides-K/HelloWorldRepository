using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAlgorithm
{
    public partial class OutputRandom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int i = 0;
            int[] array = new int[100];
            while (i < 99)
            {
                int num = random.Next(1, 100);
                if (array.Contains(num) == false)
                {
                    array[i] = num;
                    i++;
                    Response.Write(i + ")&nbsp;" + num + "</br>");
                }
            }
        }
    }
}