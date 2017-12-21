using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace TestCrous_1._0._2
{
    public class Productt
    {
        public string id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }
    }

    public class Http
    {
        static HttpClient client = new HttpClient();

        static void ShowProduct(Productt productt)
        {
            Console.WriteLine($"Name: {productt.name}\tPrice: " +
                $"{productt.price}\tCategory: {productt.category}");
        }

        

        static async Task<HttpStatusCode> DeleteProductAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/products/{id}");
            return response.StatusCode;
        }

       
        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("10.0.2.26");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Create a new product
                Productt productt = new Productt();
                
               
                // Delete the product
                var statusCode = await DeleteProductAsync(productt.id);
                Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}