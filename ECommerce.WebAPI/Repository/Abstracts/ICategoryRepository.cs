﻿using ECommerce.WebAPI.Models;

namespace ECommerce.WebAPI.Repository.Abstracts
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category? GetById(int id);
        Category Add(Category category);
        Category Update(Category category);
        Category Delete(int id);
    }
}
