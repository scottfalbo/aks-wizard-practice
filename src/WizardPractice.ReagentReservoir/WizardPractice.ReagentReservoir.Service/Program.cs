// ------------------------------------
// Wizard Practice AKS Micro Services
// ------------------------------------

using ProtoBuf.Grpc.Server;
using System.Net;
using WizardPractice.ReagentReservoir.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCodeFirstGrpc();

builder.WebHost.ConfigureKestrel(options =>
{
    options.Listen(IPAddress.Any, 80); // HTTP
    options.Listen(IPAddress.Any, 443, listenOptions =>
    {
        listenOptions.UseHttps("aspnetapp.pfx", "your-password"); // Replace "your-password" with your actual password
    }); // HTTPS
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGrpcService<ReagentReservoirService>();

app.Run();