using CORE.CoreMap;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP.MapEntity
{
    public class AppUserMap:CoreMap<AppUser>
    {
        public AppUserMap()
        {
            Property(x => x.PhoneNumber).HasMaxLength(11).IsOptional();
            Property(x => x.Email).HasMaxLength(100).IsOptional();
            Property(x => x.ImagePath).HasMaxLength(255).IsOptional();
            Property(x => x.UserName).HasMaxLength(50).IsRequired();
            Property(x => x.Password).HasMaxLength(50).IsRequired();
            Property(x => x.Name).HasMaxLength(50).IsOptional();
            Property(x => x.Gender).HasMaxLength(5).IsOptional();
            Property(x => x.LastName).HasMaxLength(50).IsOptional();
            Property(x => x.BirthDate).IsOptional();
            Property(x => x.BirthDate).HasColumnType("datetime2");
        }
    }
}
