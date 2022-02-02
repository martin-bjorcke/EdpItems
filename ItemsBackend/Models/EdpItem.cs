using System.Text.Json.Serialization;

namespace ItemsBackend.Models
{
    public class EdpItem
    {
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("hobby")]
        public string? Hobby { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }

    }
}
