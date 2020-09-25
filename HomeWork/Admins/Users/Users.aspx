<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shard/Layout.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="HomeWork.Admins.Users.WebForm1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

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
					<div class="row col-md-10 col-md-offset-1">
						<webdiyer:AspNetPager
							ID="AspNetPager1" runat="server" CssClass="pager" CurrentPageButtonClass="cpb"
							CustomInfoTextAlign="Left" HorizontalAlign="Right" PageIndexBoxType="TextBox"
							ShowCustomInfoSection="Left" ShowMoreButtons="False" ShowNavigationToolTip="true"
							Show PageIndexBox="Always"
							AlwaysShow="true" PageSize="2" ShowInputBox="Always" LayoutType="Table" OnPageChanging="AspNetPager1_PageChanging"
							FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页"
							PagingButtonSpacing="2px">
						</webdiyer:AspNetPager>
					</div>
				</div>
			</div>
		</div>
		<!-- END MAIN CONTENT -->
	</div>
	<!-- END MAIN -->
</asp:Content>
