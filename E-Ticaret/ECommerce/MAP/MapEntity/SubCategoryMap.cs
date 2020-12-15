using CORE.CoreMap;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP.MapEntity
{
    public class SubCategoryMap:CoreMap<SubCategory>
    {
        public SubCategoryMap()
        {
            Property(x => x.SubCategoryName).HasMaxLength(150).IsRequired();
            Property(x => x.Description).HasMaxLength(255).IsOptional();


        }
    }
}
