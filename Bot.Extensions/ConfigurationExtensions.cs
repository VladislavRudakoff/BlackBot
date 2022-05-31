using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bot.Common.Extensions;

/// <summary>
/// Класс с методами расширений для <see cref="IConfiguration"/>
/// </summary>
public static class ConfigurationExtensions
{
    /// <summary>
    /// Биндит кастомные конфиги.
    /// </summary>
    /// <typeparam name="T">Вид конфига.</typeparam>ы
    /// <param name="configuration"><see cref="IConfiguration"/>.</param>
    /// <returns>Конфигурация.</returns>
    public static T BindConfig<T>(this IConfiguration configuration) where T : new()
    {
        T instance = configuration
            .GetSection(typeof(T).Name)
            .Get<T>();

        return instance;
    }

    /// <summary>
    /// Регистрирует singleton экземпляр конфига.
    /// </summary>
    /// <typeparam name="T">Вид конфига.</typeparam>
    /// <param name="services"><see cref="IServiceCollection"/>.</param>
    /// <param name="configuration"><see cref="IConfiguration"/>.</param>
    /// <returns><see cref="IConfiguration"/>.</returns>
    public static IServiceCollection AddConfigAsSingleton<T>(
        this IServiceCollection services,
        IConfiguration configuration) where T : class, new() =>
        services.AddSingleton(_ => configuration.BindConfig<T>());
}