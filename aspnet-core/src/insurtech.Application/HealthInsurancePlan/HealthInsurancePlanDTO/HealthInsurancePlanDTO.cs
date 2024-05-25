using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using insurtech.Models;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace insurtech.HealthInsurancePlan.HealthInsurancePlanDTO
{
    [AutoMapFrom(typeof(insurtech.Models.HealthInsurancePlan))]
    public class HealthInsurancePlanDTO : EntityDto<long>
    {
        public decimal YearlyCoverage { get; set; }
        public InsurancePlanLevel Level { get; set; }

        [JsonIgnore]
        public long CategoryId { get; set; }
        public decimal Quotation { get; set; }
        public long CompanyId { get; set; }
        public string MedicalNetwork { get; set; }
        public decimal ClinicsCoverage { get; set; }
        public decimal HospitalizationAndSurgery { get; set; }
        public decimal OpticalCoverage { get; set; }
        public decimal DentalCoverage { get; set; }
        public HealthInsurancePlanDTO()
        {
            CategoryId = 1;


        }

    }
}
