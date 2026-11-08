public static class CounterMiddlewareExtension
{
    public static IApplicationBuilder UseCounter(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CounterMiddleware>();
    }
}