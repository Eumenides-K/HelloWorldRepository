using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class homeworkID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string a = "";
            a = txtNum.Text;
            string id = "";
            id = a.ToLower();
            string[] last = { "1", "0", "x", "9", "8", "7", "6", "5", "4", "3", "2" };
            int[] xishu = new int[17] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
            string id0 = "";
            id0 = id.Substring(0, 17);
            string year = id.Substring(6, 4);
            string month = id.Substring(10, 2);
            string date = id.Substring(12, 2);
            string sex;
            string x = "x";
            int gender = int.Parse(id.Substring(16, 1));
            if (gender % 2 == 0)
            {
                sex = "女";
            }
            else
            {
                sex = "男";
            }
            if (id.Length != 18)
            {
                Response.Write("输入的身份证号码不合法");
            }
            else
            {
                for (int i = 0; i <=16; i++)
                {
                    if (char.IsNumber(id, i)&& (char.IsNumber(id, 17) || id.Substring(17, 1).Equals(x)))
                    {
                        int sum = 0;
                        for (int j = 0; j <=16; j++)
                        {
                            int idx = int.Parse(id.Substring(j, 1));
                            int m = idx * xishu[j];
                            sum += m;
                        }
                        int y = sum % 11;
                        if (last[y] == id.Substring(17, 1))
                        {
                            Response.Write("出生日期为" + year + "年" + month + "月" + date + "日" + "，性别为" + sex);
                        }
                        else
                        {
                            Response.Write("输入的身份证号码不合法");
                        }
                        break;
                    }
                    else
                    {
                        Response.Write("输入的身份证号码不合法");
                        break;
                    }

                }
            }

        }
    }
}

