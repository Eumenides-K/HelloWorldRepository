<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkID.aspx.cs" Inherits="HelloWorld.homeworkID" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输入身份证号码<asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="验证" />
    </form>
</body>
</html>
