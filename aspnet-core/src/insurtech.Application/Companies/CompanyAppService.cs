using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.IdentityFramework;
using Abp.Localization;
using Abp.Net.Mail;
using AutoMapper.Internal.Mappers;
using Castle.Components.DictionaryAdapter.Xml;
using insurtech.Authorization.Users;
using insurtech.Companies.Dto;
using insurtech.Models;
using insurtech.Users.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;

namespace insurtech.Companies
{
    public class CompanyAppService : AsyncCrudAppService<Company, CompanyDto, long, PagedCompanyResultRequestDto, CreateCompanyInput, CompanyDto>, ICompanyAppService
    {

        private readonly UserManager _userManager;

        public CompanyAppService(IRepository<Company, long> repository,UserManager userManager) : base(repository)
        {
            _userManager = userManager;

		}

        public override async Task<CompanyDto> CreateAsync(CreateCompanyInput input)
        {
            try
            {
                var company = MapToEntity(input);


                CheckErrors(await _userManager.CreateAsync(company,company.Password));


				//await Repository.InsertAsync(company);
				MailMessage mail = new MailMessage();

				mail.From = new MailAddress("myInsureTech@outlook.com");
				mail.Subject = "please work Cna";
				mail.Body = "working";
				mail.IsBodyHtml = true;
				mail.To.Add(new MailAddress(company.EmailAddress));

				var smtp = new SmtpClient
				{
					Host = "smtp-mail.outlook.com",
					//smtp.Host = "mohraapp.com";
					EnableSsl = true
				};
				NetworkCredential NetworkCred = new NetworkCredential();
				NetworkCred.UserName = "myInsureTech@outlook.com";
				NetworkCred.Password = "Ash@1234";

				smtp.Credentials = NetworkCred;
				smtp.Port = 587;

				await smtp.SendMailAsync(mail);
				Logger.Info("Email sent successfully.");



				await CurrentUnitOfWork.SaveChangesAsync();


				return MapToEntityDto(company);

			}
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                throw new Exception($"ex {ex}");
            }
        }

        protected override Company MapToEntity(CreateCompanyInput createCompanyInput)
        {
            var company = ObjectMapper.Map<Company>(createCompanyInput);
            company.SetNormalizedNames();
            return company;
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }

        public async Task Accept(EntityDto<long> company)
        {
            await Repository.UpdateAsync(company.Id, async (c) => c.Status = CompanyStatus.accepted);
        }

        public async Task Reject(EntityDto<long> company)
        {
            await Repository.UpdateAsync(company.Id, async (c) => c.Status = CompanyStatus.rejected);
        }
    }
}




	

