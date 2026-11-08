public class CounterMiddleware
{
    RequestDelegate next;
    int i = 0;
    public CounterMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext context, ICounter counter, CounterService counterService)
    {
        i++;
        await context.Response.WriteAsync($"Запрос: №{i}\tCounter: {counter.Value}\tService: {counterService.Counter.Value}");
    }
}
