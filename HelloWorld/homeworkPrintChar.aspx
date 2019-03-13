<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkPrintChar.aspx.cs" Inherits="HelloWorld.homeworkPrintChar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="width: 102px" Text="输出图形" />
    </form>
</body>
</html>
