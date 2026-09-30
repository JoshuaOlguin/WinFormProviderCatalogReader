using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Drawing;
using WinFormProviderCatalogReader.Dto;
using WinFormProviderCatalogReader.Utilities;

namespace WinFormProviderCatalogReader
{
    public partial class Form1 : Form
    {

        private string apiKey = "7x7X2W9L3A";
        private int maxResults;
        private ProductResponse productResponse;
        private List<Item> items;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbProvider.Items.Add("Fixoem");
            System.Drawing.Font savedFont = new System.Drawing.Font(Properties.Settings.Default.FontName, (float)Properties.Settings.Default.FontSize);
            ApplyFont(this, savedFont);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxSearchParameter.Text))
            {
                ApiClientService client = new ApiClientService();

                try
                {
                    string apiResponse = await client.GetCatalogBySearchParameter(apiKey, Common.HtmlEncodeStringValue(txtBoxSearchParameter.Text));
                    JsonDocument document = JsonDocument.Parse(apiResponse);
                    maxResults = document.RootElement.GetProperty("totalItems").GetInt32();

                    string result = await client.GetCatalogBySearchParameter(apiKey, Common.HtmlEncodeStringValue(txtBoxSearchParameter.Text), maxResults);
                    productResponse = Common.DeserializeResponse<ProductResponse>(result);

                    items = Adapter.ConvertProductResponseItemsToItemList(productResponse);
                    MessageBox.Show("Obtención de catalogo del provedor completada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce el nombre del artículo que deseas buscar.", "Error Operacion invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string defaultFileName = $"{txtBoxSearchParameter.Text}";
                saveFileDialog.Title = "Select a folder";
                saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = defaultFileName;
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    Excel.CreateFile(filePath);
                    Excel.PopulateExcelFile(filePath, items);

                    MessageBox.Show("Archivo excel generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                ApplyFont(this, fontDialog.Font);
                Properties.Settings.Default.FontName = fontDialog.Font.FontFamily.Name;
                Properties.Settings.Default.FontSize = fontDialog.Font.Size;
                Properties.Settings.Default.Save();
            }
        }

        private void ApplyFont(Control control, System.Drawing.Font newFont)
        {
            control.Font = newFont;

            foreach (Control ctrl in control.Controls)
            {
                ApplyFont(ctrl, newFont);
            }
        }
    }
}
