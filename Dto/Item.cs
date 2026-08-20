
namespace WinFormProviderCatalogReader.Dto
{
    public class Item
    {
        /// <summary>
        /// Codigo (SKU)
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Codigo alternativo
        /// </summary>
        public string AlternativeCode { get; set; }

        /// <summary>
        /// Nombre  Stock (Existencia)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Precio compra
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Precio publico
        /// </summary>
        public decimal RetailPrice { get; set; }

        /// <summary>
        /// Precio mayoreo
        /// </summary>
        public decimal WholesalePrice { get; set; }

        /// <summary>
        /// Precio distribuidor
        /// </summary>
        public decimal DistributorPrice { get; set; }

        /// <summary>
        /// Precio 4
        /// </summary>
        public decimal Price4 { get; set; }

        /// <summary>
        /// Precio 5
        /// </summary>
        public decimal Price5 { get; set; }

        /// <summary>
        /// Precio 6
        /// </summary>
        public decimal Price6 { get; set; }

        /// <summary>
        /// Descripcion larga
        /// </summary>
        public string LongDescription { get; set; }

        /// <summary>
        /// Stock min
        /// </summary>
        public int MinStock { get; set; }

        /// <summary>
        /// Stock max
        /// </summary>
        public int MaxStock { get; set; }

        /// <summary>
        /// Proveedor
        /// </summary>
        public string Supplier { get; set; }

        /// <summary>
        /// Imagen
        /// </summary>
        public string Image { get; set; }
    }
}
