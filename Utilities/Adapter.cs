using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WinFormProviderCatalogReader.Dto;

namespace WinFormProviderCatalogReader.Utilities
{
    public class Adapter
    {
        /// <summary>
        /// Converts a ProductResponse to a list of Item objects.
        /// </summary>
        /// <param name="productResponse">The product response containing items to convert.</param>
        /// <returns>A list of Item objects with code, price, and image information.</returns>
        /// <remarks>
        /// The distributor price is parsed from the product price string using currency and number formats.
        /// If the price cannot be parsed, the distributor price defaults to 0.
        /// </remarks>
        public static List<Item> ConvertProductResponseItemsToItemList(ProductResponse productResponse)
        {
            return productResponse.Items.Select(p =>
            {
                decimal distributorPrice = 0m;
                if (!string.IsNullOrWhiteSpace(p.Price))
                {
                    decimal.TryParse(p.Price, NumberStyles.Currency | NumberStyles.Number, CultureInfo.InvariantCulture, out distributorPrice);
                }

                return new Item
                {
                    Code = "SYS",
                    Name = p.Title,
                    DistributorPrice = distributorPrice,
                    Image = p.ImageLink
                };
            }).ToList();
        }
    }
}
