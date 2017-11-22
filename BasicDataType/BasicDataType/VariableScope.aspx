<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VariableScope.aspx.cs" Inherits="BasicDataType.VariableScope" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Button ID="btn_sayHello" runat="server" BackColor="#FF3300" Font-Size="24px" ForeColor="White" Height="44px" OnClick="btn_sayHello_Click" Text="Say Hello" Width="186px" />
			<br />
			<asp:Label ID="lbResult" runat="server" Font-Size="24px"></asp:Label>
        </div>
    </form>
</body>
</html>
