namespace Tenjin.Tests.Data.Builders.AutoFixture.Options
{
    public class AutoFixtureDataBuilderOptions
    {
        public static readonly AutoFixtureDataBuilderOptions Default = new()
        {
            OmitComplexTypes = true,
            OmitRecursions = true
        };

        public bool OmitRecursions { get; set; }

        public bool OmitComplexTypes { get; set; }
    }
}
