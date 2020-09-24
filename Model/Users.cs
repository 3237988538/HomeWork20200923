using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Users
	{
		/*
			Users_Id uniqueidentifier primary key,
			Users_Account varchar(255) not null,
			Users_Password varchar(255) not null,
			Users_NickName varchar(255) not null,
			Users_Photo varchar(255) ,
			Users_RolesId uniqueidentifier not null, --> 这个是外键,与身份表进行关联
			Users_DeleteId int default 1,
			Users_CreateTime datetime not null,
			Users_UpdateTime datetime not null
		*/
		public Guid Users_Id { get; set; }
		public string Users_Account { get; set; }
		public string Users_Password { get; set; }
		public string Users_NickName { get; set; }
		public string Users_Photo { get; set; }
		public Guid Users_RolesId { get; set; }
		public int Users_DeleteId { get; set; }
		public DateTime Users_CreateTime { get; set; }
		public DateTime Users_UpdateTime { get; set; }

	}
}
