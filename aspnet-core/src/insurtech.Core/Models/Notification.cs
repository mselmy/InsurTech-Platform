using Abp.Domain.Entities;
using insurtech.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class Notification : Entity<long>
    {
        //public long NotificationId { get; set; }
        public string Body { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        
    }
}
