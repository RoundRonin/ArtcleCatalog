﻿namespace BLL.DTOs;
 
public class InventoryDTO
{
    public required string StoreCode { get; set; }
    public required string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
