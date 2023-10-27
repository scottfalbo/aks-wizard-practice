// ------------------------------------
// Wizard Practice AKS Micro Services
// ------------------------------------

using Grpc.Net.Client;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Client;
using WizardPractice.GlyphGate.ServiceContracts;

namespace WizardPractice.GlyphGate.Client
{
    public class GlyphGateClient : IGlyphGateService
    {
        private readonly IGlyphGateService _client;

        public GlyphGateClient()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5287");
            _client = channel.CreateGrpcService<IGlyphGateService>();
        }

        public async Task<ResponseScroll> CreateGlyph(RequestScroll request, CallContext context = default)
        {
            var requestScroll = new RequestScroll()
            {
                Id = request.Id,
            };

            var responseScroll = await _client.CreateGlyph(requestScroll);

            return responseScroll;
        }
    }
}