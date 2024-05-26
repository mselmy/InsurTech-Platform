using AutoMapper;
using insurtech.Models;

namespace insurtech.MotorInsurancePlan.MotortInsurancePlanDTO
{
    public class CompanyNameResolver : IValueResolver<Models.MotorInsurancePlan, MototInsurancePlanDTO, string>
    {
        public string Resolve(Models.MotorInsurancePlan source, MototInsurancePlanDTO destination, string destMember, ResolutionContext context)
        {
            return source.Company?.Name??"Not found";
        }
    }

    public class CategoryNameResolver : IValueResolver<Models.MotorInsurancePlan, MototInsurancePlanDTO, string>
    {
        public string Resolve(Models.MotorInsurancePlan source, MototInsurancePlanDTO destination, string destMember, ResolutionContext context)
        {
            return source.Category?.Name??"Not found";
        }
    }
    public class RequestNumberResolver: IValueResolver<Models.MotorInsurancePlan, MototInsurancePlanDTO, int>
    {
        public int Resolve(Models.MotorInsurancePlan source, MototInsurancePlanDTO destination, int destMember, ResolutionContext context)
        {
            return source.Requests?.Count??0;
        }
    }
}
