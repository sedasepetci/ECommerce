using ECommerce.WebAPI.Contexts;
using ECommerce.WebAPI.Models;
using ECommerce.WebAPI.Repository.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.WebAPI.Repository.Concretes;

public class EfProductRepository : IProductRepository
{
    private MsSqlContext _context;

    public EfProductRepository(MsSqlContext context)
    {
        _context = context;
    }

    public Product Add(Product product)
    {
       _context.Products.Add(product);
        _context.SaveChanges();
        return product;
    }

    public Product? Delete(int id)
    {
       Product product=GetById(id);
        _context.Products.Remove(product);
        _context.SaveChanges();
        return product; 
    }

    public List<Product> GetAll()
    {
       return _context.Products.Include(x=>x.Category).ToList();//include ilgili kategoriyi bulur.
    }

    public Product? GetById(int id)
    {
       Product? product = _context.Products.Include(x=>x.Category).SingleOrDefault(x=>x.Id==id);
        return product;
    }

    public Product Update(Product product)
    {
       _context.Products.Update(product);
        _context.SaveChanges();
        return product;
    }
}
