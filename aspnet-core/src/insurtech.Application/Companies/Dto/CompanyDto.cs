using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using insurtech.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Companies.Dto
{
    [AutoMapFrom(typeof(Company))]
    /*
       builder.Property(a => a.EmailAddress).HasAnnotation("RegularExpression", @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
               builder.Property(a => a.PhoneNumber).HasMaxLength(11).HasAnnotation("RegularExpression", @"^01(0|1|2|5)[0-9]{8}$");
               builder.Property(a => a.Password).HasAnnotation("RegularExpression", @"^(?=.[A-Za-z])(?=.\d)[A-Za-z\d]{8,}$");
               builder.Property(a => a.UserName).HasAnnotation("MinLength", 3).HasMaxLength(20).HasAnnotation("RegularExpression", @"^[a-zA-Z][a-zA-Z0-9]*$");
               builder.HasIndex(a => a.EmailAddress).IsUnique();
     */
    public class CompanyDto : EntityDto<long>
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
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain at least one letter, one number, and one special character.")]

        public string Password { get; set; }
        [Required]
        [DisableAuditing]
        [RegularExpression(@"^(\d{9})$", ErrorMessage = "Invalid Tax Number")]
        public string TaxNumber { get; set; }
        [Required]
        [DisableAuditing]
        public string Location { get; set; }
        public CompanyStatus Status { get; set; }
        [Required]
        [DisableAuditing]
        [RegularExpression(@"^01(0|1|2|5)[0-9]{8}$")]
        public string phoneNumber { get; set; }
    }
}