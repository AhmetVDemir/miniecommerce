﻿using ECommerceBackend.Domain.Entities.Abstraction;

namespace ECommerceBackend.Domain.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public string Description { get; set; }

        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }

        public Customer Customer { get; set; }
    }
}
