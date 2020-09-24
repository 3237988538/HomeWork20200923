using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	class Roles
	{
		/*
			Roles_Id uniqueidentifier primary key,
			Roles_Title varchar(255) not null,
			Roles_DeleteId int default 1,
			Roles_CreateTime datetime not null,
			Roles_UpdateTime datetime not null
		 */
		public Guid Roles_Id { get; set; }
		public string Roles_Title { get; set; }
		public string Roles_DeleteId { get; set; }
		public DateTime Roles_CreateTime { get; set; }
		public DateTime Roles_UpdateTime { get; set; }
	}
}
