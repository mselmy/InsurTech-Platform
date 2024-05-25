using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using insurtech.HealthInsurancePlan.HealthInsurancePlanDTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.HealthInsurancePlan
{
    public class HealthInsurancePlanService:CrudAppService<insurtech.Models.HealthInsurancePlan,HealthInsurancePlanDTO.HealthInsurancePlanDTO,long, HealthInsurancePlanFilterDto, HealthInsurancePlanDTO.HealthInsurancePlanDTO, HealthInsurancePlanDTO.HealthInsurancePlanDTO>  
    {

        public HealthInsurancePlanService(IRepository<insurtech.Models.HealthInsurancePlan,long> repository) : base(repository)
        {

        }
        public override HealthInsurancePlanDTO.HealthInsurancePlanDTO Create(HealthInsurancePlanDTO.HealthInsurancePlanDTO input)
        {
            try
            {
                
                return base.Create(input);
            }
            catch (Exception ex)
            {
                throw new Exception($"ex {ex}");
            }
        }


    }
}
