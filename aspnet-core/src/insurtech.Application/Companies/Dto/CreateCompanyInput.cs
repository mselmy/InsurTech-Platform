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
        [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9]*$", ErrorMessage = "Invalid UserName")]

        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        [DisableAuditing]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain at least one letter, one number, and one special character.")]
        public string Password { get; set; }
        [Required]
        [DisableAuditing]
        [RegularExpression(@"^(\d{9})$", ErrorMessage = "Invalid Tax Number")]

        public string TaxNumber { get; set; }
        [Required]
        [DisableAuditing]


        public string Location { get; set; }

        [JsonIgnore]
        public string Surname { get; set; } = "Company";

        [JsonIgnore]
        public CompanyStatus Status { get; set; } = CompanyStatus.pending;
        [Required]
        [DisableAuditing]
        [RegularExpression(@"^01(0|1|2|5)[0-9]{8}$")]
        public string phoneNumber { get; set; }
    }
}