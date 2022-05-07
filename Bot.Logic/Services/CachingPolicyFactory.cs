using System;
using Bot.Data.Settings;
using Bot.Logic.Services.Interfaces;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using Polly;
using Polly.Caching;
using Polly.Caching.Distributed;
using Polly.Caching.Serialization.Json;

namespace Bot.Logic.Services;

/// <inheritdoc cref="ICachingPolicyFactory"/>
public class CachingPolicyFactory: ICachingPolicyFactory
{
    private readonly CachingSettings cachingSettings;
    private readonly IDistributedCache distributedCache;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="cachingSettings"><see cref="CachingSettings"/>.</param>
    /// <param name="distributedCache"><see cref="IDistributedCache"/>.</param>
    public CachingPolicyFactory(
        CachingSettings cachingSettings, 
        IDistributedCache distributedCache)
    {
        this.cachingSettings = cachingSettings;
        this.distributedCache = distributedCache;
    }

    public AsyncCachePolicy<T> CreateAsyncCachePolicy<T>() =>
        Policy.CacheAsync(distributedCache.AsAsyncCacheProvider<string>()
            .WithSerializer(new JsonSerializer<T>(new JsonSerializerSettings())), cachingSettings.CacheTtl);
}