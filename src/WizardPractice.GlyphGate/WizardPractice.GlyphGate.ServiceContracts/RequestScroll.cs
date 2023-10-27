// ------------------------------------
// Wizard Practice AKS Micro Services
// ------------------------------------

using ProtoBuf;

namespace WizardPractice.GlyphGate.ServiceContracts
{
    [ProtoContract]
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