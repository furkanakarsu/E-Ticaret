using CORE.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class Order:EntityRepository
    {
       
        public Guid AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public bool IsConfirmed { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
