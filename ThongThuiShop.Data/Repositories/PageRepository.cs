using ThongThuiShop.Data.Infrastructure;
using ThongThuiShop.Model.Models;

namespace ThongThuiShop.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}