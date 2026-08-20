using System.Text.Json.Serialization;

namespace WinFormProviderCatalogReader.Dto
{
    public class Category
    {
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; } = string.Empty;

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("link")]
        public string Link { get; set; } = string.Empty;

        [JsonPropertyName("image_link")]
        public string ImageLink { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
    }
}
