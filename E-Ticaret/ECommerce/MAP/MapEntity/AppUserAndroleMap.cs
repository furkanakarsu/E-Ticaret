using CORE.CoreMap;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP.MapEntity
{
    public class AppUserAndroleMap:CoreMap<AppUserAndRole>
    {
        public AppUserAndroleMap()
        {
            Ignore(x => x.Id);
            HasKey(x => new { x.AppUserId, x.RoleId });
        }
    }
}
