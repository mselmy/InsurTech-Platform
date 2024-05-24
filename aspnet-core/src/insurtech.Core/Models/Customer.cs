using insurtech.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class Customer : User
    {
        public string NationalId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    }
}
