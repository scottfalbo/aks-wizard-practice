// ------------------------------------
// Wizard Practice AKS Micro Services
// ------------------------------------

using ProtoBuf;

namespace WizardPractice.ReagentReservoir.ServiceContracts
{
    public class RequestScroll
    {
        [ProtoMember(1)]
        public string Id { get; set; }

        public RequestScroll()
        {
            Id = string.Empty;
        }
    }
}