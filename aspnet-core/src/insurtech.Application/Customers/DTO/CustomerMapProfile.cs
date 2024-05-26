using AutoMapper;
using insurtech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Customers.DTO
{
    public class CustomerMapProfile:Profile
    {
        public CustomerMapProfile()
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<CreateCustomerInput, Customer>();
            //CreateMap<Customer, CreateCustomerOutput>();
        }

    }
}
