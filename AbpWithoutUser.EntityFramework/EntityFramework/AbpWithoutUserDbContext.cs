using System.Data.Common;
using Abp.EntityFramework;

namespace AbpWithoutUser.EntityFramework
{
    public class AbpWithoutUserDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AbpWithoutUserDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AbpWithoutUserDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AbpWithoutUserDbContext since ABP automatically handles it.
         */
        public AbpWithoutUserDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AbpWithoutUserDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public AbpWithoutUserDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
