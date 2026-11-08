using HelloAppSecond;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

WebApplication app = builder.Build();

ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
ILogger logger = loggerFactory.CreateLogger<Program>();

app.Run(async (context) =>
{
    logger.LogInformation($"Requested path: {context.Request.Path}");
    await context.Response.WriteAsync("Hello world");
});

app.Run();