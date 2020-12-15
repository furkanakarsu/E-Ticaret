using CORE.CoreMap;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP.MapEntity
{
    public class OrderDetailMap:CoreMap<OrderDetail>
    {
        public OrderDetailMap()
        {
            Ignore(x => x.Id);
            HasKey(x => new { x.OrderId, x.ProductID });
        }
    }
}
