using bitis.mode;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitis.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Seed Departments Table
            modelBuilder.Entity<Category>().HasData(
                new Category { IdDanhMuc = 1, TenDanhMuc = "Giày Nam" });
            modelBuilder.Entity<Category>().HasData(
                new Category { IdDanhMuc = 2, TenDanhMuc = "Giày nữ" });
            modelBuilder.Entity<Category>().HasData(
                new Category { IdDanhMuc = 3, TenDanhMuc = "Giày thể thao" });
            modelBuilder.Entity<Category>().HasData(
                new Category { IdDanhMuc = 4, TenDanhMuc = "Giày Tây" });
            modelBuilder.Entity<Category>().HasData(
                new Category { IdDanhMuc = 5, TenDanhMuc = "Túi xách" });
            modelBuilder.Entity<Category>().HasData(
                new Category { IdDanhMuc = 6, TenDanhMuc = "Phụ Kiện" });


            // Seed Employee Table
            modelBuilder.Entity<Product>().HasData(new Product
            {
                IdSp = 1,
                MaSp = "aaasss",
                TenSp = "Giày Nam",
                Gia = 100000,
                SoLuong = 100,
                IdDanhMuc = 1,
                MoTaSp = "adshjklahbjjkd",
                ChiTietSP = "là 1 thương hiêu nổi tieeng",
                HinhSp = "asset/img/sp1.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                IdSp = 2,
                MaSp = "a",
                TenSp = "Giày nam đế cao",
                Gia = 120000,
                SoLuong = 100,
                IdDanhMuc = 2,
                MoTaSp = "a",
                ChiTietSP = "là 1 thương hiêu nổi tieeng",
                HinhSp = "asset/img/sp2.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                IdSp = 3,
                MaSp = "sss",
                TenSp = "Giày nu ",
                Gia = 200000,
                SoLuong = 200,
                IdDanhMuc = 1,
                MoTaSp = "adsđa",
                ChiTietSP = "là 1 thương hiêu nổi tieeng",
                HinhSp = "asset/img/sp3.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {

                IdSp = 4,
                MaSp = "sssccccs",
                TenSp = "giày nu ssssdsfs",
                Gia = 2030000,
                SoLuong = 200,
                IdDanhMuc = 3,
                MoTaSp = "adsdfđfgfdfggfghnghjhghjjyhjjhđa",
                ChiTietSP = "là 1 thương hiêu nổi tieeng",
                HinhSp = "asset/img/sp4.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                IdSp = 5,
                MaSp = "p",
                TenSp = "phụ kiện ",
                Gia = 200000,
                SoLuong = 200,
                IdDanhMuc = 4,
                MoTaSp = "adsđa",
                ChiTietSP = "là 1 thương hiêu nổi tieeng",
                HinhSp = "asset/img/sp5.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                IdSp = 6,
                MaSp = "faaffafaf",
                TenSp = "túi sahs ",
                Gia = 200000,
                SoLuong = 200,
                IdDanhMuc = 1,
                MoTaSp = "adsđa",
                ChiTietSP = "là 1 thương hiêu nổi tieeng",
                HinhSp = "asset/img/sp6.jpg"
            });

        }

    }
}