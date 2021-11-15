using bitis.mode;
using Bitis.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitis.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            try
            {
                return Ok(await productRepository.GetProducts());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            try
            {
                var result = await productRepository.GetProduct(id);

                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi tu server");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            try
            {
                if (product == null)
                    return BadRequest();

                var createdProduct = await productRepository.AddProduct(product);

                return CreatedAtAction(nameof(GetProduct),
                    new { id = createdProduct.IdSp }, createdProduct);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi khi tao san pham moi");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Product>> UpdateProduct(int id, Product product)
        {
            try
            {
                if (id != product.IdSp)
                    return BadRequest("Ma so ID khong khop");

                var employeeToUpdate = await productRepository.GetProduct(id);

                if (employeeToUpdate == null)
                {
                    return NotFound($"Khong tim thay san pham voi Id = {id}");
                }
                return await productRepository.UpdateProduct(product);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Loi khi cap nhat san pham");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            try
            {
                var productToDelete = productRepository.GetProduct(id);
                if (productToDelete == null)
                {
                    return NotFound($"Khong tim thay nhan vien co Id = {id}");
                }

                return await productRepository.DeleteProduct(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Loi khi xoa nhan vien");
            }
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Product>>> Search(string name)
        {
            try
            {
                var result = await productRepository.Search(name);

                if (result.Any())
                {
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Loi khi lay du lieu tu CSDL");
            }
        }
    }
}