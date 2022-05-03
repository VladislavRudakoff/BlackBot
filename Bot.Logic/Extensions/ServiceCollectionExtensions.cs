using Bot.Logic.Providers;
using Bot.Logic.Providers.Interfaces;
using Bot.Logic.Services;
using Bot.Logic.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Bot.Logic.Extensions;

/// <summary>
/// Класс с методами расширений для <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрирует все сервисы бота.
    /// </summary>
    /// <param name="service"></param>
    /// <returns></returns>
    public static IServiceCollection AddServices(this IServiceCollection service) =>
        service
            .AddScoped<IRoleProvider, RoleProvider>()
            .AddScoped<IUserProvider, UserProvider>()
            .AddScoped<ITextDecorator, TextDecorator>();
}