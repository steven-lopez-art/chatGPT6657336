using chatGPT6657336.Helpers;
using chatGPT6657336.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace chatGPT6657336.Services
{
    public class OpenIAService : IOpenIAService
    {
        HttpClient client;

        JsonSerializerOptions options = new() { PropertyNameCaseInsensitive = true};

        public OpenIAService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(Constants.OpenAIURL); ;
            client.DefaultRequestHeaders.Authorization = 
                new AuthenticationHeaderValue("Bearer", Constants.OpenAIToken);
            client.DefaultRequestHeaders.Accept.Add(new 
                MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> AskQuestion(string query)
        {
            
            var completion = new CompletionRequest()
            {
                Prompt = query
            };

            //var body = JsonSerializer.Serialize(completion);
            //var content = new StringContent(body, Encoding.UTF8, "application/json");

            var response = await client.PostAsJsonAsync(
                Constants.OpenAIEndpoint_Completions, completion);


            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content
                    .ReadFromJsonAsync<CompletionResponse>();

                return data?.Choice?.FirstOrDefault().Text;
            }
            return default;
        }
    }
}
