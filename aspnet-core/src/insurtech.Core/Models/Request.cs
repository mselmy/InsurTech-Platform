using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public int InsuranceUserId { get; set; }
        public InsuranceUser User { get; set; }
        public int InsurancePlanId { get; set; }
        public virtual InsurancePlan InsurancePlan { get; set; }
        public ICollection<RequestQuestion> RequestQuestions { get; set; } = new List<RequestQuestion>();

    }
}
