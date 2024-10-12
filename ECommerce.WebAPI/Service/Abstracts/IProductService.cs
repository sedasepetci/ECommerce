using ECommerce.WebAPI.Dtos.Products.Requests;
using ECommerce.WebAPI.Dtos.Products.Responses;
using ECommerce.WebAPI.Models;

namespace ECommerce.WebAPI.Service.Abstracts
{
    public interface IProductService
    {
        List<ProductResponseDto> GetAll();
        ProductResponseDto? GetById(int id);

        Product Add(CreateProductRequest product);
        Product Update(Product product);

        Product? Delete(int id);

    }
}
