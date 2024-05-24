using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class Question : Entity<long>
    {
        //public long QuestionId { get; set; }
        public string Body { get; set; }
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<RequestQuestion> RequestQuestions { get; set; } = new List<RequestQuestion>();

    }
}
