<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkGetTriangularArea.aspx.cs" Inherits="HelloWorld.homeworkGetTriangularArea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输入三角形的第一条边<asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            <br />
        </div>
        <div>
            请输入三角形的第二条边<asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
        </div>
        <div>
            请输入三角形的第三条边<asp:TextBox ID="txtNum3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="求三角形面积" />
        </div>
    </form>
</body>
</html>
