using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.HealthInsurancePlan.HealthInsurancePlanDTO
{
    public class HealthInsurancePlanMapProfile : Profile
    {
        public HealthInsurancePlanMapProfile()
        {
            CreateMap<Models.HealthInsurancePlan, HealthInsurancePlanDTO>().ReverseMap();
        }
    }
}
