using System.Text.Json.Serialization;

namespace WinFormProviderCatalogReader.Dto
{
    public class UnitPriceMeasurement
    {
        [JsonPropertyName("measuredType")]
        public string MeasuredType { get; set; } = string.Empty;

        [JsonPropertyName("quantityUnit")]
        public string QuantityUnit { get; set; } = string.Empty;

        [JsonPropertyName("quantityValue")]
        public string QuantityValue { get; set; } = string.Empty;

        [JsonPropertyName("referenceUnit")]
        public string ReferenceUnit { get; set; } = string.Empty;

        [JsonPropertyName("referenceValue")]
        public string ReferenceValue { get; set; } = string.Empty;
    }
}
