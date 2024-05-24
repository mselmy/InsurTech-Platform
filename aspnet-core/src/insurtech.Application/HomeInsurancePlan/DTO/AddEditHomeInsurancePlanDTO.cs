using Abp.Application.Services.Dto;
using insurtech.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace insurtech.HomeInsurancePlan.DTO
{
    public class AddEditHomeInsurancePlanDTO : EntityDto<long>
    {
        public AddEditHomeInsurancePlanDTO()
        {
            CategoryId = 2;
        }
        [Range(0, double.MaxValue, ErrorMessage = "Yearly coverage must be a non-negative value.")]
        public decimal YearlyCoverage { get; set; }

        [Required(ErrorMessage = "Insurance plan level is required.")]
        public InsurancePlanLevel Level { get; set; }

        [JsonIgnore]
        public long CategoryId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Quotation must be a non-negative value.")]
        public decimal Quotation { get; set; }

        [Required(ErrorMessage = "Company ID is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Company ID must be a positive value.")]
        public long CompanyId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Water damage coverage must be a non-negative value.")]
        public decimal WaterDamage { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Glass breakage coverage must be a non-negative value.")]
        public decimal GlassBreakage { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Natural hazard coverage must be a non-negative value.")]
        public decimal NaturalHazard { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Attempted theft coverage must be a non-negative value.")]
        public decimal AttemptedTheft { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Fires and explosion coverage must be a non-negative value.")]
        public decimal FiresAndExplosion { get; set; }

    }
}
