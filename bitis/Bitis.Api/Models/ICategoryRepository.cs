using bitis.mode;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bitis.Api.Models
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategorys();
        Task<Category> GetCategory(int idDanhMuc);
        Task<Category> AddCategory(Category category);
        Task<Category> UpdateCategory(Category category);
        Task<Category> DeleteCategory(int IdDanhMuc);
        Task<IEnumerable<Category>> Search(string name);
    }
}