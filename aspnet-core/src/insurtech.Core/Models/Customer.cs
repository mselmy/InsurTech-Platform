using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class Customer : InsuranceUser
    {
        public string NationalId { get; set; }
        public DateOnly DateOfBirth { get; set; }


    }
}
