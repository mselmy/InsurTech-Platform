using insurtech.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public enum CompanyStatus
    {
        rejected,accepted,pending
    }
    public class Company : User
    {
        public CompanyStatus Status { get; set; }
        public string TaxNumber { get; set; }
        public string Location { get; set; }
        public virtual ICollection<InsurancePlan> InsurancePlans { get; set; } = new List<InsurancePlan>();

    }
}
