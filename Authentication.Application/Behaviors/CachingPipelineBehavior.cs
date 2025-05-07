using Microsoft.Extensions.Logging;
using Authentication.Application.Abstractions.Messaging;
using Microsoft.Extensions.Caching.Memory;

namespace Authentication.Application.Behaviors
{
    public class CachingPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IMemoryCache _cache;
        private readonly ILogger<CachingPipelineBehavior<TRequest, TResponse>> _logger;

        public CachingPipelineBehavior(IMemoryCache cache, ILogger<CachingPipelineBehavior<TRequest, TResponse>> logger)
        {
            _cache = cache;
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            // Try to get the cached result
            var cacheKey = GetCacheKey(request);
            if (_cache.TryGetValue(cacheKey, out TResponse cachedResult))
            {
                _logger.LogInformation("Returning cached result for {RequestType}", typeof(TRequest).Name);
                return cachedResult;
            }

            // No cache, proceed with handler execution
            var result = await next();

            // Cache the result
            _cache.Set(cacheKey, result, TimeSpan.FromMinutes(10)); // Cache expiration time can be adjusted
            return result;
        }

        private string GetCacheKey(TRequest request)
        {
            // Generate a unique cache key based on request properties (e.g., request.ToString() or other properties)
            return $"{typeof(TRequest).Name}:{request.GetHashCode()}";
        }
    }

}
