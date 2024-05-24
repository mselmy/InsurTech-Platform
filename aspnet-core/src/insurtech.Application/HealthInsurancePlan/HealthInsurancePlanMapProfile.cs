using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.HealthInsurancePlan
{
    public class HealthInsurancePlanMapProfile:Profile
    {
        public HealthInsurancePlanMapProfile()
        {
            CreateMap<insurtech.Models.HealthInsurancePlan, HealthInsurancePlanDTO.HealthInsurancePlanDTO>().ReverseMap();
        }
    }
}
