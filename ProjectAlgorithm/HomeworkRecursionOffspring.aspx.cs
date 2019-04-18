using SQL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjectAlgorithm
{
    public partial class ____ : System.Web.UI.Page
    {
        DataTable dt;
        public void PrintOffspring(string eid)
        {
            string condition = string.Format("EPARENTID ='{0}'", eid);
            DataRow[] rows = dt.Select(condition);
            if (rows.Length > 0)
            {
                int num = rows.Length;
                int i = 0;
                while (i <= num - 1)
                {
                    Response.Write(rows[i]["ENAME"] + "</br>");
                    PrintOffspring(rows[i]["EID"].ToString());
                    i++;
                }
            }
            else
                return;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            SQLHelper sh = new SQLHelper();
            string a = string.Format("select count (*) from DynastyHanEmperor where ename ='{0}'", name);
            int n = sh.RunSelectSQLToScalar(a);
            if (n == 0)
            {
                Response.Write("该人名不存在，请重新输入！");
                sh.Close();
            }
            else
            {
                string sql = "select * from  DynastyHanEmperor order by EID";
                DataSet ds1 = new DataSet();
                sh.RunSQL(sql, ref ds1);
                dt = ds1.Tables[0];
                Response.Write("他的后代有:" + "</br>");
                string findout = string.Format("ENAME='{0}'", name);
                DataRow[] rows = dt.Select(findout);
                string id = rows[0]["EID"].ToString();
                PrintOffspring(id);
                sh.Close();
            }
        }
    }
}
