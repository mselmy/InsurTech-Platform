using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public enum InsurancePlanLevel
    {
        basic , Standard , Premium
    }
    public class InsurancePlan
    {
        public int InsurancePlanId { get; set; }
        public decimal YearlyCoverage { get; set; }
        public InsurancePlanLevel Level { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public decimal Quotation { get; set; }
        public int InsuranceUserId { get; set; }
        public virtual InsuranceUser User { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}
