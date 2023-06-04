using Microsoft.Extensions.DependencyInjection;
using Paraclete.Menu;
using Paraclete.Painting;
using Paraclete.Screens;

namespace Paraclete.Configuration;

public static class Configurator
{
    public static IServiceProvider Configure()
    {
        var services = new ServiceCollection();

        services
            .AddScoped<ExhibitionSelector>()
            .AddScoped<FpsCounter>()
            .AddScoped<FrameInvalidator>()
            .AddScoped<MainLoop>()
            .AddScoped<MenuPainter>()
            .AddScoped<ScreenSaver>()
            .AddScoped<ScreenSelector>()
            .AddScoped<Settings>()
            .AddScoped<Stopwatch>()
            .AddScoped<ToDoList>()
            .AddScoped<ToDoListPainter>()
            .AddScoped<Painter>()

            .AddImplementationsOf<ICommand>()
            .AddImplementationsOf<IExhibition>()
            .AddImplementationsOf<IScreen>()
            .AddImplementationsOf<MenuBase>()
        ;

        return services.BuildServiceProvider();
    }

    private static IServiceCollection AddImplementationsOf<T>(this IServiceCollection services)
    {
        foreach (var menuItemType in TypeUtility.EnumerateImplementingTypesOf<T>())
        {
            services.AddScoped(menuItemType);
        }

        return services;
    }
}