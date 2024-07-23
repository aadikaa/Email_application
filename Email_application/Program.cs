using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Define email details
        string toAddress = "deepak34201021@gmail.com"; // Replace with the recipient's email address
        string ccAddress = "cc-recipient@example.com"; // Replace with CC recipient's email address
        string bccAddress = "bcc-recipient@example.com"; // Replace with BCC recipient's email address
        string subject = "This is the Subject"; // Replace with the email subject
        string prompt = "Generate an email body about the latest project update."; // Prompt for LLaMA to generate email body

        // Create instances of services
        var aiService = new AIService();
        var emailService = new EmailService();

        // Generate the email body using LLaMA
        string body = await aiService.GenerateEmailBody(prompt);

        // Send the email
        emailService.SendEmail(toAddress, ccAddress, bccAddress, subject, body);
    }
}
