using EMS.DbModelRepository.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace EMS.ManagerRepository.Manager
{
    public class EmailManager
    {
        public void SendEmailViaWebApi(Customer customer)
        {
            customer.UserPassword = DecodeFrom64(customer.UserPassword);
            var fromAddress = new MailAddress("emsnetwork2020@gmail.com", "Ems network");
            var toAddress = new MailAddress($"{customer.Email}", $"{customer.UserName}");
            //const string fromPassword = "pdwxutvhjjfqnwdy";
            const string fromPassword = "cukgiaknfjuflbbn";
            const string subject = "User profile creation confirmation in EMS";
            string body = Body(customer);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
        private string Body(Customer customer)
        {
            string htmlString = $@"
                         Dear Sir/Madam 

                         We warmly Welcome to SMARTFI(Let's save Resourses for our Next Generation) powered by VENLITE INDUSTRY LIMITED, 
                         1st in the country in this segment to offer Datalogger/RTU with WI - FI Mode of Communication
                         as an option the easy and intelligent way to Measure, Analyze Conto | &Manage all your assets of Electric,
                         Water, Automation and Gas consumption cost - effectively

                         You can access your Company Energy Profile by logging on to our website any time using following credentials
                         (User name and Password are case sensetive)

                         Link:
                         UserName: { customer.UserName}
                         Password: { customer.UserPassword}";




            return htmlString;
        }
        private string DecodeFrom64(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }
    }
}
