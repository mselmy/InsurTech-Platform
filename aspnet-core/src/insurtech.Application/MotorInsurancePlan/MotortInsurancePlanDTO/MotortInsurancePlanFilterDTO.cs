using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.MotorInsurancePlan.MotortInsurancePlanDTO
{
    public class MotortInsurancePlanFilterDTO : PagedAndSortedResultRequestDto
    {
        public decimal YearlyCoverage { get; set; }
    }
}
