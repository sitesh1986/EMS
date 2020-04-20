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
             string body = $"Congratulation of creating your profile in EMS your credential details are Email-{customer.Email} and password-{customer.UserPassword} please login to ems app and change your password";

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
