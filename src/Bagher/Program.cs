var builder = WebApplication.CreateBuilder(args);

builder.Services.AddReverseProxy()
                .LoadFromConfig(builder.Configuration.GetSection("Yarp"));

var app = builder.Build();
app.MapReverseProxy();
app.Run();
 