using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThongThuiShop.Data;
using ThongThuiShop.Model.Models;

namespace ThongThuiShop.Identity
{
    public class ApplicationRoleManager : RoleManager<AppRole>
    {
        public ApplicationRoleManager(IRoleStore<AppRole,string> roleStore)
            : base(roleStore)
        {
        }

        public static ApplicationRoleManager Create(IdentityFactoryOptions<ApplicationRoleManager> options, IOwinContext context)
        {
            return new ApplicationRoleManager(new RoleStore<AppRole>(context.Get<TeduShopDbContext>()));
        }
    }
}
