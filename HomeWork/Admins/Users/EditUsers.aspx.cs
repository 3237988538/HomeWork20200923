using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork.Admins.Users
{
	public partial class EditUsers : System.Web.UI.Page
	{
		UsersService user = new UsersService();
		Model.Users model = null;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
				return;
			var model = user.GetRolesById(Guid.Parse(Request.Params["action"]));
			Account.Text = model.Users_Account;
			NickName.Text = model.Users_NickName;
			Photo.Text = model.Users_Photo;
			Password.Text = model.Users_Password;
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string action = Request.Params["action"];
			var result = user.EditRoles(new Model.Users()
			{
				Users_Id = Guid.Parse(action),
				Users_CreateTime = model.Users_CreateTime,
				Users_UpdateTime = DateTime.Now,
				Users_Account = Account.Text,
				Users_Password = Password.Text,
				Users_Photo = Photo.Text,
				Users_DeleteId = model.Users_DeleteId,
				Users_NickName = NickName.Text,
				Users_RolesId = model.Users_RolesId
			});
			Response.Write("<script>alert(" + result + ")</script>");
		}
	}
}