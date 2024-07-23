using System;
using System.Net;
using System.Net.Mail;

public class EmailService
{
    private readonly string _fromAddress;
    private readonly string _password;
    private readonly string _smtpServer;
    private readonly int _port;

    public EmailService()
    {
        // Initialize email settings (consider moving these to a configuration file)
        _fromAddress = "aadikabhatia30@gmail.com"; 
        _password = "Kiranpwd#4567"; // Replace with your email password
        _smtpServer = "smtp.google.com"; // Replace with your SMTP server
        _port = 587; // Replace with your SMTP port
    }

    public void SendEmail(string toAddress, string ccAddress, string bccAddress, string subject, string body)
    {
        try
        {
            // Create the email message
            var mail = new MailMessage
            {
                From = new MailAddress(_fromAddress),
                Subject = subject,
                Body = body
            };
            mail.To.Add(toAddress);
            if (!string.IsNullOrEmpty(ccAddress)) mail.CC.Add(ccAddress);
            if (!string.IsNullOrEmpty(bccAddress)) mail.Bcc.Add(bccAddress);

            // Configure the SMTP client
            using (var smtpClient = new SmtpClient(_smtpServer, _port)
            {
                Credentials = new NetworkCredential(_fromAddress, _password),
                EnableSsl = true
            })
            {
                // Send the email
                smtpClient.Send(mail);
                Console.WriteLine("Email sent successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while sending the email: " + ex.Message);
        }
    }
}
