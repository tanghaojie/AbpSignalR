using System.Data.Entity.Migrations;

namespace AbpWithoutUser.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AbpWithoutUser.EntityFramework.AbpWithoutUserDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AbpWithoutUser";
        }

        protected override void Seed(AbpWithoutUser.EntityFramework.AbpWithoutUserDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
