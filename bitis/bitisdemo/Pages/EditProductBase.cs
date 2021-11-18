using bitis.mode;
using bitisdemo.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bitisdemo.Pages
{
    public class EditProductBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        public Product Product { get; set; } = new Product();

        [Inject]
        public ICategoryService CategoryService { get; set; }
        public List<Category> Categorys { get; set; } = new List<Category>();
        public string IdDanhMuc { get; set; }


        [Required(ErrorMessage = "Nhập giá sản phẩm")]
        public string Gia { get; set; }
        [Required(ErrorMessage = "Nhập số lượng sản phẩm")]
        public string SoLuong { get; set; }

        
        [Parameter]
        public string Id { get; set; }

        
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            int.TryParse(Id, out int productId);
            if (productId != 0)
            {
                Product = await ProductService.GetProduct(int.Parse(Id));
                IdDanhMuc = Product.IdDanhMuc.ToString();

                Gia = Product.Gia.ToString();
                SoLuong = Product.SoLuong.ToString();
            }
            else
            {
                Product = new Product
                {
                };
            }

            Categorys = (await CategoryService.GetCategorys()).ToList();
            
        }

        protected async Task HandleValidSubmit()
        {
            Product result = null;
            if (Product.IdSp != 0)
            {
                result = await ProductService.UpdateProduct(Product);
            }
            else
            {
                result = await ProductService.AddProduct(Product);
            }

            
            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
        protected async Task Delete_Click()
        {
            await ProductService.DeleteProduct(Product.IdSp);
            NavigationManager.NavigateTo("/");
        }
    }
}
