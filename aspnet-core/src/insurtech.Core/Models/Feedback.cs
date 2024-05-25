using Abp.Domain.Entities;
using insurtech.Authorization.Users;
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
    public class Feedback : Entity<long>
    {
        //public long FeedbackId { get; set; }
        public Rating Rating { get; set; }
        public string Comment { get; set; }
        public long CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
