using System.Data.Common;
using Abp.Zero.EntityFramework;
using Lyx.Admin.Authorization.Roles;
using Lyx.Admin.MultiTenancy;
using Lyx.Admin.Users;
using System.Data.Entity;
using Lyx.Admin.Spider;

using System.Linq;
using Lyx.Admin.TaoJin;

namespace Lyx.Admin.EntityFramework
{
    public class AdminDbContext : AbpZeroDbContext<Tenant, Role, User>
    {

        public virtual IDbSet<ArticleSpider> Questions { get; set; }

        public virtual IDbSet<NovelSpider> Answers { get; set; }
        public virtual IDbSet<InterFruit> InterFruit { get; set; }

        public virtual IDbSet<Fruit> Fruits { get; set; }
        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AdminDbContext()
            : base("Default")
        {
            
        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AdminDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AdminDbContext since ABP automatically handles it.
         */
        public AdminDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AdminDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<InterFruit>().Property(x => x.IncreaseRate).HasPrecision(18,6);
            modelBuilder.Entity<InterFruit>().Property(x => x.Increase).HasPrecision(18, 6);
            modelBuilder.Entity<InterFruit>().Property(x => x.OpenPrice).HasPrecision(18, 6);
            modelBuilder.Entity<InterFruit>().Property(x => x.HighestPrice).HasPrecision(18, 6);
            modelBuilder.Entity<InterFruit>().Property(x => x.LowestPrice).HasPrecision(18, 6);
            modelBuilder.Entity<InterFruit>().Property(x => x.Price).HasPrecision(18, 6);
            modelBuilder.Entity<InterFruit>().Property(x => x.Volume).HasPrecision(18, 2);
        
        }
    }
}
