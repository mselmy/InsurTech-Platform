using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class HomeInsurancePlan : InsurancePlan
    {
        public decimal WaterDamage { get; set; }
        public decimal GlassBreakage { get; set; }
        public decimal NaturalHazard { get; set; }
        public decimal AttemptedTheft { get; set; }
        public decimal FiresAndExplosion { get; set; }
    }
}
