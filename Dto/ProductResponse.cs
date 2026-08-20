using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WinFormProviderCatalogReader.Dto
{
    public class ProductResponse
    {
        [JsonPropertyName("totalItems")]
        public int TotalItems { get; set; }

        [JsonPropertyName("startIndex")]
        public int StartIndex { get; set; }

        [JsonPropertyName("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonPropertyName("currentItemCount")]
        public int CurrentItemCount { get; set; }

        [JsonPropertyName("categoryStartIndex")]
        public int CategoryStartIndex { get; set; }

        [JsonPropertyName("totalCategories")]
        public int TotalCategories { get; set; }

        [JsonPropertyName("pageStartIndex")]
        public int PageStartIndex { get; set; }

        [JsonPropertyName("totalPages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; } = new List<Category>();

        [JsonPropertyName("pages")]
        public List<Page> Pages { get; set; } = new List<Page>();

        [JsonPropertyName("items")]
        public List<Product> Items { get; set; } = new List<Product>();
    }
}
