using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common.AITools.Tvbboy;

namespace ProjectAlgorithm
{
    public partial class ExampleLinearRegression : System.Web.UI.Page
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
            Response.Write("回归系数A:" + RCA.ToString("0.0000") + "</br>");
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
            double[] xishu = ClassLeastSquares.MultiLine(array, 2);//ClassLeastSquares.MultiLine(array,n)表示将array中的所有数据点拟合成n次回归方程。
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
            Point[] array = new Point[6];
            array[0] = new Point(61,176);
            array[1] = new Point(2, 15);
            array[2] = new Point(0, 4);
            array[3] = new Point(-1, -2);
            array[4] = new Point(10, 63);
            array[5] = new Point(4, 29);
            LinearRegression(array);
            MultiRegression(array);
        }
    }
}