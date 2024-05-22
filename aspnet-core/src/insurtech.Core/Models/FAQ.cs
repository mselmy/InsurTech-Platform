using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class FAQ
    {
        public int FAQId { get; set; }
        public string Answer { get; set;}
        public string Body { get; set;}
        public int InsuranceUserId { get; set; }
        public virtual InsuranceUser User { get; set; }
    }
}
