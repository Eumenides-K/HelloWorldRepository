using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAlgorithm
{
    public partial class ExampleRangData : System.Web.UI.Page
    {
        protected double[] RangeDataShangzhengzhishu = { 1.80, 1.12, 0.88, 15.57, 0.14, -4.40, 1.92, 1.10, -1.09, -1.20, 1.04, 2.47, -0.18, -0.01,0.35,0.09,-1.97,-1.51,0.86,-0.92,3.20};
        protected double[] RangeDataGuizhoumaotai= {4.54,-0.94,-0.27,-1.51,-2.53,-1.48,2.85,-1.78,1.21,3.18,-0.09,4.22,-2.16,0.02,-0.89,1.05,-2.32,-0.34,2.01,2.32,5.85 };
        protected double calcMean(double [] aimtep)
        {
            double sum = 0.0;
            for (int i=0;i<aimtep.Length;i++)
            {
                sum += aimtep[i]; 
            }
            double mean = sum / aimtep.Length;
            return mean;
        }
        protected double calcVariance(double[] aimtep)
        {
            double RangeDataMean = calcMean(aimtep);
            double tmp = 0.0;
            for (int i = 0;i < aimtep.Length;i++ )
            {
                tmp += (aimtep[i] - RangeDataMean) * (aimtep[i] - RangeDataMean);
            }
            double RangeDataVariance = tmp / aimtep.Length;
            return RangeDataVariance;
        }
        protected void AnalyzeData(double[] aimtep)
        {
            Response.Write("该数组中数据为：</br>");
            for(int i=0;i<aimtep.Length;i++)
            {
                int x = i + 1;
                Response.Write(x + ")&nbsp;" + aimtep[i] + "</br>");
            }
            Response.Write("均值为：" + calcMean(aimtep) + "</br>方差为:" + calcVariance(aimtep) + "</br>标准差为：" + Math.Sqrt(calcVariance(aimtep)));
        }
        protected string calCov(double[] aimtep1,double [] aimtep2)
        {
            if (aimtep1.Length == aimtep2.Length)
            {
                double pro = 0.0;
                for (int i = 0; i < aimtep1.Length; i++)
                {
                    pro += (aimtep1[i] - calcMean(aimtep1)) * (aimtep2[i] - calcMean(aimtep2));
                }
                double cov = pro / aimtep1.Length;
                return cov.ToString();
            }
            else
            { return "两个数组长度不一致"; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string a;
                string ppccx;
                double ppcc;
                if (calCov(RangeDataGuizhoumaotai, RangeDataShangzhengzhishu) == "两个数组长度不一致")
                {
                    a = "&nbsp;";
                    ppccx = "&nbsp;";
                }
                else if (double.Parse(calCov(RangeDataGuizhoumaotai, RangeDataShangzhengzhishu)) > 0)
                {
                    a = "，涨跌一致";
                    ppcc = double.Parse(calCov(RangeDataGuizhoumaotai, RangeDataShangzhengzhishu)) / (Math.Sqrt(calcVariance(RangeDataGuizhoumaotai)) * Math.Sqrt(calcVariance(RangeDataShangzhengzhishu)));
                    ppccx = "相关系数为：" + ppcc.ToString();
                }
                else
                {
                    a = "，涨跌不一致";
                    ppcc = double.Parse(calCov(RangeDataGuizhoumaotai, RangeDataShangzhengzhishu)) / (Math.Sqrt(calcVariance(RangeDataGuizhoumaotai)) * Math.Sqrt(calcVariance(RangeDataShangzhengzhishu)));
                    ppccx = "相关系数为：" + ppcc.ToString();
                }
                Response.Write("贵州茅台三月涨跌幅数据如下</br>");
                AnalyzeData(RangeDataGuizhoumaotai);
                Response.Write("</br></br></br></br>");
                Response.Write("上证指数三月涨跌幅数据如下</br>");
                AnalyzeData(RangeDataShangzhengzhishu);
                Response.Write("</br></br></br></br>两组数据协方差为:" + calCov(RangeDataGuizhoumaotai, RangeDataShangzhengzhishu) + ppccx + a);
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}