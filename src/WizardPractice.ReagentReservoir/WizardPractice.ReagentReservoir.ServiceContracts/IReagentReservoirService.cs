// ------------------------------------
// Wizard Practice AKS Micro Services
// ------------------------------------

using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace WizardPractice.ReagentReservoir.ServiceContracts
{
    [Service]
    public interface IReagentReservoirService
    {
        Task<ResponseScroll> DepositReagents(RequestScroll request, CallContext context = default);
    }
}