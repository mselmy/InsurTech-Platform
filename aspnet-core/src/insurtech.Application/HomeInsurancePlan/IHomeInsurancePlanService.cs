using Abp.Application.Services;
using insurtech.HealthInsurancePlan.HealthInsurancePlanDTO;
using insurtech.HomeInsurancePlan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.HomeInsurancePlan
{
    public interface IHomeInsurancePlanService : ICrudAppService<AddEditHomeInsurancePlanDTO,long,HomeInsurancePlanFilterDTO,AddEditHomeInsurancePlanDTO,AddEditHomeInsurancePlanDTO,HomeInsurancePlanListDTO>
    {
      
    }
}
