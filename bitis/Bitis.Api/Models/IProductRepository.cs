using bitis.mode;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bitis.Api.Models
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int idSp);
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<Product> DeleteProduct(int idSp);
        Task<IEnumerable<Product>> Search(string name);

    }
}