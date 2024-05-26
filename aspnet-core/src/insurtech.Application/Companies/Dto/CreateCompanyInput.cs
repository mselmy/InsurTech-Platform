using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using insurtech.Authorization.Users;
using insurtech.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace insurtech.Companies.Dto
{
    [AutoMapTo(typeof(Company))]

    public class CreateCompanyInput
    {
        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string Name { get; set; }
        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]

        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }
        [Required]

        public string TaxNumber { get; set; }
        [Required]

        public string Location { get; set; }

        [JsonIgnore]
        public string Surname { get; set; } = "Company";

        [JsonIgnore]
        public CompanyStatus Status { get; set; } = CompanyStatus.pending;
    }
}