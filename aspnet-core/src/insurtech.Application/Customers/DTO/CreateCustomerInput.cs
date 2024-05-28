using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using insurtech.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace insurtech.Customers.DTO
{
    [AutoMapTo(typeof(Customer))]

    public class CreateCustomerInput
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
        [StringLength(14)]
        public string NationalId { get; set; }
    
        [JsonIgnore]
        public string Surname { get; set; } = "Customer";

        public DateTime DateOfBirth { get; set; }
        [JsonIgnore]
        public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        [Required]
        [DisableAuditing]
        [RegularExpression(@"^01(0|1|2|5)[0-9]{8}$")]
        public string phoneNumber { get; set; }

    }
}
