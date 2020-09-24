<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shard/Layout.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="HomeWork.Admins.Users.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<!-- MAIN -->
	<div class="main">
		<!-- MAIN CONTENT -->
		<div class="main-content">
			<div class="container-fluid">
				<div class="panel panel-profile">
					<table class="table table-bordered table-hover">
						<thead>
							<tr>
								<td>账号</td>
								<td>昵称</td>
								<td>电话</td>
								<td>站点</td>
							</tr>
						</thead>
						<tbody>
							<asp:Repeater ID="Repeater1" runat="server">
								<ItemTemplate>
									<tr>
										<td><%#Container.ItemIndex+1 %></td>
										<td><%#Eval("Users_Account") %></td>
										<!--账号-->
										<td><%#Eval("Users_NickName") %></td>
										<!--名称-->
										<td><%#Eval("Users_Photo") %></td>
										<!--电话-->
										<td><%#Eval("Users_CreateTime") %></td>
										<!--站点-->
										<td><a href='EditUsers.aspx?action=<%#Eval("Users_Id") %>'>修改</a></td>
										<td><a href="#">删除</a></td>
									</tr>
								</ItemTemplate>
							</asp:Repeater>
						</tbody>
					</table>
				</div>
			</div>
		</div>
		<!-- END MAIN CONTENT -->
	</div>
	<!-- END MAIN -->
</asp:Content>
