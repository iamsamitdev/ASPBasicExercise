<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionState.aspx.cs" Inherits="ASPBasicStateManagement.SessionState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	Fullname<br />
			<asp:TextBox ID="txtFullname" runat="server" Height="22px" Width="128px"></asp:TextBox>
			<br />
			<asp:Button ID="btnNoSession" runat="server" OnClick="btnNoSession_Click" Text="No Session" />
			<asp:Button ID="btnKeepSession" runat="server" OnClick="btnKeepSession_Click" Text="Keep to Session" />
			<asp:Button ID="btnRemoveSession" runat="server" OnClick="btnRemoveSession_Click" Text="Remove Session" />
			<br />
			From Textbox : <asp:Label ID="lbTextbox" runat="server"></asp:Label>
			<br />
			From Session :
			<asp:Label ID="lbResult" runat="server"></asp:Label>
			<br />
			<asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/ShowSessionData.aspx">Show Session Data</asp:LinkButton>
        </div>
    </form>
</body>
</html>
