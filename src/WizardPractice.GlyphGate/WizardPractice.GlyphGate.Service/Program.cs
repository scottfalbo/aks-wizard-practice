// ------------------------------------
// Wizard Practice AKS Micro Services
// ------------------------------------

using ProtoBuf.Grpc.Server;
using WizardPractice.GlyphGate.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCodeFirstGrpc();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGrpcService<GlyphGateService>();

app.Run();