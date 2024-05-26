using AutoMapper;
using insurtech.MultiTenancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Sessions.Dto
{
    public class TenantLoginProfile: Profile
    {
        public TenantLoginProfile()
        {
            CreateMap<Tenant, TenantLoginInfoDto>();
        }
    }

}

