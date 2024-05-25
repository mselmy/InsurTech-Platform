using AutoMapper;
using insurtech.HomeInsurancePlan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.HomeInsurancePlan.Resolver
{
    public class CategoryNameResolver : IValueResolver<insurtech.Models.HomeInsurancePlan, HomeInsurancePlanListDTO, string>
    {
        public string Resolve(Models.HomeInsurancePlan source, HomeInsurancePlanListDTO destination, string destMember, ResolutionContext context)
        {
            return source.Category?.Name??"Not Found";
        }
    }
}
