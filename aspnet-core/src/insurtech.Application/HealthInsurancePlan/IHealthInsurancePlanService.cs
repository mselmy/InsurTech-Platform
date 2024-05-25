using Abp.Application.Services;
using insurtech.HealthInsurancePlan.HealthInsurancePlanDTO;
using insurtech.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace insurtech.HealthInsurancePlan
{
    public interface IHealthInsurancePlanService :ICrudAppService< HealthInsurancePlanDTO.HealthInsurancePlanDTO, long, HealthInsurancePlanFilterDto, HealthInsurancePlanDTO.HealthInsurancePlanDTO, HealthInsurancePlanDTO.HealthInsurancePlanDTO>
    { 

    }
}
