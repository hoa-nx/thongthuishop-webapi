using ThongThuiShop.Data.Infrastructure;
using ThongThuiShop.Model.Models;

namespace ThongThuiShop.Data.Repositories
{
    public interface IMenuRepository : IRepository<Function>
    {
    }

    public class MenuRepository : RepositoryBase<Function>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}