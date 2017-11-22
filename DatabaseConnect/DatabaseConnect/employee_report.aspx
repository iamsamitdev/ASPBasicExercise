<%@ Page Title="Employee" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="employee_report.aspx.cs" Inherits="DatabaseConnect.employee_report" %>
<asp:Content  ContentPlaceHolderID="Content" runat="server">
	<form id="form1" runat="server">
	<div class="jumbotron">
		<div class="container">
			<h1>Employee Report Data</h1>
		</div>
	</div>

	<div class="container">

		<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:northwindConnectionString %>" SelectCommand="SELECT [EmployeeID], [LastName], [FirstName], [Title], [TitleOfCourtesy], [BirthDate], [HireDate], [City] FROM [Employees]"></asp:SqlDataSource>
		<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeID" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True">
			<Columns>
				<asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" InsertVisible="False" ReadOnly="True" SortExpression="EmployeeID" />
				<asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
				<asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
				<asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
				<asp:BoundField DataField="TitleOfCourtesy" HeaderText="TitleOfCourtesy" SortExpression="TitleOfCourtesy" />
				<asp:BoundField DataField="BirthDate" HeaderText="BirthDate" SortExpression="BirthDate" />
				<asp:BoundField DataField="HireDate" HeaderText="HireDate" SortExpression="HireDate" />
				<asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
			</Columns>
		</asp:GridView>
		<br />

	</div>
		</form>
</asp:Content>