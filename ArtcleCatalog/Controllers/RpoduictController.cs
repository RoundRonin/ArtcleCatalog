﻿using Microsoft.AspNetCore.Mvc;
using BLL;
using BLL.DTOs;
using ArtcleCatalog.ViewModels;

namespace ArtcleCatalog.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    // 2. Create a product
    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] ProductViewModel product)
    {
        // Translate presentation layer ViewModel to a BLL DTO
        var productDto = new ProductDTO
        {
            Id = product.Id,
            Name = product.Name
        };

        await _productService.CreateProductAsync(productDto);
        return CreatedAtAction(nameof(GetProductById), new { id = productDto.Id }, productDto);
    }

    // Get a product by ID
    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(int id)
    {
        var product = await _productService.GetProductByIdAsync(id);
        return product != null ? (IActionResult)Ok(product) : NotFound();
    }
}

