using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ConfigurationDevelopment.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot();
builder.Services.AddAuthentication().AddJwtBearer("GatewayAuthenticationScheme", options =>
{
    options.Authority = builder.Configuration["IdentityServerUrl"];
    options.Audience = "resource_gateway";
    options.RequireHttpsMetadata = false;
});
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
await app.UseOcelot();
app.Run();
