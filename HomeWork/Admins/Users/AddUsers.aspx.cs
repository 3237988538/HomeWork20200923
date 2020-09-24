using BLL;
using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork.Admins.Users
{
	public partial class AddUsers : System.Web.UI.Page
	{
		UsersService user = new UsersService();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			var result = user.AddRoles(new Model.Users
			{
				Users_Id = Guid.NewGuid(),
				Users_CreateTime = DateTime.Now,
				Users_UpdateTime = DateTime.Now,
				Users_Account = Account.Text,
				Users_Password = Password.Text,
				Users_Photo = Photo.Text,
				Users_DeleteId = 1,
				Users_NickName = NickName.Text,
				Users_RolesId = Guid.NewGuid()
			});
			Response.Write("<script>alert(" + result + ")</script>");
		}
	}
}