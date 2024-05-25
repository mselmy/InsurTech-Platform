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
	public class CompanyRegisterDTO
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
		public string Password { get; set; }
		[Required]
		[DisableAuditing]
		public string TaxNumber { get; set; }
		[Required]
		[DisableAuditing]
		public string Location { get; set; }
	}
}
