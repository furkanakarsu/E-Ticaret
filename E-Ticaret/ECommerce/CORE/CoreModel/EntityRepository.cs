using CORE.CoreEntity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CORE.CoreEntity
{
    public class EntityRepository : IEntity<int>
    {
        public EntityRepository()
        {
            CreatedDate = DateTime.Now;
            CreatedComputerName = Environment.MachineName;
            CreatedAdUserName = WindowsIdentity.GetCurrent().Name;
            CreatedBy = "varsayılan";
            CreatedIP= "192.168.1.1";
            Status = Status.Active;
        }
        public int Id { get  ; set ; }
        public int? MasterId { get; set; }

        //Veri oluşturulduğunda
        public DateTime CreatedDate { get; set; } //user
        public string CreatedComputerName { get; set; }
        public string CreatedIP { get; set; }
        public string CreatedAdUserName { get; set; }
        public string CreatedBy { get; set; }

        //Veri güncellendiğinde
        //Todo: güncelleme işlemi yapılacak.
        public DateTime? UpdateDate { get; set; } //admin
        public string UpdatedComputerName { get; set; }
        public string UpdatedIP { get; set; }
        public string UpdatedAdUserName { get; set; }
        public string UpdatedBy { get; set; }

        public Status Status { get; set; }



    }
}
