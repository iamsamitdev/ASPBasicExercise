<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VariableScope.aspx.cs" Inherits="BasicProgrammingInASP.VariableScope" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Button ID="btn_showdata" runat="server" Font-Size="20pt" Height="48px" OnClick="btn_showdata_Click" Text="Show Data" Width="178px" />
			<br />
			<br />
			<asp:Label ID="lbresult" runat="server" Font-Size="24pt" Font-Strikeout="False"></asp:Label>
        </div>
    </form>
</body>
</html>
