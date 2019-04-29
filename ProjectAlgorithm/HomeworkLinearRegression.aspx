<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeworkLinearRegression.aspx.cs" Inherits="ProjectAlgorithm.HomeworkLinearRegression" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输入年份（1990-2030）：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="预测该年年末总人口" />
        </div>
    </form>
</body>
</html>
