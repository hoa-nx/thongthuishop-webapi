using ThongThuiShop.Data.Infrastructure;
using ThongThuiShop.Model.Models;

namespace ThongThuiShop.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}