using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string Body { get; set; }
        public int InsuranceUserId { get; set; }
        public virtual InsuranceUser User { get; set; }
    }
}
