// ------------------------------------
// Wizard Practice AKS Micro Services
// ------------------------------------

using ProtoBuf.Grpc.Server;
using System.Net;
using WizardPractice.GlyphGate.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCodeFirstGrpc();

var certificatePassword = builder.Configuration.GetValue<string>("Password");

builder.WebHost.ConfigureKestrel(options =>
{
    options.Listen(IPAddress.Any, 80); // HTTP
    options.Listen(IPAddress.Any, 443, listenOptions =>
    {
        listenOptions.UseHttps("aspnetapp.pfx", certificatePassword);
    });
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGrpcService<GlyphGateService>();

app.Run();