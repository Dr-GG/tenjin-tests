using System.Linq;
using AutoFixture;
using Tenjin.Tests.Data.Builders.AutoFixture.Options;
using Tenjin.Tests.Data.Builders.AutoFixture.SpecimenBuilders;

namespace Tenjin.Tests.Data.Builders.AutoFixture
{
    public abstract class AutoFixtureDataBuilder : DataBuilder
    {
        protected AutoFixtureDataBuilder(AutoFixtureDataBuilderOptions? options = null)
        {
            options ??= AutoFixtureDataBuilderOptions.Default;

            Fixture = new Fixture();

            InitialiseFixture(options);
        }
        
        public Fixture Fixture { get; }

        private void InitialiseFixture(AutoFixtureDataBuilderOptions options)
        {
            if (options.OmitRecursions)
            {
                OmitRecursion();
            }

            if (options.OmitComplexTypes)
            {
                OmitComplexTypes();
            }
        }

        private void OmitComplexTypes()
        {
            var builder = new OmitComplexTypesSpecimenBuilder();

            Fixture.Customizations.Insert(0, builder);
        }

        private void OmitRecursion()
        {
            Fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            Fixture.Behaviors
                .OfType<ThrowingRecursionBehavior>()
                .ToList()
                .ForEach(x => Fixture.Behaviors.Remove(x));
        }
    }
}
