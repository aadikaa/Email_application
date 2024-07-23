using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class AIService
{
    private readonly string _apiUrl;
    private readonly string _apiKey;

    public AIService()
    {
        _apiUrl = "https://huggingface.co/models/meta-llama/Meta-Llama-3-8B"; // Replace with the actual API endpoint
        _apiKey = "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"; // Replace with your API key
    }

    public async Task<string> GenerateEmailBody(string prompt)
    {
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");

            // Build the request body as a string
            string requestBody = $"{{\"prompt\":\"{prompt}\",\"max_tokens\":150,\"temperature\":0.7}}";

            // Send the request
            var response = await client.PostAsync(_apiUrl, new StringContent(requestBody, Encoding.UTF8, "application/json"));
            var responseData = await response.Content.ReadAsStringAsync();

            // Assuming the response is simple and does not require complex JSON parsing
            int textStartIndex = responseData.IndexOf("\"text\":\"") + 8;
            int textEndIndex = responseData.IndexOf("\"", textStartIndex);
            string generatedText = responseData.Substring(textStartIndex, textEndIndex - textStartIndex).Trim();

            return generatedText ?? "Default email body due to error.";
        }
    }
}
