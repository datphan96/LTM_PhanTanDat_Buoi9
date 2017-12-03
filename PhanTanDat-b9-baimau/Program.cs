using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace PhanTanDat_b9_baimau
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
            mailclient.EnableSsl = true;
            mailclient.Credentials = new NetworkCredential("abc@gmail.com","p@assword");
            MailMessage message = new MailMessage("abc@gmail.com","vtysh@gmail.com");
            message.Subject = "Hello Client !";
            message.Body = "Test mail client";
            mailclient.Send(message);
            Console.WriteLine("Mail sent successfully !");

            //Gửi kèm tệp tin Attachments
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("abc@gmail.com");
            mail.To.Add("vtysh@gmail.com");
            mail.Subject = "Test mail attachment";
            mail.Body = "Mail with attachment";
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("d:/abc.txt");
            mail.Attachments.Add(attachment);
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("abc@gmail.com", "p@assword");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
            Console.WriteLine("Mail with attachment sent successfully !")
        }
    }
}

