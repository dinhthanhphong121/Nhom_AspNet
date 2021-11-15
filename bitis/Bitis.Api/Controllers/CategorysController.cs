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
    public class CategorysController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategorysController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetCategorys()
        {
            try
            {
                return Ok(await categoryRepository.GetCategorys());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            try
            {
                var result = await categoryRepository.GetCategory(id);

                if (result == null)
                {
                    return NotFound();
                }
      
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi tu server");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            try
            {
                if (category == null)
                    return BadRequest();

                var createdCategory = await categoryRepository.AddCategory(category);

                return CreatedAtAction(nameof(GetCategory),
                    new { id = createdCategory.IdDanhMuc }, createdCategory);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi khi them danh muc moi");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Category>> UpdateCategory(int id, Category category)
        {
            try
            {
                if (id != category.IdDanhMuc)
                    return BadRequest("Ma so ID khong khop");

                var categoryToUpdate = await categoryRepository.GetCategory(id);

                if (categoryToUpdate == null)
                {
                    return NotFound($"Khong tim thay danh muc voi Id = {id}");
                }
                return await categoryRepository.UpdateCategory(category);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Loi khi cap nhat danh muc");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Category>> DeleteCategory(int id)
        {
            try
            {
                var categoryToDelete = categoryRepository.GetCategory(id);
                if (categoryToDelete == null)
                {
                    return NotFound($"Khong tim thay nhan vien co Id = {id}");
                }

                return await categoryRepository.DeleteCategory(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Loi khi xoa nhan vien");
            }
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Category>>> Search(string name)
        {
            try
            {
                var result = await categoryRepository.Search(name);

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
