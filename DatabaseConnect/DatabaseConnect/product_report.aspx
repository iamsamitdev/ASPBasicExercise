<%@ Page Title="Product" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="product_report.aspx.cs" Inherits="DatabaseConnect.product_report" %>
<asp:Content  ContentPlaceHolderID="Content" runat="server">
	<form id="form1" runat="server">
		<asp:GridView ID="GridView1" runat="server" DataSourceID="LinqProducts">
		</asp:GridView>
		<asp:LinqDataSource ID="LinqProducts" runat="server" EntityTypeName="">
		</asp:LinqDataSource>
&nbsp;</form>
</asp:Content>
