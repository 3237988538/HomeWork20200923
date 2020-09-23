<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shard/Layout.Master" AutoEventWireup="true" CodeBehind="Roles_List.aspx.cs" Inherits="HomeWork.Admins.Roles.Roles_List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style>
		.mb-1{
			margin-bottom:10px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row mb-1" >
		<div class="col-md-10 col-md-offset-1">
			<div class="col-md-5">
				<input type="text" name="name" value="" class="form-control" />
			</div>
			<div class="col-md-4">
				<asp:Button Text="Go" CssClass="btn btn-primary" runat="server" />
				<asp:Button Text="Insert" CssClass="btn btn-success" runat="server" />
				<asp:Button Text="Delete" CssClass="btn btn-danger" runat="server" />
			</div>
		</div>
	</div>
	<div class="row">
		<div class="col-md-10 col-md-offset-1">
			<div class="panel">
				<div class="panel-heading">
					<h3 class="panel-title">权限表</h3>
				</div>
				<div class="panel-body">
					<table class="table table-bordered table-hover">
						<thead>
							<tr>
								<th>编号</th>
								<th>权限名称</th>
								<th>编辑</th>
								<th>删除</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td>1</td>
								<td>超级管理员</td>
								<td><a href="#">修改</a></td>
								<td><a href="#">删除</a></td>
							</tr>
						</tbody>
					</table>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
