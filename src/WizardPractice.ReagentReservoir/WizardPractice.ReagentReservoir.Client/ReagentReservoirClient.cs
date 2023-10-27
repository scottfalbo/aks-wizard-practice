// ------------------------------------
// Wizard Practice AKS Micro Services
// ------------------------------------

using Grpc.Net.Client;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Client;
using WizardPractice.ReagentReservoir.ServiceContracts;

namespace WizardPractice.ReagentReservoir.Client
{
    public class ReagentReservoirClient : IReagentReservoirService
    {
        private readonly IReagentReservoirService _client;

        public ReagentReservoirClient()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5222");
            _client = channel.CreateGrpcService<IReagentReservoirService>();
        }

        public async Task<ResponseScroll> DepositReagents(RequestScroll request, CallContext context = default)
        {
            var requestScroll = new RequestScroll()
            {
                Id = request.Id,
            };

            var responseScroll = await _client.DepositReagents(requestScroll);

            return responseScroll;
        }
    }
}