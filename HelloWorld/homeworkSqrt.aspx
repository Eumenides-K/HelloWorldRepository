<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkSqrt.aspx.cs" Inherits="HelloWorld.homeworkSqrt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输入大于1的被开方数<asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            <br />
            请输入步进值<asp:TextBox ID="txtNum2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="开方" />
        </div>
    </form>
</body>
</html>
