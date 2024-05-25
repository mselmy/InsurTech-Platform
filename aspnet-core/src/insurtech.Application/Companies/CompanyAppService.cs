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
    public class CompanyAppService : CrudAppService<Company, CompanyDto, long, PagedAndSortedResultRequestDto, CreateCompanyInput, CompanyDto>
    {
        CompanyAppService(IRepository<Company, long> repository) : base(repository)
        {
        }

       

    }
}
