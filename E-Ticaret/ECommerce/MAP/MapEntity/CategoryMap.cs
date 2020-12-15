using CORE.CoreMap;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP.MapEntity
{
    public class CategoryMap:CoreMap<Category>
    {
        public CategoryMap()
        {
            Property(x => x.CategoryName).HasMaxLength(100).IsRequired();
            Property(x => x.Description).HasMaxLength(255).IsRequired();


        }
    }
}
