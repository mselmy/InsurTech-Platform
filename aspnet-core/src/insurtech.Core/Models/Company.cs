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
        pending,reject,Accepted
    }
    public class Company : InsuranceUser
    {
        public string City { get; set; }
        public string Governorate { get; set; }
        public string Street { get; set; }
        public CompanyStatus Status { get; set; }
        public string TaxNumber { get; set; }
        public ICollection<InsurancePlan> InsurancePlans { get; set;} = new List<InsurancePlan>();
    }
}
