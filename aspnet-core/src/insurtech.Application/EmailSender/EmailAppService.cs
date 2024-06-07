using Abp.Net.Mail;
using insurtech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using insurtech.Authorization.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Abp.Application.Services;

namespace insurtech.EmailSender
{
	public class EmailAppService : ApplicationService, IEmailAppService
	{
		private readonly IEmailSender _emailSender;
		private readonly UrlHelper _urlHelper;
		public EmailAppService(IEmailSender emailSender, UrlHelper urlHelper)
		{
			_emailSender = emailSender;
			_urlHelper = urlHelper;

		}
		public async Task SendEmailAsync(string toEmail, string subject, string message)
		{



/*			MailMessage mail = new MailMessage();

			mail.From = new MailAddress("myInsureTech@outlook.com");
			mail.Subject = subject;
			mail.Body = message;
			mail.IsBodyHtml = true;
			mail.To.Add(new MailAddress(toEmail));

			var smtp = new SmtpClient
			{
				Host = "smtp-mail.outlook.com",
				EnableSsl = true
			};
			NetworkCredential NetworkCred = new NetworkCredential();
			NetworkCred.UserName = "myInsureTech@outlook.com";
			NetworkCred.Password = "Ash@1234";

			smtp.Credentials = NetworkCred;
			smtp.Port = 587;

			await smtp.SendMailAsync(mail);*/

		}
	}
	
}
