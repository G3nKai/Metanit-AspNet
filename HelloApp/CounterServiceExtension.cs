public static class CounterServiceExtension
{
    public static void AddCounterService(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<CounterService>();
    }
}
