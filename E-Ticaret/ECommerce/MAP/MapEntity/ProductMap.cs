using CORE.CoreMap;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP.MapEntity
{
    public class ProductMap:CoreMap<Product>
    {
        public ProductMap()
        {
            Property(x => x.ProductName).HasMaxLength(150).IsRequired();
            Property(x => x.UnitPrice).IsRequired().IsOptional();


        }
    }
}
