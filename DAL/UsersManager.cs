using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class UsersManager
	{
		public int AddUsers(Users user){
			string sql = "insert into Users(Users_Id,Users_Account,Users_Password,Users_NickName,Users_Photo,Users_RolesId,Users_DeleteId,Users_CreateTime,Users_UpdateTime) " +
							"values(@Users_Id,@Users_Account,@Users_Password,@NickName,@Photo,@Users_RolesId,@Users_DeleteId,@Users_CraeteTiem,@Users_UpdateTime)";
			SqlParameter[] param = {
				new SqlParameter("@Users_Id",user.Users_Id),
				new SqlParameter("@Users_Account",user.Users_Account),
				new SqlParameter("@Users_Password",user.Users_Password),
				new SqlParameter("@NickName",user.Users_NickName),
				new SqlParameter("@Photo",user.Users_Photo),
				new SqlParameter("@Users_RolesId",user.Users_RolesId),
				new SqlParameter("@Users_DeleteId",user.Users_DeleteId),
				new SqlParameter("@Users_CraeteTiem",user.Users_CreateTime),
				new SqlParameter("@Users_UpdateTime",user.Users_UpdateTime)
			};
			return SqlHelper.ExecuteNonQuery(sql, param);
		}
		public int EditUsers(Users user)
		{
			string sql = "update Users set  Users_Account = @Users_Account,Users_Password=@Users_Password,NickName=@NickName,"+
							"Photo=@Photo,Users_RolesId=@Users_RolesId,Users_DeleteId=@Users_DeleteId,Users_CraeteTiem=@Users_CraeteTiem,Users_UpdateTime=@Users_UpdateTime " +
							"where Users_Id = @Users_Id";
			SqlParameter[] param = {
				new SqlParameter("@Users_Account",user.Users_Account),
				new SqlParameter("@Users_Password",user.Users_Password),
				new SqlParameter("@NickName",user.Users_NickName),
				new SqlParameter("@Photo",user.Users_Photo),
				new SqlParameter("@Users_RolesId",user.Users_RolesId),
				new SqlParameter("@Users_DeleteId",user.Users_DeleteId),
				new SqlParameter("@Users_CraeteTiem",user.Users_CreateTime),
				new SqlParameter("@Users_UpdateTime",user.Users_UpdateTime),
				new SqlParameter("@Users_Id",user.Users_Id)
			};

			return SqlHelper.ExecuteNonQuery(sql, param);
		}

		public int PutTrash(Guid Id){
			string sql = "update Users set Users_DeleteId = 0 where Users_Id = @Users_Id";
			SqlParameter[] param = {
				new SqlParameter("@Users_Id",Id)
			};
			return SqlHelper.ExecuteNonQuery(sql, param);
		}

		public int RemoveUsers(Guid id){
			string sql = "delete from Users where Users_Id = @Users_Id";
			SqlParameter[] param = {
				new SqlParameter("@Users_Id",id)
			};
			return SqlHelper.ExecuteNonQuery(sql, param);
		}

		/// <summary>
		/// 批量放入回收站
		/// </summary>
		/// <param name="idList"></param>
		/// <returns></returns>
		public int PutTrashList(string idList)
		{
			string sql = "update Users set Users_DeleteId = 0 where Users_Id in (@IdList)";
			SqlParameter[] param =
			{
				new SqlParameter("@IdList",idList)
			};
			return SqlHelper.ExecuteNonQuery(sql, param);
		}
		/// <summary>
		/// 批量删除
		/// </summary>
		/// <param name="idList"></param>
		/// <returns></returns>
		public int RemoveRolesList(string idList)
		{
			string sql = "delete from Users where Users_Id in (@IdList)";

			SqlParameter[] param =
			{
				new SqlParameter("@IdList",idList)
			};
			return SqlHelper.ExecuteNonQuery(sql, param);
		}

		public List<Users> GetAll()
		{
			string sql = "select * from Users where Users_DeleteId = 1 order by Users_UpdateTime desc";

			var data = SqlHelper.Query(sql, null);

			List<Users> list = FillData(data);
			return list;

		}

		public Users GetRolesById(Guid id)
		{
			string sql = "select * from Users where Users_DeleteId = 1 and Users_Id = @Users_Id";
			SqlParameter[] param =
			{
				new SqlParameter("@Users_Id",id)
			};

			var dt = SqlHelper.Query(sql, param);

			// var data = FillData(dt).Count > 0 ? FillData(dt)[0] : new Roles();
			var data = FillData(dt).FirstOrDefault();
			return data;
		}

		public List<Users> GetRolesByNickName(string NickName)
		{
			string sql = "select * from Users where Users_DeleteId = 1 and Users_NickName like '%@NickName%'";

			SqlParameter[] param =
			{
				new SqlParameter("@NickName",NickName)
			};
			var dt = SqlHelper.Query(sql, param);
			return FillData(dt);
		}

		/// <summary>
		/// 判断这个名称是否存在
		/// </summary>
		/// <param name="title"></param>
		/// <returns></returns>
		public bool IsExists(string NickName)
		{
			string sql = "select * from Users where Users_DeleteId = 1 and NickName = @NickName";
			SqlParameter[] param =
			{
				new SqlParameter("@NickName",NickName)
			};
			var dt = SqlHelper.Query(sql, param);
			return FillData(dt).Any(); //判断集合当中是否存在数据 ,有数据返回true , 没数据返回false
		}


		public List<Users> FillData(DataTable dt)
		{
			var list = new List<Users>();

			foreach (DataRow dr in dt.Rows)
			{
				var item = new Users
				{
					Users_Id = Guid.Parse(dr["Users_Id"].ToString()),
					Users_Account = dr["Users_Account"].ToString(),
					Users_Password = dr["Users_Password"].ToString(),
					Users_RolesId = Guid.Parse(dr["Users_RolesId"].ToString()),
					Users_DeleteId = int.Parse(dr["Users_DeleteId"].ToString()),
					Users_NickName = dr["Users_NickName"].ToString(),
					Users_CreateTime = DateTime.Parse(dr["Users_CreateTime"].ToString()),
					Users_UpdateTime = DateTime.Parse(dr["Users_UpdateTime"].ToString())
				};
				list.Add(item);
			}
			return list;
		}
	}
}
