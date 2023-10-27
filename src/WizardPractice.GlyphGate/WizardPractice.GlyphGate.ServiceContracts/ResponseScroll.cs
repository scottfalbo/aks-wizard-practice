// ------------------------------------
// Wizard Practice AKS Micro Services
// ------------------------------------

using ProtoBuf;

namespace WizardPractice.GlyphGate.ServiceContracts
{
    [ProtoContract]
    public class ResponseScroll
    {
        [ProtoMember(1)]
        public string Id { get; set; }

        public ResponseScroll()
        {
            Id = string.Empty;
        }
    }
}