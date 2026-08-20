using ClosedXML.Excel;
using WinFormProviderCatalogReader.Dto;
using System.Collections.Generic;
using System.IO;

namespace WinFormProviderCatalogReader.Utilities
{
    public class Excel
    {
        /// <summary>
        /// Creates a new Excel file at the specified file path.
        /// </summary>
        /// <param name="filePath">The full path where the Excel file will be created.</param>
        public static void CreateFile(string filePath)
        {
            string[] headers =
            { "Codigo (SKU)", "Codigo alternativo", "Nombre  Stock (Existencia)", "Precio compra", "Precio publico", "Precio mayoreo", "Precio distribuidor", "Precio 4", "Precio 5", "Precio 6", "Descripcion larga", "Stock min", "Stock max", "Proveedor", "Imagen" };

            XLWorkbook workbook;

            if (File.Exists(filePath))
            {
                workbook = new XLWorkbook(filePath);
            }
            else
            {
                workbook = new XLWorkbook();
            }

            try
            {
                IXLWorksheet worksheet;

                // Get the first sheet or create one if there are no sheets
                if (workbook.Worksheets.Count > 0)
                {
                    worksheet = workbook.Worksheet(1);
                }
                else
                {
                    worksheet = workbook.Worksheets.Add("Productos");
                }

                // Add headers to the first row
                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet.Cell(1, i + 1).Value = headers[i];
                }

                // Format headers
                var headerRange = worksheet.Range(
                    1,
                    1,
                    1,
                    headers.Length);

                headerRange.Style.Font.Bold = true;
                //headerRange.Style.Fill.BackgroundColor = XLColor.Blue;

                // Adjust column widths
                worksheet.Columns().AdjustToContents();

                // Save the file
                workbook.SaveAs(filePath);
            }
            finally
            {
                workbook.Dispose();
            }
        }

        /// <summary>
        /// Populates an Excel file with product pricing and inventory data.
        /// </summary>
        /// <param name="filePath">The full path to the Excel file to populate.</param>
        /// <param name="products">A list of Item objects containing the data to write to the Excel file.</param>
        /// <exception cref="FileNotFoundException">Thrown when the Excel file at the specified filePath does not exist.</exception>
        /// <remarks>
        /// The method writes product data starting from the first empty row after existing data.
        /// Columns 1-7 are formatted as currency with two decimal places.
        /// Column widths are automatically adjusted to fit the content.
        /// </remarks>
        public static void PopulateExcelFile(string filePath, List<Item> products)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(
                    "The Excel file does not exist.",
                    filePath);
            }

            var workbook = new XLWorkbook(filePath);

            // Get the first worksheet
            var worksheet = workbook.Worksheet(1);

            // Find the first empty row after the existing data
            int row = worksheet.LastRowUsed()?.RowNumber() + 1 ?? 2;

            foreach (var product in products)
            {
                //Codigo (SKU)
                worksheet.Cell(row, 1).Value = product.Code;
                //Codigo alternativo
                worksheet.Cell(row, 2).Value = product.AlternativeCode;
                //Nombre  Stock (Existencia)
                worksheet.Cell(row, 3).Value = product.Name;
                //Precio compra
                worksheet.Cell(row, 4).Value = product.PurchasePrice;
                //Precio publico
                worksheet.Cell(row, 5).Value = product.RetailPrice;
                //Precio mayoreo
                worksheet.Cell(row, 6).Value = product.WholesalePrice;
                //Precio distribuidor
                worksheet.Cell(row, 7).Value = product.DistributorPrice;
                //Precio 4
                worksheet.Cell(row, 8).Value = product.Price4;
                //Precio 5
                worksheet.Cell(row, 9).Value = product.Price5;
                //Precio 6
                worksheet.Cell(row, 10).Value = product.Price6;
                //Descripcion larga
                worksheet.Cell(row, 11).Value = product.LongDescription;
                //Stock min
                worksheet.Cell(row, 12).Value = product.MinStock;
                //Stock max
                worksheet.Cell(row, 13).Value = product.MaxStock;
                //Proveedor
                worksheet.Cell(row, 14).Value = product.Supplier;
                //Imagen
                worksheet.Cell(row, 15).Value = product.Image;
                row++;
            }

            // Format price columns
            worksheet.Columns(1, 7).Style.NumberFormat.Format = "$#,##0.00";

            // Adjust columns
            worksheet.Columns().AdjustToContents();

            // Save changes
            workbook.Save();
        }
    }
}
