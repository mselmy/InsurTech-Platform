using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.HealthInsurancePlan.HealthInsurancePlanDTO
{
    public class HealthInsurancePlanFilterDto:PagedAndSortedResultRequestDto
    {
        public decimal YearlyCoverage { get; set; }
    }
}
