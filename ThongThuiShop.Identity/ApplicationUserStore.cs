using Microsoft.AspNet.Identity.EntityFramework;
using ThongThuiShop.Data;
using ThongThuiShop.Model.Models;

namespace ThongThuiShop.Identity
{
    public class ApplicationUserStore : UserStore<AppUser>
    {
        public ApplicationUserStore(TeduShopDbContext context)
            : base(context)
        {
        }
    }
}