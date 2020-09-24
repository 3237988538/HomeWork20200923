<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shard/Layout.Master" AutoEventWireup="true" CodeBehind="AddUsers.aspx.cs" Inherits="HomeWork.Admins.Users.AddUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<!-- MAIN -->
	<div class="main">
		<!-- MAIN CONTENT -->
		<div class="main-content">
			<div class="container-fluid">
				<h3 class="page-title">Elements</h3>
				<div class="form-horizontal">
					<div class="">
						<!-- INPUT GROUPS -->
						<div class="panel">
							<div class="panel-heading">
								<h3 class="panel-title">Add Users</h3>
							</div>
							<div class="panel-body">
								
								<div class="input-group">
									<span class="input-group-addon"><i class="fa fa-user"></i></span>
									<asp:TextBox ID="Account" runat="server" CssClass="form-control"></asp:TextBox>
								</div>
								<br>
								<div class="input-group">
									<span class="input-group-addon"><i class="fa fa-user"></i></span>
									<asp:TextBox ID="Password" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
								</div>
								<br>
								<div class="input-group">
									<span class="input-group-addon"><i class="fa fa-user"></i></span>
									<asp:TextBox ID="NickName" runat="server" CssClass="form-control"></asp:TextBox>
								</div>
								<br>
								<div class="input-group">
									<span class="input-group-addon"><i class="fa fa-user"></i></span>
									<asp:TextBox ID="Photo" runat="server" CssClass="form-control"></asp:TextBox>
								</div>
								<br>
								<asp:Button ID="Button1" runat="server" Text="Sign In" OnClick="Button1_Click" CssClass="btn btn-success center-block fa fa-check-circle"/>
								<br />
							</div>
						</div>
						<!-- END INPUT GROUPS -->
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- END INPUT GROUPS -->
</asp:Content>
