using Abp.Application.Services.Dto;
using insurtech.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.HomeInsurancePlan.DTO
{
    public class HomeInsurancePlanListDTO : EntityDto<long>
    {
        public decimal YearlyCoverage { get; set; }
        public InsurancePlanLevel Level { get; set; }
        public string CategoryName { get; set; }
        public decimal Quotation { get; set; }
        public string CompanyName { get; set; }
        public decimal WaterDamage { get; set; }
        public decimal GlassBreakage { get; set; }
        public decimal NaturalHazard { get; set; }
        public decimal AttemptedTheft { get; set; }
        public decimal FiresAndExplosion { get; set; }
    }
}
