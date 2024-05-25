using Abp.Application.Services.Dto;
using insurtech.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace insurtech.MotorInsurancePlan.MotortInsurancePlanDTO
{
    public class CreatedMotorInsurancePlanDTO: EntityDto<long>
    {
        [Required(ErrorMessage = "Yearly coverage is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Yearly coverage must be a non-negative number.")]
        public decimal YearlyCoverage { get; set; }

        [Required(ErrorMessage = "Level is required.")]
        public InsurancePlanLevel Level { get; set; }

        [JsonIgnore]
        public long CategoryId { get; set; }

        [Required(ErrorMessage = "Quotation is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Quotation must be a non-negative number.")]
        public decimal Quotation { get; set; }

        public long CompanyId { get; set; }

        [Required(ErrorMessage = "Personal accident coverage is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Personal accident coverage must be a non-negative number.")]
        public decimal PersonalAccident { get; set; }

        [Required(ErrorMessage = "Theft coverage is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Theft coverage must be a non-negative number.")]
        public decimal Theft { get; set; }

        [Required(ErrorMessage = "Third-party liability coverage is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Third-party liability coverage must be a non-negative number.")]
        public decimal ThirdPartyLiability { get; set; }

        [Required(ErrorMessage = "Own damage coverage is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Own damage coverage must be a non-negative number.")]
        public decimal OwnDamage { get; set; }

        [Required(ErrorMessage = "Legal expenses coverage is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Legal expenses coverage must be a non-negative number.")]
        public decimal LegalExpenses { get; set; }

        public CreatedMotorInsurancePlanDTO()
        {
            CategoryId = 3;
        }
    }

}

