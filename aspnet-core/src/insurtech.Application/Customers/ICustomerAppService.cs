using Abp.Application.Services;
using Abp.Application.Services.Dto;
using insurtech.Customers.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Customers
{
    internal interface ICustomerAppService: IAsyncCrudAppService<CustomerDTO, long, PagedAndSortedResultRequestDto, CreateCustomerInput, CustomerDTO>
    {
    }
}
