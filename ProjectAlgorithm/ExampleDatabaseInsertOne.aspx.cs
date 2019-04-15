using SQL;
using System;
using System.Data.SqlClient;
namespace ProjectAlgorithm
{
    /// <summary>
    /// 数据库如何读取单个记录的内容
    /// </summary>
    public partial class ExampleDatabaseInsertOne : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text;
            string studentName = txtStudentName.Text;
            int Gender = 0;
            if (ridMale.Checked)
                Gender = 1;
            if (ridFemale.Checked)
                Gender = 0;
            string Major = ddlMajor.SelectedValue;
            DateTime Birthday = Calendar1.SelectedDate;
            string sql1 = string.Format("insert into tblstudents (studentNo,studentName,gender,Major,Birthday)values('{0}','{1}',{2},'{3}','{4}')", studentNo, studentName, Gender, Major, Birthday);
            SQLHelper sh = new SQLHelper();
            string sql2 = string.Format("select count (*) from tblstudents where studentNo='{0}'", studentNo);//!!!字符串和日期｛0｝要加''
            int x = sh.RunSelectSQLToScalar(sql2);
            try
            {
                if (x == 0)
                {
                    try
                    {
                        //返回影响的行数，所以插入成功会返回1
                        int ret = sh.RunSQL(sql1);
                        if (ret > 0)
                        {
                            Response.Write("插入成功");
                        }
                        else
                        {
                            Response.Write("插入失败");
                        }

                    }
                    catch (Exception ex)
                    {
                        Response.Write("SQL语句:" + sql1 + "<br>");
                        Response.Write("插入异常:" + ex.Message);
                    }
                    finally
                    {
                        sh.Close();
                    }
                }
                else
                {
                    Response.Write("该生已存在");
                }
            }
            catch(Exception ex)
            {
                Response.Write("SQL语句:" + sql2 + "<br>");
                Response.Write("插入异常:" + ex.Message);
            }
         finally
            {
                sh.Close();
            }
    }
    }
}