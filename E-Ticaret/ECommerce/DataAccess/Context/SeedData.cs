using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class SeedData:CreateDatabaseIfNotExists<ProjectDbContext>
    {
        protected override void Seed(ProjectDbContext context)
        {
            List<AppUserRole> roleList = new List<AppUserRole>()
            {
                new AppUserRole{Role=CORE.CoreEntity.Enums.Role.Admin},
                new AppUserRole{Role=CORE.CoreEntity.Enums.Role.Member}
            };

            foreach (var role in roleList)
            {
                context.AppUserRoles.Add(role);
                context.SaveChanges();
            }

            List<AppUser> appUserList = new List<AppUser>
            {
                new AppUser{UserName="testAdmin",Password="1234"},
                new AppUser{UserName="testUser",Password="1234"}
            };

            foreach (var user in appUserList)
            {
                context.AppUsers.Add(user);
                context.SaveChanges();
            }

            List<AppUserAndRole> appUserAndRoleList = new List<AppUserAndRole>()
            {
                new AppUserAndRole{AppUserId=1,RoleId=1},
                new AppUserAndRole{AppUserId=2,RoleId=2}
            };

            foreach (var ur in appUserAndRoleList)
            {
                context.AppUserAndRoles.Add(ur);
                context.SaveChanges();
            }

            base.Seed(context);
        }
    }
}
