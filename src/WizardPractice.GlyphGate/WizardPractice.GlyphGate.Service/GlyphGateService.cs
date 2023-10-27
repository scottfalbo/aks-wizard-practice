// ------------------------------------
// Wizard Practice AKS Micro Services
// ------------------------------------

using ProtoBuf.Grpc;
using WizardPractice.GlyphGate.ServiceContracts;

namespace WizardPractice.GlyphGate.Service
{
    public class GlyphGateService : IGlyphGateService
    {
        public async Task<ResponseScroll> CreateGlyph(RequestScroll request, CallContext context = default)
        {
            var responseScroll = new ResponseScroll
            {
                Id = request.Id,
            };

            await Task.CompletedTask;
            return responseScroll;
        }
    }
}