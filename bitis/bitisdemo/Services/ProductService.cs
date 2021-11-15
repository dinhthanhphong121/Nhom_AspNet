using bitis.mode;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace bitisdemo.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Product> GetProduct(int id)
        {
            return await httpClient.GetJsonAsync<Product>($"api/products/{id}");
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await httpClient.GetJsonAsync<Product[]>("api/products");
        }

    }
}
