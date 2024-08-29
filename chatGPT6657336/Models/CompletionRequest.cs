using System.Text.Json.Serialization;

namespace chatGPT6657336.Models
{
    public class CompletionRequest
    {
        [JsonPropertyName("model")]
        public string Model { get; set; } = "text-davinci-003";

        [JsonPropertyName("prompt")]
        public string Prompt {  get; set; }

        [JsonPropertyName("max_tokens")]
        public int Maxtokens { get; set; } = 100;

        [JsonPropertyName("temperature")]
        public int Temperature { get; set; } = 1;
    }
}