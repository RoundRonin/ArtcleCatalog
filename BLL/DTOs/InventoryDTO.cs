﻿namespace BLL.DTOs;
 
public class InventoryDTO
{
    public int StoreId { get; set; }
    public int ProductId { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
