using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class var : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a=0;
            int b = 3;
            byte c = 6;
            char d = 'a';
            double e1 =a/b;//e1输出为3.0（先除再赋值）
            bool f;
            byte g = 61;
            byte h = 1;
            f=b<=4 && b>=3;//“=”优先级最低
            //f=(3=<b<=4)错误!
            e1 += a;//等效于e1=e1+a
            Response.Write(a/b+"</br>");//输出3，整数除以整数还是整数，数据类型不变
            Response.Write("<front color=red>"+b+"</front>"+c+g+d+h);
            //byte i =g + h;//g+h依然是byte
        }
    }
}