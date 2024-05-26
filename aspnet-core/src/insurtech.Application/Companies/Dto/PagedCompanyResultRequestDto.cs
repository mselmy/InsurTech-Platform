using Abp.Application.Services.Dto;
using insurtech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Companies.Dto
{
    //custom PagedResultRequestDto
    public class PagedCompanyResultRequestDto : PagedResultRequestDto
    {
      public CompanyStatus? Status { get; set; }
    }
}
