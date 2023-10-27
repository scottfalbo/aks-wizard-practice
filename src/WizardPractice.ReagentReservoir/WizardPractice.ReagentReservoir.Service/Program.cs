// ------------------------------------
// Wizard Practice AKS Micro Services
// ------------------------------------

using ProtoBuf.Grpc.Server;
using WizardPractice.ReagentReservoir.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCodeFirstGrpc();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGrpcService<ReagentReservoirService>();

app.Run();