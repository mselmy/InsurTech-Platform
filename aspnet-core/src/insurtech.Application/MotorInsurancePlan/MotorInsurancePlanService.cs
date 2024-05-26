using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using insurtech.MotorInsurancePlan.MotortInsurancePlanDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.MotorInsurancePlan
{
    public class MotorInsurancePlanService : CrudAppService<insurtech.Models.MotorInsurancePlan, MototInsurancePlanDTO, long, MotortInsurancePlanFilterDTO, CreatedMotorInsurancePlanDTO, UpdatedMotorInsurancePlanDTO>
    {
        public MotorInsurancePlanService(IRepository<Models.MotorInsurancePlan, long> repository) : base(repository)
        {

        }
        public override MototInsurancePlanDTO Create(CreatedMotorInsurancePlanDTO input)
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
        public override PagedResultDto<MototInsurancePlanDTO> GetAll(MotortInsurancePlanFilterDTO input)
        {
            try
            {
                return base.GetAll(input);
            }
            catch (Exception ex)
            {
                throw new Exception($"ex {ex}");
            }
        }
    }
}
