using Abp.Domain.Entities;
using insurtech.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class Request : Entity<long>
    {
        //public long RequestId { get; set; }
        public long CustomerId { get; set; }
        public virtual User Customer { get; set; }
        public long InsurancePlanId { get; set; }
        public virtual InsurancePlan InsurancePlan { get; set; }
        public ICollection<RequestQuestion> RequestQuestions { get; set; } = new List<RequestQuestion>();

    }
}
