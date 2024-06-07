using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.EmailSender
{
	public interface IEmailAppService
	{
		Task SendEmailAsync(string email, string subject, string message);
	}
}
	