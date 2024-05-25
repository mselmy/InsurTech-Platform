using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using insurtech.Companies.Dto;
using insurtech.Models;

namespace insurtech.Companies
{
    public class CompanyAppService : AsyncCrudAppService<Company, CompanyDto, long, PagedAndSortedResultRequestDto, CreateCompanyInput, CompanyDto>, ICompanyAppService
    {
        private readonly IRepository<Company, long> _companyRepository;
        CompanyAppService(IRepository<Company, long> companyRepository) : base(companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public void CreateCompany(CreateCompanyInput input)
        {
           var company = ObjectMapper.Map<Company>(input);

          
            _companyRepository.Insert(company);
        }

    }
}
