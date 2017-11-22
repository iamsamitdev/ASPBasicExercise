<%@ Page Title="Customer" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="customer_report.aspx.cs" Inherits="DatabaseConnect.customer_report" %>

<asp:Content  ContentPlaceHolderID="Content" runat="server">
	<form id="form1" runat="server">
	<div class="jumbotron">
		<div class="container">
			<h1>Customer Report Data</h1>
		</div>
	</div>

	<div class="container">
		
		<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:northwindConnectionString %>" SelectCommand="SELECT * FROM [Customers]"></asp:SqlDataSource>
		
		<div class="table-responsive">
			<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="SqlDataSource1">
				<Columns>
					<asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
					<asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
					<asp:BoundField DataField="ContactName" HeaderText="ContactName" SortExpression="ContactName" />
					<asp:BoundField DataField="ContactTitle" HeaderText="ContactTitle" SortExpression="ContactTitle" />
					<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
					<asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
				</Columns>
			</asp:GridView>
		</div>
	</div>
	</form>
</asp:Content>
