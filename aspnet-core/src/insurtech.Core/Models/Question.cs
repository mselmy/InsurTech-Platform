using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Body { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
