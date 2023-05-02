using Padutronics.DependencyInjection;

namespace Padutronics.Formatting.Geometry.DependencyInjection.Modules;

public sealed class GeometryFormattingContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<PointFormatOptions>().UseSelf().InstancePerDependency();
    }
}