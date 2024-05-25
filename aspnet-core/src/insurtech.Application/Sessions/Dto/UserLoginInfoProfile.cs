using Abp.Authorization.Users;
using AutoMapper;
using insurtech.Authorization.Users;
using insurtech.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Sessions.Dto
{
    public class UserLoginInfoProfile:Profile
    {
        public UserLoginInfoProfile()
        {
            CreateMap<User, UserLoginInfoDto>();

        }

    }
}
