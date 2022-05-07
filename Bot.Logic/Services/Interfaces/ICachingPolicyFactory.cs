using Polly.Caching;

namespace Bot.Logic.Services.Interfaces;

/// <summary>
/// Фабрика для создания политик кэширования.
/// </summary>
public interface ICachingPolicyFactory
{
    /// <summary>
    /// Создаёт экземпляр политики кэширования.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns><see cref="AsyncCachePolicy{TResult}"/>.</returns>
    AsyncCachePolicy<T> CreateAsyncCachePolicy<T>();
}