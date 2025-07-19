using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        public required string Name { get; set; }  // when it comes to entity framework access specifier should be public
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public required string  PictureUrl { get; set; }
        public required string  Type { get; set; }
        public required string  Brand { get; set; }
        public int  QuantityInStock { get; set; }
    }
}
