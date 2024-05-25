using Abp.Domain.Entities;
using insurtech.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class FAQ : Entity<long>
    {
        //public long FAQId { get; set; }
        public string Answer { get; set;}
        public string Body { get; set;}
        public long UserId { get; set; }
        public virtual User User { get; set; }
    }
}
