using AutoFixture;
using Tenjin.Tests.Data.Builders.AutoFixture;
using Tenjin.Tests.Data.Builders.AutoFixture.Options;
using Tenjin.Tests.Tests.Models;

namespace Tenjin.Tests.Tests.Services.Data.Builders.AutoFixture
{
    public class UnitTestAutoFixtureDataBuilder : AutoFixtureDataBuilder
    {
        public UnitTestAutoFixtureDataBuilder(AutoFixtureDataBuilderOptions options) : base(options)
        { }

        public AutoFixtureChildObject CreateChildObject()
        {
            return Fixture.Build<AutoFixtureChildObject>().Create();
        }

        public AutoFixtureCarObject CreateCarObject()
        {
            return Fixture.Build<AutoFixtureCarObject>().Create();
        }

        public override void Save()
        { }
    }
}
