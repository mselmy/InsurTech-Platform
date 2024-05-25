using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.IdentityFramework;
using Abp.Net.Mail;
using Castle.Components.DictionaryAdapter.Xml;
using insurtech.Authorization.Users;
using insurtech.Companies.Dto;
using insurtech.Models;
using insurtech.Users.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;

namespace insurtech.Companies
{
    public class CompanyAppService : AsyncCrudAppService<Company, CompanyDto, long, PagedAndSortedResultRequestDto, CreateCompanyInput, CompanyDto>, ICompanyAppService
    {

        private readonly UserManager _userManager;
        private readonly IEmailSender _emailSender;

        public CompanyAppService(IRepository<Company, long> repository, UserManager userManager
            , IEmailSender emailSender
            ) : base(repository)
        {
            _userManager = userManager;
            _emailSender = emailSender;

        }






        public override async Task<CompanyDto> CreateAsync(CreateCompanyInput input)
        {
            try
            {
                var company = MapToEntity(input);

                CheckErrors(await _userManager.CreateAsync(company, company.Password));
                await _emailSender.SendAsync(company.EmailAddress, "Your Password", company.Password);
                await CurrentUnitOfWork.SaveChangesAsync();
                return MapToEntityDto(company);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                throw new Exception($"ex {ex}");
            }
        }

        protected override Company MapToEntity(CreateCompanyInput createCompanyInput)
        {
            var company = ObjectMapper.Map<Company>(createCompanyInput);
            company.SetNormalizedNames();
            return company;
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }

        public async Task Accept(EntityDto<long> company)
        {
            await Repository.UpdateAsync(company.Id, async (c) => c.Status = CompanyStatus.accepted);
        }

        public async Task Reject(EntityDto<long> company)
        {
            await Repository.UpdateAsync(company.Id, async (c) => c.Status = CompanyStatus.rejected);
        }
    }
}
