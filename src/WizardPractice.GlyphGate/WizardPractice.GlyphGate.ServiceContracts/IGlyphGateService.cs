// ------------------------------------
// Wizard Practice AKS Micro Services
// ------------------------------------

using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace WizardPractice.GlyphGate.ServiceContracts
{
    [Service]
    public interface IGlyphGateService
    {
        Task<ResponseScroll> CreateGlyph(RequestScroll request, CallContext context = default);
    }
}