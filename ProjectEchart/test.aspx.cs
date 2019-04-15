﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQL;

namespace ProjectEchart
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SQLHelper sh = new SQLHelper();
            string sql = "select count(*) from BIOG_MAIN";
            try
            {
                sh.RunSQL(sql);
                Response.Write("数据库连接成功");
            }
            catch (Exception ex)
            {
                Response.Write("数据库连接失败，原因：" + ex.Message);
            }
            finally
            {
                sh.Close();
            }
        }
    }
}