using bitis.mode;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace bitisdemo.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient httpClient;

        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Category> GetCategory(int id)
        {
            return await httpClient.GetJsonAsync<Category>($"api/categorys/{id}");
        }

        public async Task<IEnumerable<Category>> GetCategorys()
        {
            return await httpClient.GetJsonAsync<Category[]>("api/categorys");
        }
    }
}
