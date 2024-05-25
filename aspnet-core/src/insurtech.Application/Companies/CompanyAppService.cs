using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Castle.Components.DictionaryAdapter.Xml;
using insurtech.Authorization.Users;
using insurtech.Companies.Dto;
using insurtech.Models;
using insurtech.Users.Dto;

namespace insurtech.Companies
{
    public class CompanyAppService : AsyncCrudAppService<Company, CompanyDto, long, PagedAndSortedResultRequestDto, CreateCompanyInput, CompanyDto>
    {
        public CompanyAppService(IRepository<Company, long> repository) : base(repository)
        {

        }


        public override Task<PagedResultDto<CompanyDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {

            try
            {
                var companies = Repository.GetAll();
                return Task.FromResult(new PagedResultDto<CompanyDto>(companies.Count(), ObjectMapper.Map<List<CompanyDto>>(companies)));
               


            }

    
            catch (Exception ex) { throw new Exception($"ex {ex}"); }
        }


        public override async Task<CompanyDto> CreateAsync(CreateCompanyInput input)
        {
            try
            {
                var company = MapToEntity(input);
                await Repository.InsertAsync(company);
                await CurrentUnitOfWork.SaveChangesAsync();
                return MapToEntityDto(company);
            }
            catch (Exception ex) { throw new Exception($"ex {ex}"); }
        }

        protected override Company MapToEntity(CreateCompanyInput createCompanyInput)
        {
            var company = ObjectMapper.Map<Company>(createCompanyInput);
            company.SetNormalizedNames();
            return company;
        }


    }
}
