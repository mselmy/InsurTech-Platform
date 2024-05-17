using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using insurtech.Authorization.Roles;
using insurtech.Authorization.Users;
using insurtech.MultiTenancy;
using Microsoft.Extensions.Logging;
using Abp.Domain.Uow;

namespace insurtech.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ILoggerFactory loggerFactory,
            IUnitOfWorkManager unitOfWorkManager)
            : base(options, signInManager, loggerFactory, unitOfWorkManager)
        {
        }
    }
}
