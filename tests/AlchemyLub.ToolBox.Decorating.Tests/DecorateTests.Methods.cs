namespace AlchemyLub.ToolBox.Decorating.UnitTests;

/// <summary>
/// Общие методы для тестов на <see cref="ServiceCollectionExtensions.Decorate{TInterface,TDecorator}"/>
/// </summary>
public partial class DecorateTests
{
    private static ServiceProvider ConfigureProvider(Action<IServiceCollection> configure)
    {
        ServiceCollection services = new();

        configure(services);

        return services.BuildServiceProvider();
    }
}
