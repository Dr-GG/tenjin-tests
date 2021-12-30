using Microsoft.EntityFrameworkCore;
using Tenjin.Tests.Data.Builders.AutoFixture.Options;

namespace Tenjin.Tests.Data.Builders.AutoFixture.EntityFramework
{
    public abstract class EntityFrameworkAutoFixtureDataBuilder<TDbContext> : AutoFixtureDataBuilder where TDbContext : DbContext
    {
        protected EntityFrameworkAutoFixtureDataBuilder(
            TDbContext dbContext,
            AutoFixtureDataBuilderOptions? options = null) : base(options)
        {
            DbContext = dbContext;
        }

        public DbContext DbContext { get; }

        public override void Save()
        {
            DbContext.SaveChanges();
        }
    }
}
