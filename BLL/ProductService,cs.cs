﻿using System.Threading.Tasks;
using BLL.DTOs;
using BLL.Infrastructure;
using DAL.Infrastructure;
using DAL.Entities;

namespace BLL;

public class ProductService : IProductService
{
    private readonly IRepository<Product> _productRepository;

    public ProductService(IRepository<Product> productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ProductDTO> CreateProductAsync(ProductDTO productDto)
    {
        var product = new Product
        {
            Id = productDto.Id,
            Name = productDto.Name
        };

        await _productRepository.AddAsync(product);
        return productDto;
    }

    public async Task<ProductDTO> GetProductByIdAsync(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        if (product == null)
        {
            return null;
        }

        return new ProductDTO
        {
            Id = product.Id,
            Name = product.Name
        };
    }
}
