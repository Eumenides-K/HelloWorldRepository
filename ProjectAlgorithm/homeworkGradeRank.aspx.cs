using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common.AITools.Tvbboy;

namespace ProjectAlgorithm
{
    public partial class homeworkGradeRank : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(TextBox1.Text);
                float z = (x - 86.07143F) / 6.198667F;
                float p =ClassStatistics.selfCaculate(z);
                float a= (1-p) * 100;
                Response.Write("排名大概是前"+a+"%");
            }
            catch (Exception ex)
            {
                Response.Write("输入内容有误！"+"</br>"+ex);
            }
        }
    }
}