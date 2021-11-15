using bitis.mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitisdemo.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategorys();
        Task<Category> GetCategory(int id);
    }
}
