// ReSharper disable UnusedMember.Global

namespace Tenjin.Tests.Data.Builders;

/// <summary>
/// The abstract class that enables one to build data for unit/integration testing purposes.
/// </summary>
public abstract class DataBuilder
{
    /// <summary>
    /// Saves all data.
    /// </summary>
    public abstract void Save();
}