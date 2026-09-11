using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WinFormProviderCatalogReader
{
    public class ApiClientService
    {
        public async Task<string> GetCatalogBySearchParameter(string apiKey, string searchParameter, int numberItems = 1)
        {
            string apiUrl = $"https://searchserverapi1.com/getresults?api_key={apiKey}&q={searchParameter}&sortBy=relevance&sortOrder=desc&restrictBy%5Bshopify_market_catalogs%5D=13781467426&startIndex=0&maxResults={numberItems}&items=true&pages=true&categories=true&suggestions=true";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        return result;
                    }
                    else
                    {
                        Console.WriteLine($"Request failed with status code: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error calling API: {ex.Message}");
                    throw;
                }
            }
        }
    }
}
