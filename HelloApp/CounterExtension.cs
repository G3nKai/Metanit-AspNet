public static class CounterExtension
{
    public static void AddCounter(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<ICounter,  RandomCounter>();
    }
}
