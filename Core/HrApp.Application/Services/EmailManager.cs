﻿using HrApp.Application.EmailOptions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HrApp.Application.Interfaces;
using Microsoft.AspNetCore.WebUtilities;

namespace HrApp.Application.Services
{
    public class EmailManager : IEmailService
    {
        private readonly EmailOption _option;

        public EmailManager(IOptions<EmailOption> option)
        {
            _option = option.Value;
        }

        public async Task<string> GenerateNewPasswordMailBody (string id, string token) 
        {
            byte[] tokenGeneratedBytes = Encoding.UTF8.GetBytes(token);
            var codeEncoded = WebEncoders.Base64UrlEncode(tokenGeneratedBytes);

            var url = EmailComfirmLinkGenerator(codeEncoded, id);

            var html = $@"<html><head></head>
                        <body>
                                    <h2>Human Resources uygulamasına hoş geldiniz!</h2>
                            <a href = {url}> Adınıza oluşturulmuş hesabın şifresini belirlemek için tıklayınız!</a>
                        </body>
                       </html>";

            return html;
        }

        public void SendMail(string reciverMailAddress, string subject, string mailBody)
        {
            var smtpClient = new SmtpClient();

            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = smtpClient.DeliveryMethod;
            smtpClient.UseDefaultCredentials = false;

            smtpClient.Host = _option.ServiceEmailOption.Host;
            smtpClient.Port = _option.ServiceEmailOption.Port;
            smtpClient.Credentials = new NetworkCredential(_option.ServiceEmailOption.Email, _option.ServiceEmailOption.Password);

            var mailMessage = new MailMessage();

            mailMessage.From = new MailAddress(_option.ServiceEmailOption.Email);

            mailMessage.To.Add(reciverMailAddress);
            mailMessage.Subject = subject;
            mailMessage.Body = mailBody;
            mailMessage.IsBodyHtml = true;

            smtpClient.Send(mailMessage);  
        }

        private string EmailComfirmLinkGenerator(string token, string userId)
        {
            var link = "https://ank14hrmvc.azurewebsites.net/Personnel/PasswordChange";

            link += "?" + "token=" + token + "&userId=" + userId;

            return link;
        }
    }
}
