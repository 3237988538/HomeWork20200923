using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork.Admins.Users
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		UsersService user = new UsersService();
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
				return;
			Repeater1.DataSource = user.GetAll();
			Repeater1.DataBind();
		}
	}
}