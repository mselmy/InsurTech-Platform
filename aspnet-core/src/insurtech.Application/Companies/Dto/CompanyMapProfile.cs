using AutoMapper;
using insurtech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Companies.Dto
{
    public class CompanyMapProfile : Profile
    {
        public CompanyMapProfile()
        {
            CreateMap<Company, CompanyDto>().ReverseMap();
            CreateMap<CreateCompanyInput, Company>();
            //CreateMap<Company, CreateCompanyOutput>();
        }
    }
}
