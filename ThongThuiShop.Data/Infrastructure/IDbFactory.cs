using System;

namespace ThongThuiShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ThongThuiShopDbContext Init();
    }
}