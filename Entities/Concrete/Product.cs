﻿using Entities.Abstract;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
    }
}
