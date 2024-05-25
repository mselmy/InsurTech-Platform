using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.Configuration;
using Abp.Localization;
using Abp.MultiTenancy;
using Abp.Net.Mail;

namespace insurtech.EntityFrameworkCore.Seed.Host
{
    public class DefaultSettingsCreator
    {
        private readonly insurtechDbContext _context;

        public DefaultSettingsCreator(insurtechDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            int? tenantId = null;

            if (insurtechConsts.MultiTenancyEnabled == false)
            {
                tenantId = MultiTenancyConsts.DefaultTenantId;
            }

			// Emailing
			AddSettingIfNotExists(EmailSettingNames.DefaultFromAddress, "myInsureTech@outlook.com", tenantId);
			AddSettingIfNotExists(EmailSettingNames.DefaultFromDisplayName, "InsureTech.com", tenantId);
			AddSettingIfNotExists(EmailSettingNames.Smtp.Host, "smtp.office365.com", tenantId);
			AddSettingIfNotExists(EmailSettingNames.Smtp.Port, "587", tenantId);
			AddSettingIfNotExists(EmailSettingNames.Smtp.UserName, "myInsureTech@outlook.com");
			AddSettingIfNotExists(EmailSettingNames.Smtp.Password, "Ash@1234");
			AddSettingIfNotExists(EmailSettingNames.Smtp.EnableSsl, "true", tenantId); // EnableSsl is true for STARTTLS
			AddSettingIfNotExists(EmailSettingNames.Smtp.UseDefaultCredentials, "false", tenantId);



			// Languages
			AddSettingIfNotExists(LocalizationSettingNames.DefaultLanguage, "en", tenantId);
        }

        private void AddSettingIfNotExists(string name, string value, int? tenantId = null)
        {
            if (_context.Settings.IgnoreQueryFilters().Any(s => s.Name == name && s.TenantId == tenantId && s.UserId == null))
            {
                return;
            }

            _context.Settings.Add(new Setting(tenantId, null, name, value));
            _context.SaveChanges();
        }
    }
}
