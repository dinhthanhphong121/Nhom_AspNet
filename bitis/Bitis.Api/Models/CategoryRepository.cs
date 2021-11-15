using bitis.mode;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitis.Api.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Category> GetCategory(int idDanhMuc)
        {
            return await appDbContext.Categorys
                .FirstOrDefaultAsync(d => d.IdDanhMuc == idDanhMuc);
        }

        public async Task<IEnumerable<Category>> GetCategorys()
        {
            return await appDbContext.Categorys.ToListAsync();
        }

        public async Task<Category> DeleteCategory(int IdDanhMuc)
        {
            var result = await appDbContext.Categorys
                .FirstOrDefaultAsync(e => e.IdDanhMuc == IdDanhMuc);
            if (result != null)
            {
                appDbContext.Categorys.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Category> AddCategory(Category category)
        {
            var result = await appDbContext.Categorys.AddAsync(category);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            var result = await appDbContext.Categorys
                .FirstOrDefaultAsync(e => e.IdDanhMuc == category.IdDanhMuc);

            if (result != null)
            {
                result.TenDanhMuc = category.TenDanhMuc;
                
                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async Task<IEnumerable<Category>> Search(string name)
        {
            IQueryable<Category> query = appDbContext.Categorys;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.TenDanhMuc.Contains(name));
            }

            return await query.ToListAsync();
        }
    }
}
