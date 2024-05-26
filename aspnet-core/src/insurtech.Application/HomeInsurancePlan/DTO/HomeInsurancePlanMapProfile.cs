using insurtech.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using insurtech.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using insurtech.HomeInsurancePlan.Resolver;

namespace insurtech.HomeInsurancePlan.DTO
{
    public class HomeInsurancePlanMapProfile : Profile
    {
        

        public HomeInsurancePlanMapProfile()
        {
            ConfigureMappings();
        }

        private void ConfigureMappings()
        {
            CreateMap<Models.HomeInsurancePlan, AddEditHomeInsurancePlanDTO>().ReverseMap();

            CreateMap<Models.HomeInsurancePlan, HomeInsurancePlanListDTO>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom<CompanyNameResolver>())
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom<CategoryNameResolver>())
                .ReverseMap();
        }
    }
}
