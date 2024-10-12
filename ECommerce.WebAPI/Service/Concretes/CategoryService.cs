using ECommerce.WebAPI.Models;
using ECommerce.WebAPI.Repository.Abstracts;

using ECommerce.WebAPI.Service.Abstracts;

namespace ECommerce.WebAPI.Service.Concretes
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category Add(Category category)
        {
            Category added = _categoryRepository.Add(category);
            return added;
        }

        public Category Delete(int id)
        {
            Category category = _categoryRepository.Delete(id);
            return category;
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category? GetById(int id)
        {
           Category category= _categoryRepository.GetById(id);
            return category;
        }

        public Category Update(Category category)
        {
            Category updated = _categoryRepository.Update(category);
            return updated;
        }
    }
}
