using System.Text.Json.Serialization;

namespace ItemsBackend.Models
{
    public class EdpItemList
    {
        [JsonPropertyName("items")]
        public IList<EdpItem>? Items { get; set; }
    }
}
