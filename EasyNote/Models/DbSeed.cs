using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyNote.Models
{
    public static class DbSeed
    {
        public static void SeedRolesAndUsers()
        {
            using (var context = new ApplicationDbContext())
            {
                if (!context.Roles.Any(x => x.Name == "admin"))
                {
                    var roleStore = new RoleStore<IdentityRole>(context);
                    var roleManager = new RoleManager<IdentityRole>(roleStore);
                    roleManager.Create(new IdentityRole("admin"));
                }

                if (!context.Users.Any(x => x.UserName == "admin@berdanasen.online"))
                {
                    var userStore = new UserStore<ApplicationUser>(context);
                    var userManager = new UserManager<ApplicationUser>(userStore);
                    var adminUser = new ApplicationUser()
                    {
                        UserName = "admin@berdanasen.online",
                        Email = "admin@berdanasen.online",
                        EmailConfirmed = true,
                        DisplayName = "admin"
                    };
                    userManager.Create(adminUser, "P@sword1");
                    userManager.AddToRole(adminUser.Id, "admin");
                }
            }
        }
    }
}