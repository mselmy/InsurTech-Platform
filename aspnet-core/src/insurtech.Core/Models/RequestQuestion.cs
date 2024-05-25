using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class RequestQuestion :Entity<long>
    {
        public long QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public long RequestId { get; set; }
        public virtual Request Request { get; set; }
        public string Answer { get; set; }
    }
}
