using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewRetail.Models.Store
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public List<Price> Price { get; set; }
    }
}
