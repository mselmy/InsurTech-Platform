using Abp.MailKit;
using Abp.Net.Mail.Smtp;
using MailKit.Net.Smtp;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace insurtech
{
    public class MyMailKitSmtpBuilder : DefaultMailKitSmtpBuilder
    {
        public MyMailKitSmtpBuilder(ISmtpEmailSenderConfiguration smtpEmailSenderConfiguration, IAbpMailKitConfiguration abpMailKitConfiguration) : base(smtpEmailSenderConfiguration, abpMailKitConfiguration)
        {
        }

        protected override void ConfigureClient(SmtpClient client)
        {
            client.ServerCertificateValidationCallback = (s, c, h, e) => true;

//            client.CheckCertificateRevocation = false;

//            client.SslProtocols = SslProtocols.Ssl3 | SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12 | SslProtocols.Tls13;


//            client.Connect("smtp-mail.outlook.com", 465, true);
//            /*
//             * NetworkCred.UserName = "myInsureTech@outlook.com";
//NetworkCred.Password = "Ash@1234"
//             */

//            client.Authenticate("myInsureTech@outlook.com", "Ash@1234");

            base.ConfigureClient(client);

        }
    }
}
