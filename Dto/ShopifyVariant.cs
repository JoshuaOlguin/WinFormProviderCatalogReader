using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormProviderCatalogReader.Dto
{
    public class ShopifyVariant
    {
        [JsonPropertyName("variant_id")]
        public string VariantId { get; set; } = string.Empty;

        [JsonPropertyName("sku")]
        public string Sku { get; set; } = string.Empty;

        [JsonPropertyName("barcode")]
        public string Barcode { get; set; } = string.Empty;

        [JsonPropertyName("price")]
        public string Price { get; set; } = string.Empty;

        [JsonPropertyName("list_price")]
        public string ListPrice { get; set; } = string.Empty;

        [JsonPropertyName("show_unit_price")]
        public string ShowUnitPrice { get; set; } = string.Empty;

        [JsonPropertyName("unit_price")]
        public string UnitPrice { get; set; } = string.Empty;

        [JsonPropertyName("unit_price_measurement")]
        public UnitPriceMeasurement UnitPriceMeasurement { get; set; } = new UnitPriceMeasurement();

        [JsonPropertyName("taxable")]
        public string Taxable { get; set; } = string.Empty;

        [JsonPropertyName("options")]
        public Dictionary<string, string> Options { get; set; } = new Dictionary<string, string>();

        [JsonPropertyName("available")]
        public string Available { get; set; } = string.Empty;

        [JsonPropertyName("search_variant_metafields_data")]
        public List<object> SearchVariantMetafieldsData { get; set; } = new List<object>();

        [JsonPropertyName("filter_variant_metafields_data")]
        public List<object> FilterVariantMetafieldsData { get; set; } = new List<object>();

        [JsonPropertyName("selling_plan_id")]
        public string SellingPlanId { get; set; } = string.Empty;

        [JsonPropertyName("image_link")]
        public string ImageLink { get; set; } = string.Empty;

        [JsonPropertyName("image_alt")]
        public string ImageAlt { get; set; } = string.Empty;

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

        [JsonPropertyName("quantity_total")]
        public string QuantityTotal { get; set; } = string.Empty;

        [JsonPropertyName("link")]
        public string Link { get; set; } = string.Empty;
    }
}
