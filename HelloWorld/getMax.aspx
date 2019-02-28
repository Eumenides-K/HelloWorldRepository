<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getMax.aspx.cs" Inherits="HelloWorld.getMax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        请输入第一个数<asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
    
    </div>
        <p>
            请输入第二个数<asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
        </p>
        <p>
            请输入第三个数<asp:TextBox ID="txtNum3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="getMaxbtn" runat="server" OnClick="getMaxbtn_Click" Text="求最大值" />
        </p>
    </form>
</body>
</html>
