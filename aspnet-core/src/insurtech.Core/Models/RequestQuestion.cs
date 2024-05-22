using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class RequestQuestion
    {
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; }
        public string Answer { get; set; }
    }
}
