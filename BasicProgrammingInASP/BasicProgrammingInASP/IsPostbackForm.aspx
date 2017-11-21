<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IsPostbackForm.aspx.cs" Inherits="BasicProgrammingInASP.IsPostbackForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="lbresult" runat="server"></asp:Label>
			<br />
			<asp:TextBox ID="txtsubject" runat="server"></asp:TextBox>
			<br />
			<asp:Button ID="btnEnter" runat="server" OnClick="btnEnter_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>
