using insurtech.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.HomeInsurancePlan.DTO
{
    public class HomeInsurancePlanMapProfile : Profile
    {
        public HomeInsurancePlanMapProfile()
        {
            CreateMap<insurtech.Models.HomeInsurancePlan,AddEditHomeInsurancePlanDTO>().ReverseMap();

            CreateMap<insurtech.Models.HomeInsurancePlan, HomeInsurancePlanListDTO>()
                .ForMember(a => a.CompanyName, b => b.MapFrom(b => b.Company.Name))
                .ForMember(c => c.CategoryName, b => b.MapFrom(b => b.Category.Name));
        }
    }
}
