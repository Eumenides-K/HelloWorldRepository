<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkGradeRank.aspx.cs" Inherits="ProjectAlgorithm.homeworkGradeRank" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输入分数：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查询排名" />
    </form>
</body>
</html>
