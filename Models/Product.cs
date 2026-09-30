using System;
using System.Collections.Generic;
using System.Text;

namespace ef_core.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
