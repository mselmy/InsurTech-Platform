using Abp.Application.Services;
using Abp.Domain.Repositories;
using insurtech.HomeInsurancePlan.DTO;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.HomeInsurancePlan
{
    public class HomeInsurancePlanService : CrudAppService<insurtech.Models.HomeInsurancePlan,HomeInsurancePlanListDTO,long,HomeInsurancePlanListDTO,AddEditHomeInsurancePlanDTO,AddEditHomeInsurancePlanDTO,HomeInsurancePlanListDTO>
    {
        public HomeInsurancePlanService(IRepository<insurtech.Models.HomeInsurancePlan, long> repository) : base(repository)
        {
              
        }
        public override HomeInsurancePlanListDTO Create(AddEditHomeInsurancePlanDTO input)
        {
            try
            {
                return base.Create(input);
            }
            catch (Exception ex)
            {
                throw new Exception($"ex {ex}");
            }
        }
    }
}
