<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkDatabaseDDL.aspx.cs" Inherits="ProjectEchart.homeworkDatabaseDDL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请选择朝代<asp:DropDownList ID="ddlDynasty" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDynasty_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            该朝代的年号列表<asp:DropDownList ID="ddlNianhao" runat="server" AutoPostBack="True">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
