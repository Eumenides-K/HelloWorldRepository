using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common.AITools.Tvbboy;

namespace ProjectAlgorithm
{
    public partial class HomeworkLinearRegression : System.Web.UI.Page
    {
        public void LinearRegression(Point[] array)
        {
            if (array.Length < 2)
            {
                Response.Write("点的数量小于2，无法进行线性回归！");
                return;
            }
            double averagex = 0, averagey = 0;
            foreach (Point p in array)
            {
                averagex += p.X;
                averagey += p.Y;
            }
            averagex = averagex / array.Length;
            averagey = averagey / array.Length;
            double numerator = 0;
            double denomerator = 0;
            foreach (Point p in array)
            {
                numerator += (p.X - averagex) * (p.Y - averagey);
                denomerator += (p.X - averagex) * (p.X - averagex);
            }
            double RCB = numerator / denomerator;
            double RCA = averagey - RCB * averagex;
            Response.Write("回归系数A:" + RCA.ToString("0.0000")+"</br>");
            Response.Write("回归系数b:" + RCB.ToString("0.0000") + "</br>");
            Response.Write(string.Format("线性回归方程为：y={0}+{1}*x", RCA.ToString("0.0000"), RCB.ToString("0.0000")));
        }
        public void MultiRegression(Point[] array)
        {
            if (array.Length < 2)
            {
                Response.Write("点的数量小于2，无法进行回归！");
                return;
            }
            double[] xishu = ClassLeastSquares.MultiLine(array, 2);
            string expr = "";
            for (int i = 0; i < xishu.Length; i++)
            {
                expr += xishu[i].ToString() + "*x^" + i + "+";
                expr = expr.Substring(0, expr.Length - 1);
            }
            Response.Write("回归二次方程为：y=" + expr);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Point[] array = new Point[11];
            array[0] = new Point(2006, 131448);
            array[1] = new Point(2007,132129);
            array[2] = new Point(2008,132802);
            array[3] = new Point(2009, 133450);
            array[4] = new Point(2010, 134091);
            array[5] = new Point(2011, 134735);
            array[6] = new Point(2012, 135404);
            array[7] = new Point(2013, 136072);
            array[8] = new Point(2014, 136782);
            array[9] = new Point(2015, 137462);
            array[10] = new Point(2016, 138271);//2006-2016十一年中国年末总人口数（单位：万人）（ 数据来源：http://data.stats.gov.cn/easyquery.htm?cn=C01 ），测试数据——2018年：139538；2017年：139008。线性回归方程为：y=-1217044.7636+672.2182*x；回归二次方程为：y = 16740988.9997907 * x ^ 0 - 17187.6308177529 * x ^ 1+4.44053928389323 * x ^ 2。经检验，线性回归方程更能准确预测数据。
            LinearRegression(array);
            Response.Write("</br></br>");
            MultiRegression(array);
            Response.Write("</br>");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(TextBox1.Text);
                double b = a * 672.2182 - 1217044.7636;
                if (a < 1990 || a > 2030)
                {
                    Response.Write("<script language='javascript'>alert('输入数据不正确')</script>");
                }
                else
                {
                    Response.Write("预计" + a + "年年末总人口数为" + b + "万人。");
                }
            }
            catch 
            {
                Response.Write("<script language='javascript'>alert('输入数据不正确')</script>");
            }
            }
    }
}