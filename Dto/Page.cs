using System.Text.Json.Serialization;

namespace WinFormProviderCatalogReader.Dto
{
    public class Page
    {
        [JsonPropertyName("page_id")]
        public string PageId { get; set; } = string.Empty;

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
