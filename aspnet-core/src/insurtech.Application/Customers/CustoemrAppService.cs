using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.IdentityFramework;
using insurtech.Authorization.Users;
using insurtech.Companies.Dto;
using insurtech.Customers.DTO;
using insurtech.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Customers
{
    public class CustoemrAppService : AsyncCrudAppService<Customer, CustomerDTO, long, PagedAndSortedResultRequestDto, CreateCustomerInput, CustomerDTO>, ICustomerAppService
    {

        private readonly UserManager _userManager;

        public CustoemrAppService(IRepository<Customer, long> repository, UserManager userManager) : base(repository)
        {
            _userManager = userManager;

        }
        public override async Task<CustomerDTO> CreateAsync(CreateCustomerInput input)
        {
            try
            {
                var customer = MapToEntity(input);

                CheckErrors(await _userManager.CreateAsync(customer, customer.Password));

                await CurrentUnitOfWork.SaveChangesAsync();

                return MapToEntityDto(customer);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                throw new Exception($"ex {ex}");
            }




        }
        protected override Customer MapToEntity(CreateCustomerInput createCustomerInput)
        {
            var customer = ObjectMapper.Map<Customer>(createCustomerInput);
            customer.SetNormalizedNames();
            return customer;
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
