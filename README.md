## Project Report: Email Sending Console Application with AI-Generated Content

### Project Overview

This project is a C# console application designed to send emails with content generated by an AI service. The AI service, LLaMA, is used to automatically generate the email body based on a provided prompt. The project demonstrates integration with an AI API and an SMTP server for email delivery.

### Project Structure

The project consists of the following main components:
- **AIService**: Responsible for interacting with the AI API to generate email content.
- **EmailService**: Handles email sending using the SMTP protocol.
- **Program.cs**: The entry point of the application, orchestrating the use of AIService and EmailService.

### Implementation Details

#### 1. AIService

The `AIService` class is responsible for generating email content using the LLaMA API. It constructs an HTTP request to the API with the provided prompt and processes the response to extract the generated text.

#### 2. EmailService

The `EmailService` class handles the construction and sending of emails using SMTP. It uses the provided SMTP server, port, and credentials to authenticate and send the email.

#### 3. Program.cs

The `Program.cs` file is the entry point of the application. It creates instances of `AIService` and `EmailService`, generates the email body using the AI service, and sends the email using the email service.

### Steps to Run the Project

1. **Install Dependencies**:
   Make sure you have the `Newtonsoft.Json` package installed:
   ```sh
   dotnet add package Newtonsoft.Json
   ```

2. **Update Configuration**:
   Ensure you replace placeholders like `your-email@example.com`, `your-email-password`, `smtp.example.com`, and `YOUR_API_KEY` with actual values.

3. **Run the Project**:
   Use the .NET CLI or an IDE like Visual Studio to run your project.

### Expected Output

**Console Output**:
- Messages indicating the progress and result of the email sending process.

**Email**:
- The recipient should receive an email generated by the AI with the subject and body specified.

### Conclusion

This project demonstrates the integration of an AI service for generating email content and an SMTP server for sending emails. The detailed logging ensures that any issues can be quickly identified and resolved, making it a valuable addition to your resume for showcasing your C# skills and experience with API integration.
