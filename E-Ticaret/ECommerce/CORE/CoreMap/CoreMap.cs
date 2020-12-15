using CORE.CoreEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.CoreMap
{
    public class CoreMap<T>:EntityTypeConfiguration<T> where T:EntityRepository
    {
        public CoreMap()
        {
            Property(x => x.CreatedAdUserName).HasColumnName("CreatedAdusername").IsOptional();
            Property(x => x.CreatedComputerName).HasColumnName("CreatedComputerName").IsOptional();
            Property(x => x.UpdateDate).HasColumnName("UpdatedDate").IsOptional();
            Property(x => x.MasterId).HasColumnName("MasterId").IsOptional();
            Property(x => x.CreatedIP).HasColumnName("CreatedIp").IsOptional();
            Property(x => x.UpdatedIP).HasColumnName("UpdatedIp").IsOptional();

        }
    }
}
