
using ECommerce.WebApi.Service.Mappers;
using ECommerce.WebAPI.Dtos.Products.Requests;
using ECommerce.WebAPI.Dtos.Products.Responses;
using ECommerce.WebAPI.Models;
using ECommerce.WebAPI.Repository.Abstracts;
using ECommerce.WebAPI.Service.Abstracts;

namespace ECommerce.WebApi.Service.Concretes;

public class ProductService : IProductService
{

    private IProductRepository _productRepository;
    private ProductMapper _productMapper;
    public ProductService(IProductRepository productRepository, ProductMapper mapper)
    {
        _productRepository = productRepository;
        _productMapper = mapper;
    }


    public Product Add(CreateProductRequest dto)
    {

        Product product = _productMapper.ConvertToEntity(dto);

        Product added = _productRepository.Add(product);

        return added;
    }

    public Product? Delete(int id)
    {
        Product product = _productRepository.Delete(id);

        return product;
    }

    public List<ProductResponseDto> GetAll()
    {
        List<Product> products = _productRepository.GetAll();
        List<ProductResponseDto> responses = _productMapper.ConvertToResponseList(products);

        return responses;
    }

    public ProductResponseDto? GetById(int id)
    {
        Product product = _productRepository.GetById(id);

        ProductResponseDto dto = _productMapper.ConvertToResponse(product);
        return dto;
    }

    public Product Update(Product product)
    {
        Product updated = _productRepository.Update(product);
        return updated;
    }
}