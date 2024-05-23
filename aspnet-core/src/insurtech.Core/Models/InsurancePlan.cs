using Abp.Domain.Entities;
using insurtech.Authorization.Users;
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
    public class InsurancePlan : Entity<long>
    {
        //public long InsurancePlanId { get; set; }
        public decimal YearlyCoverage { get; set; }
        public InsurancePlanLevel Level { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public decimal Quotation { get; set; }
        public long CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}
