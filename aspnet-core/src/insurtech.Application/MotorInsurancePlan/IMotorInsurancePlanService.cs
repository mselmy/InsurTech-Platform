﻿using Abp.Application.Services;
using insurtech.MotorInsurancePlan.MotortInsurancePlanDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.MotorInsurancePlan
{
    public interface IMotorInsurancePlanService:ICrudAppService<MototInsurancePlanDTO,long,MotortInsurancePlanFilterDTO,CreatedMotorInsurancePlanDTO,UpdatedMotorInsurancePlanDTO>
    {
    }
}
