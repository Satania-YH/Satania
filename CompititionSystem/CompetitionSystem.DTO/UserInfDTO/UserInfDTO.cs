using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSystem.DTO.UserInfDTO
{
    public class UserInfDTO
    {
        public Guid Id { get; set; }
        public string NickName { get; set; }
        public string ImagePath { get; set; }
        public string UserType { get; set; }
    }
}
