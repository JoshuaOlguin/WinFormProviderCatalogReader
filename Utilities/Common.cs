using System.Text.Json;
using System.Net;

namespace WinFormProviderCatalogReader.Utilities
{
    public class Common
    {
        /// <summary>
        /// Deserializes a JSON response string into the specified type.
        /// </summary>
        /// <typeparam name="T">The type to deserialize the response into.</typeparam>
        /// <param name="response">The JSON response string to deserialize.</param>
        /// <returns>An instance of type <typeparamref name="T"/> deserialized from the response.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="response"/> is null or empty.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the response cannot be deserialized into type <typeparamref name="T"/>.</exception>
        public static T DeserializeResponse<T>(string response)
        {
            return JsonSerializer.Deserialize<T>(response);
        }

        /// <summary>
        /// Encodes a string for use in HTML.
        /// </summary>
        /// <param name="text">The string to encode.</param>
        /// <returns>The encoded string.</returns>
        public static string HtmlEncodeStringValue(string text)
        {
            return WebUtility.UrlEncode(text);
        }
    }
}
