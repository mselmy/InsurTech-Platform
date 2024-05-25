using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using insurtech.Companies.Dto;
using Abp.Application.Services.Dto;

namespace insurtech.Companies
{
    public interface ICompanyAppService : IAsyncCrudAppService<CompanyDto, long, PagedAndSortedResultRequestDto, CreateCompanyInput, CompanyDto>
    {
        void CreateCompany(CreateCompanyInput input);
    }
}
