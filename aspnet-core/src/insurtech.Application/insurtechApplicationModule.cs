using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using insurtech.Authorization;

namespace insurtech
{
    [DependsOn(
        typeof(insurtechCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class insurtechApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<insurtechAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(insurtechApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
