using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using insurtech.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Customers.DTO
{
    [AutoMapFrom(typeof(Customer))]

    public class CustomerDTO:EntityDto<long>
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
        public string Password { get; set; }
        [Required]
        [DisableAuditing]
        public string NationalId { get; set; }
        [Required]
        [DisableAuditing]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [DisableAuditing]
        [RegexStringValidator(@"^01(0|1|2|5)[0-9]{8}$")]

        public string phoneNumber { get; set; }
    }
}
