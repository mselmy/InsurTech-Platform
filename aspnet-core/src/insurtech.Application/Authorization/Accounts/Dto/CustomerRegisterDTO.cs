using Abp.Auditing;
using Abp.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Authorization.Accounts.Dto
{
	public class CustomerRegisterDTO
	{
		[Required]
		[StringLength(AbpUserBase.MaxNameLength)]
		public string Name { get; set; }

		[Required]
		[StringLength(AbpUserBase.MaxUserNameLength)]
		public string UserName { get; set; }
		[Required]
		[EmailAddress]
		[StringLength(AbpUserBase.MaxEmailAddressLength)]
		public string EmailAddress { get; set; }
		[StringLength(AbpUserBase.MaxPlainPasswordLength)]
		[DisableAuditing]
		public string Password { get; set; }
		[Required]
		[DisableAuditing]
		public string NationalId { get; set; }
		[Required]
		[DisableAuditing]
		public DateTime DateOfBirth { get; set; }

	}
}
