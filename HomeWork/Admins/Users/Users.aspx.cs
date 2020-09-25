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
			var list = user.GetAll();
			PagedDataSource pds = new PagedDataSource();
			pds.DataSource = list;
			pds.AllowPaging = true;
			pds.CurrentPageIndex = AspNetPager1.PageSize - 1;
			pds.PageSize = AspNetPager1.PageSize;
			AspNetPager1.RecordCount = list.Count;
			this.Repeater1.DataSource = pds;
			this.Repeater1.DataBind();
		}
		public void Bind(string nickname)
		{

			var list = user.GetRolesByNickName("");

			PagedDataSource pds = new PagedDataSource();
			pds.DataSource = list;
			pds.AllowPaging = true;
			pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
			pds.PageSize = AspNetPager1.PageSize;
			AspNetPager1.RecordCount = list.Count;

			this.Repeater1.DataSource = pds;
			this.Repeater1.DataBind();
		}

		protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
		{

			AspNetPager1.CurrentPageIndex = e.NewPageIndex;
			Bind("");
		}
	}
}