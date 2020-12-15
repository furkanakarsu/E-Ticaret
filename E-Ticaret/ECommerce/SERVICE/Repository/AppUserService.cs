using MODEL.Entities;
using SERVICE.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Repository
{
    public class AppUserService:BaseService<AppUser>
    {
        public bool Login(AppUser user)
        {
            return Any(x => x.UserName == user.UserName && x.Password == user.Password);
        }
    }
}
