using AutoMapper;
using AutoMapper.Execution;
using insurtech.HomeInsurancePlan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.HomeInsurancePlan.Resolver
{
    public class CompanyNameResolver : IValueResolver<Models.HomeInsurancePlan, HomeInsurancePlanListDTO, string>
    {
        public string Resolve(Models.HomeInsurancePlan source, HomeInsurancePlanListDTO destination, string destMember, ResolutionContext context)
        {
            return source.Company?.Name ?? "Not Found";
        }
    }
}
