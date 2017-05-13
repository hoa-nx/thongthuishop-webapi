namespace ThongThuiShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ThongThuiShopDbContext dbContext;

        public ThongThuiShopDbContext Init()
        {
            return dbContext ?? (dbContext = new ThongThuiShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}