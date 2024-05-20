using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public enum Rating
    {
        Great , Good , Poor
    }
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public Rating Rating { get; set; }
        public string Comment { get; set; }
        public InsuranceUser User { get; set; }
        public int InsuranceUserId { get; set; }
    }
}
