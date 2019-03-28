using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQL;
using System.Data.SqlClient;

namespace DataBase
{
    public partial class homeworkAltname : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = txt.Text;
            string result = "";
            string[] altname= { };
            if (name.Length<1)
            {
                Response.Write("请输入一个人名！");
                return;
            }
            string sql = string.Format("select c_alt_name_chn from ALTNAME_DATA where c_personid in (select c_personid from BIOG_MAIN where c_name_chn='{0}')", name);
            SQLHelper sh = new SQLHelper();
            SqlDataReader sdr;
            string real = "";
            try
            {
                sh.RunSQL(sql, out sdr);
                if (sdr.Read())
                {
                    Response.Write("TA的曾用名为：");
                    do
                    {
                        result = string.Format("{0}&nbsp", sdr["c_alt_name_chn"].ToString());
                        Response.Write(result);
                    }
                    while (sdr.Read());
                }
                else
                {
                    result = "没有找到记录";
                    Response.Write(result);
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Response.Write(result);
            }
           finally
            {
                sh.Close();
            }

        }
    }
}