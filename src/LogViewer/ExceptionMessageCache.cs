using Microsoft.Extensions.Caching.Memory;
using System;

namespace LogViewer;

internal class ExceptionMessageCache
{
    private readonly MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());

    public void AddToCache(int key, object value)
    {
        _cache.Set(key, value, new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
        });
    }

    public bool TryGetFromCache(int key, out string cachedValue)
    {
        return _cache.TryGetValue(key, out cachedValue);
    }

    public void RemoveFromCache(int key)
    {
        _cache.Remove(key);
    }
}
