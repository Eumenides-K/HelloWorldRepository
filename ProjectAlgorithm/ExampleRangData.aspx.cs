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
        protected double[] RangeData = { -15.1645, 1.4507, 110.2647, -13.0924, -8.91, -88.2692,10.4169,18.2015 };
        protected double[] RangeData2 = { -5.00023, 40.0743, 50.8714, -2.6428, 101.5868, 143.9459, -14.9925, 42.949 };
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
            Response.Write("均值为：" + calcMean(RangeData) + "</br>方差为:" + calcVariance(RangeData) + "</br>标准差为：" + Math.Sqrt(calcVariance(RangeData)));
        }
        protected string calCov(double[] aimtep1,double [] aimtep2)
        {
            string a = "两个数组长度不一致";
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
            { return a; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            AnalyzeData(RangeData);
            Response.Write("</br></br></br></br>");
            AnalyzeData(RangeData2);
            Response.Write("</br></br></br></br>两组数据协方差为:" + calCov(RangeData, RangeData2));
        }
    }
}