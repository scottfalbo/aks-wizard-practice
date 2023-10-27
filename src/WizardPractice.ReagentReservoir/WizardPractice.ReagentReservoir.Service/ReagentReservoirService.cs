// ------------------------------------
// Wizard Practice AKS Micro Services
// ------------------------------------

using ProtoBuf.Grpc;
using WizardPractice.ReagentReservoir.ServiceContracts;

namespace WizardPractice.ReagentReservoir.Service
{
    public class ReagentReservoirService : IReagentReservoirService
    {
        public async Task<ResponseScroll> DepositReagents(RequestScroll request, CallContext context = default)
        {
            var responseScroll = new ResponseScroll
            {
                Id = request.Id,
            };

            await Task.CompletedTask;
            return responseScro