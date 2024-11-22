﻿using ArticleCatalog.Infrastracture;

namespace ArticleCatalog.ViewModels;

    public class InventoryViewModel : IIndexedModel
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
}
