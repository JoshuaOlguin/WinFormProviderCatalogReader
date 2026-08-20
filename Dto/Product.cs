using System.Collections.Generic;
using System.Text.Json.Serialization;
using WinFormProviderCatalogReader.Utilities;


namespace WinFormProviderCatalogReader.Dto
{
    public class Product
    {
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; } = string.Empty;

        [JsonPropertyName("original_product_id")]
        public string OriginalProductId { get; set; } = string.Empty;

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("link")]
        public string Link { get; set; } = string.Empty;

        [JsonPropertyName("price")]
        [JsonConverter(typeof(StringNumberConverter))]
        public string Price { get; set; } = string.Empty;

        [JsonPropertyName("list_price")]
        [JsonConverter(typeof(StringNumberConverter))]
        public string ListPrice { get; set; } = string.Empty;

        [JsonPropertyName("quantity")]
        public string Quantity { get; set; } = string.Empty;

        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        [JsonPropertyName("image_link")]
        public string ImageLink { get; set; } = string.Empty;

        [JsonPropertyName("vendor")]
        public string Vendor { get; set; } = string.Empty;

        [JsonPropertyName("discount")]
        public string Discount { get; set; } = string.Empty;

        [JsonPropertyName("add_to_cart_id")]
        public string AddToCartId { get; set; } = string.Empty;

        [JsonPropertyName("add_to_cart_selling_plan_id")]
        public string AddToCartSellingPlanId { get; set; } = string.Empty;

        [JsonPropertyName("selling_plan_id")]
        public string SellingPlanId { get; set; } = string.Empty;

        [JsonPropertyName("requires_selling_plan")]
        public string RequiresSellingPlan { get; set; } = string.Empty;

        [JsonPropertyName("total_reviews")]
        public string TotalReviews { get; set; } = string.Empty;

        [JsonPropertyName("reviews_average_score")]
        public string ReviewsAverageScore { get; set; } = string.Empty;

        [JsonPropertyName("shopify_variants")]
        public List<ShopifyVariant> ShopifyVariants { get; set; } = new List<ShopifyVariant>();

        [JsonPropertyName("shopify_images")]
        public List<string> ShopifyImages { get; set; } = new List<string>();

        [JsonPropertyName("shopify_images_alt")]
        public List<string> ShopifyImagesAlt { get; set; } = new List<string>();

        [JsonPropertyName("tags")]
        public string Tags { get; set; } = string.Empty;

        [JsonPropertyName("quantity_total")]
        public string QuantityTotal { get; set; } = string.Empty;

        [JsonPropertyName("quantity_at_location_33331740747")]
        public string QuantityAtLocation33331740747 { get; set; } = string.Empty;

        [JsonPropertyName("quantity_at_location_36497621067")]
        public string QuantityAtLocation36497621067 { get; set; } = string.Empty;

        [JsonPropertyName("quantity_at_location_60907257931")]
        public string QuantityAtLocation60907257931 { get; set; } = string.Empty;

        [JsonPropertyName("quantity_at_location_95186059554")]
        public string QuantityAtLocation95186059554 { get; set; } = string.Empty;

        [JsonPropertyName("quantity_at_location_102034047266")]
        public string QuantityAtLocation102034047266 { get; set; } = string.Empty;

        [JsonPropertyName("quantity_at_location_104483127586")]
        public string QuantityAtLocation104483127586 { get; set; } = string.Empty;

        [JsonPropertyName("quantity_at_location_105435693346")]
        public string QuantityAtLocation105435693346 { get; set; } = string.Empty;

        [JsonPropertyName("quantity_at_location_107999363362")]
        public string QuantityAtLocation107999363362 { get; set; } = string.Empty;

        [JsonPropertyName("quantity_at_location_112407413026")]
        public string QuantityAtLocation112407413026 { get; set; } = string.Empty;

        [JsonPropertyName("collections")]
        public string Collections { get; set; } = string.Empty;
    }
}
