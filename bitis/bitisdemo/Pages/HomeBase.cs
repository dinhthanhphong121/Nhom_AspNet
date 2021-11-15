using bitis.mode;
using bitisdemo.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitisdemo.Pages
{
    public class HomeBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }


        public IEnumerable<Product> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //await Task.Run(LoadProducts);
            Products = (await ProductService.GetProducts()).ToList();
        }

        public bool ShowFooter { get; set; } = true;


        private void LoadProducts()
        {
            Product p1 = new Product
            {
                IdSp = 1,
                MaSp = "aaasss",
                TenSp = "Giày nam",
                Gia = 100000,
                SoLuong = 100,
                IdDanhMuc = 1,
                MoTaSp = "adshjklahbjjkd",
                ChiTietSP = "là 1 thương hiêu nổi tieeng",
                HinhSp = "asset/img/sp1.jpg"
            };

            Product p2 = new Product
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
            };
            Product p3 = new Product
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
            };

            Product p4 = new Product
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
            };
            Product p5 = new Product
            {
                IdSp = 5,
                MaSp = "p",
                TenSp = "Phụ kiện ",
                Gia = 200000,
                SoLuong = 200,
                IdDanhMuc = 4,
                MoTaSp = "adsđa",
                ChiTietSP = "là 1 thương hiêu nổi tieeng",
                HinhSp = "asset/img/sp5.jpg"
            };
            Product p6 = new Product
            {
                IdSp = 6,
                MaSp = "faaffafaf",
                TenSp = "túi sách ",
                Gia = 200000,
                SoLuong = 200,
                IdDanhMuc = 1,
                MoTaSp = "adsđa",
                ChiTietSP = "là 1 thương hiêu nổi tieeng",
                HinhSp = "asset/img/sp6.jpg"
            };

            Products = new List<Product> { p1, p2, p3, p4, p5, p6 };
        }
    }
}

