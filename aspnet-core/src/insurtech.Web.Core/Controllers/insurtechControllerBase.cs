using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace insurtech.Controllers
{
    public abstract class insurtechControllerBase: AbpController
    {
        protected insurtechControllerBase()
        {
            LocalizationSourceName = insurtechConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
