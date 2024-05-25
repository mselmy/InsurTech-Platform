using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.IdentityFramework;
using Castle.Components.DictionaryAdapter.Xml;
using insurtech.Authorization.Users;
using insurtech.Companies.Dto;
using insurtech.Models;
using insurtech.Users.Dto;
using Microsoft.AspNetCore.Identity;

namespace insurtech.Companies
{
    public class CompanyAppService : AsyncCrudAppService<Company, CompanyDto, long, PagedAndSortedResultRequestDto, CreateCompanyInput, CompanyDto>
    {

        private readonly UserManager _userManager;

        public CompanyAppService(IRepository<Company, long> repository,UserManager userManager) : base(repository)
        {
            _userManager = userManager;

        }




        public override async Task<CompanyDto> CreateAsync(CreateCompanyInput input)
        {
            try
            {
                var company = MapToEntity(input);

                CheckErrors(await _userManager.CreateAsync(company,company.Password));




                //await Repository.InsertAsync(company);

                await CurrentUnitOfWork.SaveChangesAsync();

                return MapToEntityDto(company);
            }
            catch (Exception ex) {

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


    }
}
