using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using insurtech.Configuration;

namespace insurtech.Web.Host.Startup
{
    [DependsOn(
       typeof(insurtechWebCoreModule))]
    public class insurtechWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public insurtechWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(insurtechWebHostModule).GetAssembly());
        }
    }
}
