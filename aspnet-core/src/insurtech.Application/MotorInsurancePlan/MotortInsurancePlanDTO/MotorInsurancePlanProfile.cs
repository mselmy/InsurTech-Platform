using Abp.Application.Services.Dto;
using insurtech.HealthInsurancePlan.HealthInsurancePlanDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace insurtech.MotorInsurancePlan.MotortInsurancePlanDTO
{
    public class MotorInsurancePlanProfile : Profile
    {
        public MotorInsurancePlanProfile()
        {
            CreateMap<MototInsurancePlanDTO, Models.MotorInsurancePlan>().ReverseMap()
            //.ForMember(dest => dest.CompanyName, opt => opt.MapFrom<CompanyNameResolver>())
            //.ForMember(dest => dest.CategoryName, opt => opt.MapFrom<CategoryNameResolver>())
            //.ForMember(dest => dest.RequestNumber, opt => opt.MapFrom<RequestNumberResolver>());
            ;
            CreateMap<Models.MotorInsurancePlan, CreatedMotorInsurancePlanDTO>().ReverseMap();
            CreateMap<Models.MotorInsurancePlan, UpdatedMotorInsurancePlanDTO>().ReverseMap();
        }
    }

}
