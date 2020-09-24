using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork.Admins.Users
{
	public partial class DeleteUsers : System.Web.UI.Page
	{
		UsersService user = new UsersService();
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
				return;
			string action = Request.Params["action"];
			if(user.PutTrash(Guid.Parse(action)) > 0){
				Response.Write("<script>alert('Success')</script>");
			}else{

				Response.Write("<script>alert('Error')</script>");
			}
		}
	}
}