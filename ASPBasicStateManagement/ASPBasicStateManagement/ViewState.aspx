<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="ASPBasicStateManagement.ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Button ID="btnCount" runat="server" OnClick="btnCount_Click" Text="Count Up" />
			<br />
			<br />
			<asp:Label ID="lbResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
