﻿using System.ComponentModel.DataAnnotations;

namespace ArticleCatalog.ViewModels.BatchPricing;

public class ProductDeliveryViewModel
{
    [Required(ErrorMessage = "Product ID is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "Id must be at least 1.")]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Price is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "Price must be at least 1.")]
    public decimal Price { get; set; }


    [Required(ErrorMessage = "Quantity is required.")] 
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
    public int Quantity { get; set; }
}
