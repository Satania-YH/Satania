using CompetitionSystem.DTO.UserInfDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSystem.IBLL.IUsersManager
{
    public interface IUserManager
    {
        /// <summary>
        /// 获取用户基础信息
        /// </summary>
        /// <returns></returns>
        Task<UserInfDTO> GetUserInf(Guid userId);
    }
}
