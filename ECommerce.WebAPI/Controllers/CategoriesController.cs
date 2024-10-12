using ECommerce.WebAPI.Models;
using ECommerce.WebAPI.Service.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        static List<Category> Categories = new List<Category>()
    {
        new Category { Id = 1,Name = "Elektronik Eşya" },
        new Category { Id = 2,Name = "Telefon" },
        new Category { Id = 3,Name = "Televizyon" },
        new Category { Id = 4,Name = "Bilgisayar araç gereçleri"},
        new Category { Id = 5,Name = "Kıyafet"}


    };

      

        [HttpGet]
        public List<Category> GetAll()
        {
            return Categories;
        }

        [HttpGet("getbyid")]
        public Category GetById([FromQuery] int id)
        {
            Category category = Categories.SingleOrDefault(x => x.Id == id);
            return category;
        }

    }
}
