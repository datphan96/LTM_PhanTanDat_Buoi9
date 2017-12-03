using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace PhanTanDat_b9_bai1
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void SendMail_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();
            textBox1.MaxLength = 20;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox2 = new TextBox();
            textBox2.MaxLength = 8;
            textBox2.PasswordChar = '*';
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mailclient = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mailclient.From = new MailAddress("abc@gmail.com");
                mailclient.To.Add("vtysh@gmail.com");
                mailclient.Subject = "Test Mail";
                mailclient.Body = "Testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("abc@gmail.com", "p@assword");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mailclient);
                MessageBox.Show("Mail sent successfully !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("abc@gmail.com");
                mail.To.Add("vtysh@gmail.com");
                mail.Subject = "Test Mail 1";
                mail.Body = "Mail with attachment";

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment("your attachment file");
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("abc@gmail.com", "p@assword");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail with attachment sent successfully !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
