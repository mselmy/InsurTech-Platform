using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class InsuranceUser
    {
        public int InsuranceUserId { get;set; }
        public string Email { get;set; }
        public string Password { get;set; }
        public string Role { get;set; }
        public string Number { get;set; }
        public string FirstName { get;set; }
        public string LastName { get; set; }
        public ICollection<Request> Requests { get; set; } = new List<Request>();
    }
}
