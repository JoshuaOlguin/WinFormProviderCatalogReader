using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WinFormProviderCatalogReader.Utilities
{
    /// <summary>
    /// Custom JSON converter that converts numeric values to strings during deserialization.
    /// This handles cases where the API returns numeric prices but the DTO expects string values.
    /// </summary>
    public class StringNumberConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    return reader.GetString();
                case JsonTokenType.Number:
                    // Convert numeric value to string
                    if (reader.TryGetDecimal(out decimal decimalValue))
                    {
                        return decimalValue.ToString();
                    }
                    else if (reader.TryGetInt64(out long longValue))
                    {
                        return longValue.ToString();
                    }
                    else if (reader.TryGetDouble(out double doubleValue))
                    {
                        return doubleValue.ToString();
                    }
                    break;
                case JsonTokenType.Null:
                    return string.Empty;
            }

            throw new JsonException($"Unable to convert token of type {reader.TokenType} to string.");
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }

}
