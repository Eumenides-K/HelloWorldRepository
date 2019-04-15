using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQL;
using System.Data.SqlClient;
using System.Data;

namespace ProjectEchart
{
    public partial class homeworkDatabaseDDL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SQLHelper sh = new SQLHelper();
                string sql = "select c_dy,c_dynasty_chn from NIAN_HAO where c_dynasty_chn is not null and c_dynasty_chn <> '未詳' group by c_dynasty_chn,c_dy order by c_dy";
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                try
                {
                    sh.RunSQL(sql, ref ds);
                    dt = ds.Tables[0];
                    ddlDynasty.DataTextField = "c_dynasty_chn";
                    ddlDynasty.DataValueField = "c_dy";
                    ddlDynasty.DataSource = dt;
                    ddlDynasty.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    sh.Close();
                }
            }
        }

        protected void ddlDynasty_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlNianhao.Items.Clear();
            SQLHelper sh = new SQLHelper();
            string sq2 = string.Format("select c_nianhao_id,c_nianhao_chn from NIAN_HAO where c_dy={0} order by c_nianhao_id", ddlDynasty.SelectedItem.Value);
            DataTable dt1 = new DataTable();
            DataSet ds1 = new DataSet();
            try
            {
                sh.RunSQL(sq2, ref ds1);
                if (ds1.Tables[0] != null)
                {
                    dt1 = ds1.Tables[0];
                    if (dt1.Rows.Count > 0)
                    {
                        ddlNianhao.DataTextField = "c_nianhao_chn";
                        ddlNianhao.DataValueField = "c_nianhao_id";
                        ddlNianhao.DataSource = dt1;
                        ddlNianhao.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                sh.Close();
            }
        }
    }
}