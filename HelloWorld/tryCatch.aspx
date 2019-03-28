<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tryCatch.aspx.cs" Inherits="HelloWorld.tryCatch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="判断负数" />
    
    </div>
    </form>
</body>
</html>
