using bitis.mode;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitis.Api.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await appDbContext.Products.ToListAsync();
        }

        public async Task<Product> DeleteProduct(int id)
        {
            var result = await appDbContext.Products
                .FirstOrDefaultAsync(e => e.IdSp == id);
            if (result != null)
            {
                appDbContext.Products.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Product> GetProduct(int idSp)
        {
            return await appDbContext.Products
                .FirstOrDefaultAsync(e => e.IdSp == idSp);
        }

        public async Task<Product> AddProduct(Product product)
        {
            var result = await appDbContext.Products.AddAsync(product);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            var result = await appDbContext.Products
                .FirstOrDefaultAsync(e => e.IdSp == product.IdSp);

            if (result != null)
            {
                result.MaSp = product.MaSp;
                result.TenSp = product.TenSp;
                result.Gia = product.Gia;
                result.SoLuong = product.SoLuong;
                result.IdDanhMuc = product.IdDanhMuc;
                result.MoTaSp = product.MoTaSp;
                result.ChiTietSP = product.ChiTietSP;
                result.HinhSp = product.HinhSp;

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async Task<IEnumerable<Product>> Search(string name)
        {
            IQueryable<Product> query = appDbContext.Products;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.TenSp.Contains(name) ||
                  e.MaSp.Contains(name));
            }

            return await query.ToListAsync();
        }
    }
}

