using ECommerce.WebAPI.Contexts;
using ECommerce.WebAPI.Models;
using ECommerce.WebAPI.Repository.Abstracts;

namespace ECommerce.WebAPI.Repository.Concretes
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private MsSqlContext _context;

        public EfCategoryRepository(MsSqlContext context)
        {
            _context = context;
        }

        public Category Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public Category Delete(int id)
        {
            Category category = GetById(id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return category;
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category? GetById(int id)
        {
            Category category = _context.Categories.Find(id);
            return category;
        }

        public Category Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return category;
        }
    }
}
