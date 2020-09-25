using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsersService
    {
        UsersManager rm = new UsersManager();
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="roles"></param>
        /// <returns></returns>
        public int AddRoles(Users roles)
        {
            return rm.AddUsers(roles);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="roles"></param>
        /// <returns></returns>
        public int EditRoles(Users roles)
        {
            return rm.EditUsers(roles);
        }

        /// <summary>
        /// 放入回收站
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int PutTrash(Guid id)
        {
            return rm.PutTrash(id);
        }

        /// <summary>
        /// 真删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int RemoveRoles(Guid id)
        {
            return rm.RemoveUsers(id);
        }

        /// <summary>
        /// 批量放入回收站
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns>
        public int PutTrashList(string idList)
        {
            return rm.PutTrashList(idList);
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns>
        public int RemoveRolesList(string idList)
        {
            return rm.RemoveRolesList(idList);
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public List<Users> GetAll()
        {
            return rm.GetAll();
        }
        /// <summary>
        /// 按照id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Users GetRolesById(Guid id)
        {
            return rm.GetRolesById(id);
        }

        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="NickName"></param>
        /// <returns></returns>
        public List<Users> GetRolesByNickName(string NickName)
        {
            if(NickName.Length != 0)
                return rm.GetRolesByNickName(NickName);
            return rm.GetAll();
        }

        /// <summary>
        /// 判断这个名称是否存在
        /// </summary>
        /// <param name="NickName"></param>
        /// <returns></returns>
        public bool IsExists(string NickName)
        {
            return rm.IsExists(NickName);
        }
    }
}
