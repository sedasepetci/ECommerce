using ECommerce.WebAPI.Models;

namespace ECommerce.WebAPI.Service.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category? GetById(int id);
        Category Add(Category category);
        Category Update(Category category);
        Category Delete(int id);
    }
}
