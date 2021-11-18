using bitis.mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitisdemo.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);

        Task<Product> UpdateProduct(Product updatedProduct);
        Task<Product> AddProduct(Product product);
        Task DeleteProduct(int id);
    }
}
