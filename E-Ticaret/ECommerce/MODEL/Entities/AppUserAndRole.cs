using CORE.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class AppUserAndRole:EntityRepository
    {
        public int AppUserId { get; set; }
        public int RoleId { get; set; }
        public AppUser AppUser { get; set; }
        public AppUserRole AppUserRole { get; set; }
    }
}
