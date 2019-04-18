<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeworkRecursionOffspring.aspx.cs" Inherits="ProjectAlgorithm.____" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输历史人物名称<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查看他的子嗣" />
    </form>
</body>
</html>
