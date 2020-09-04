using CompetitionSystem.DAL.UsersService;
using CompetitionSystem.DTO.UserInfDTO;
using CompetitionSystem.IBLL.IUsersManager;
using CompetitionSystem.IDAL.IUsersService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSystem.BLL.UsersManager
{
    public class UserManager : IUserManager
    {
        public async Task<UserInfDTO> GetUserInf(Guid userId)
        {
            using(IUserService service = new UserService())
            {
                return await service
                    .GetAll()
                    .Where(m => m.Id == userId)
                    .Select(m => new UserInfDTO()
                {
                    Id = userId,
                    ImagePath = m.ImagePath,
                    NickName = m.NickName,
                    UserType = m.UserType
                }).FirstAsync();
            }    
        }
    }
}
