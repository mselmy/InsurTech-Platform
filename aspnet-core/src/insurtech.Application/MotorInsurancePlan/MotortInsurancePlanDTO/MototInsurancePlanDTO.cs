using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using insurtech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace insurtech.MotorInsurancePlan.MotortInsurancePlanDTO
{
    [AutoMapFrom(typeof(insurtech.Models.MotorInsurancePlan))]
    public class MototInsurancePlanDTO: EntityDto<long>
    {
        public decimal YearlyCoverage { get; set; }
        public InsurancePlanLevel Level { get; set; }
        //public string CategoryName { get; set; }
        public decimal Quotation { get; set; }
        //public string CompanyName { get; set; }
        public decimal PersonalAccident { get; set; }
        public decimal Theft { get; set; }
        public decimal ThirdPartyLiability { get; set; }
        public decimal OwnDamage { get; set; }
        public decimal LegalExpenses { get; set; }
        //public int RequestNumber { get; set; }
        public long companyId { get; set; }
        public long categoryId { get; set; }
        public long Id { set; get; }

    }
}
